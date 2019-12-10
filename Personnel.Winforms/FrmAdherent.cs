using Personnel.BOL;
using Personnel.DAL;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Personnel.Winforms
{
    public partial class FrmAdherent : Form
    {
        private Context currentContext;
        PersonnelDBContext dbcontext = new PersonnelDBContext();
        PersonnelRepository repository = new PersonnelRepository();
        Employee employee = new Employee();

        public FrmAdherent()
        {
            InitializeComponent();
            GererContextes(Context.Initial);
        }

        #region Searching methods
        private Employee GetEmployeeByID(string employeeID)
        {
            repository = new PersonnelRepository();
            return repository.GetEmployees().Where(a=>a.EmployeeID==employeeID).FirstOrDefault();
        }

        private Employee SelectEmployee(string debNom)
        {
            FrmRecAdherent dialog = new FrmRecAdherent(debNom, adherentBindingSource);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                Employee employee = adherentBindingSource.Current as Employee;
                if(employee.Establishment != null)
                {
                    Establishment establishment = dbcontext.Establishments.Find(employee.EstablishmentSiret); // Find the etablishment with the primary key in parameter
                    etablissementTextbox.Text = establishment.Name;
                }
                if(employee.Role != null)
                {
                    Role role = dbcontext.Roles.Find(employee.RoleId); // Find the role with the primary key in parameter
                    roleTextbox.Text = role.Label;
                }
                return adherentBindingSource.Current as Employee;
            }
            else
            {
                return null;
            }
        }

        private void SearchEmployee()
        {
            adherentBindingSource.Clear();
            Employee employee = null;
            if (!string.IsNullOrEmpty(txtAdherentID.Text))
            {
                employee = GetEmployeeByID(txtAdherentID.Text);
                if (employee == null)
                {
                    AdherentEP.SetError(txtAdherentID, "Identifiant inconnu");
                }
            }
            else
            {
                employee = SelectEmployee(txtDebNom.Text);
            }
            if (employee != null)
            {
                adherentBindingSource.DataSource = employee;
                GererContextes(Context.Show);
            }
        }
        #endregion

        #region Controls events
        private void btnEditer_Click(object sender, EventArgs e)
        {
            GererContextes(Context.Edition);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Check if the employee is valid
            if ((adherentBindingSource.Current as Employee).IsValid)
            {
                if (currentContext == Context.New)
                {
                    // Create an employee
                    Employee employee = new Employee();
                    employee.LastName = nomTextBox.Text.Trim();
                    employee.FirstName = prenomTextBox.Text.Trim();
                    employee.BirthDate = Convert.ToDateTime(DateNaissanceTextbox.Text.Trim());
                    employee.GrossSalary = Convert.ToDecimal(salaireTextbox.Text.Trim());
                    employee.EmployeeID = adherentIDTextBox.Text.Trim();
                    if (!String.IsNullOrEmpty(arriveeTextbox.Text.Trim()))
                    {
                        employee.StartDate = Convert.ToDateTime(arriveeTextbox.Text.Trim());
                    }
                    if (!String.IsNullOrEmpty(departTextbox.Text.Trim()))
                    {
                        employee.EndDate = Convert.ToDateTime(departTextbox.Text.Trim());
                    }
                    employee.WorkQuantity = double.Parse(TempsTextbox.Text.Trim());

                    using (PersonnelDBContext dBContext = new PersonnelDBContext())
                    {
                        dbcontext.Employees.Add(employee);
                        dbcontext.SaveChanges();
                    }
                }
                if (currentContext == Context.Edition)
                {
                    // Update the employee
                    employee = adherentBindingSource.Current as Employee;
                    dbcontext = new PersonnelDBContext();
                    dbcontext.Entry(employee).State = EntityState.Modified;
                    dbcontext.SaveChanges();
                }
                GererContextes(Context.Initial);
            }
            else
            {
                MessageBox.Show("Vous devez renseigner les champs obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            AdherentEP.Clear();
            adherentBindingSource.CancelEdit();
            GererContextes(Context.Initial);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private void txtAdherentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmployee();
            }
        }

        private void txtDebNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmployee();
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GererContextes(Context.New);
            adherentBindingSource.Clear();
            etablissementTextbox.Text = null;
            roleTextbox.Text = null;
            adherentBindingSource.AddNew();
            AdherentEP.Clear();
        }

        private void FrmAdherent_Load(object sender, EventArgs e)
        {
            adherentBindingSource.DataSource = repository.GetEmployees();
        }
        #endregion

        #region UI context management
        enum Context
        {
            Initial,
            Show,
            Edition,
            New
        }

        private void AffichageInitial()
        {
            adherentBindingSource.Clear();
            AdherentEP.Clear();
            txtAdherentID.Clear();
            txtDebNom.Clear();
            gbRecherche.Visible = true;
            gbDetails.Visible = false;
            btnAnnuler.Visible = false;
            btnEditer.Visible = false;
            btnValider.Visible = false;
            btnNouveau.Visible = true;
        }

        private void AffichageShow()
        {
            gbRecherche.Visible = true;
            gbDetails.Visible = true;
            btnAnnuler.Visible = false;
            btnEditer.Visible = true;
            gbDetails.Enabled = false;
            btnValider.Visible = false;
            btnNouveau.Visible = true;
        }

        private void AffichageEdition()
        {
            gbRecherche.Visible = false;
            gbDetails.Enabled = true;
            adherentIDTextBox.ReadOnly = true;
            btnAnnuler.Visible = true;
            btnEditer.Visible = false;
            btnValider.Visible = true;
            btnNouveau.Visible = false;
        }

        private void AffichageNew()
        {
            gbRecherche.Visible = false;
            gbDetails.Visible = true;
            gbDetails.Enabled = true;
            adherentIDTextBox.ReadOnly = false;
            btnAnnuler.Visible = true;
            btnEditer.Visible = false;
            btnValider.Visible = true;
            btnNouveau.Visible = false;
        }

        private void GererContextes(Context contexte)
        {
            currentContext = contexte;
            switch (contexte)
            {
                case Context.Initial:
                    AffichageInitial();
                    break;
                case Context.Show:
                    AffichageShow();
                    break;
                case Context.Edition:
                    AffichageEdition();
                    break;
                case Context.New:
                    AffichageNew();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}

