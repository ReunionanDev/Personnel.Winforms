using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel.BOL;
using Personnel.DAL;
using System.Data.Entity;

namespace Personnel.Winforms
{
    public partial class FrmAdherent : Form
    {
        enum Contexte
        {
            Initial,
            Affichage,
            Edition,
            Nouveau
        }

        private Contexte contexteActuel;

        PersonnelDBContext dbcontext = new PersonnelDBContext();
        PersonnelRepository repository;
        Employee employee = new Employee();

        public FrmAdherent()
        {
            InitializeComponent();
            GererContextes(Contexte.Initial);
          //  adherentBindingSource.DataSource = Program.Adherents;
        }

        private void GererContextes(Contexte contexte)
        {
            contexteActuel = contexte;
            switch (contexte)
            {
                case Contexte.Initial:
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
                    break;
                case Contexte.Affichage:
                    gbRecherche.Visible = true;
                    gbDetails.Visible = true;
                    btnAnnuler.Visible = false;
                    btnEditer.Visible = true;
                    gbDetails.Enabled = false;
                    btnValider.Visible = false;
                    btnNouveau.Visible = true;
                    break;
                case Contexte.Edition:
                    gbRecherche.Visible = false;
                    gbDetails.Enabled = true;
                    adherentIDTextBox.ReadOnly = true;
                    btnAnnuler.Visible = true;
                    btnEditer.Visible = false;
                    btnValider.Visible = true;
                    btnNouveau.Visible = false;
                    break;
                case Contexte.Nouveau:
                    gbRecherche.Visible = false;
                    gbDetails.Visible = true;
                    gbDetails.Enabled = true;
                    adherentIDTextBox.ReadOnly = false;
                    btnAnnuler.Visible = true;
                    btnEditer.Visible = false;
                    btnValider.Visible = true;
                    btnNouveau.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            RechercherAdherent();
        }

        private Employee SelectionnerAdherentByID(string employeeID)
        {
            repository = new PersonnelRepository();
            return repository.GetEmployees().Where(a=>a.EmployeeID==employeeID).FirstOrDefault();
        }

        private Employee SelectionnerAdherent(string debNom)
        {

            FrmRecAdherent dialog = new FrmRecAdherent(debNom, adherentBindingSource);
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                return adherentBindingSource.Current as Employee;
            }
            else
            {
                return null;
            }

        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            GererContextes(Contexte.Edition);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Vérifier la validité 
            if ((adherentBindingSource.Current as Employee).IsValid)
            {
                if (contexteActuel == Contexte.Nouveau)
                {
                    // Create
                }
                if (contexteActuel == Contexte.Edition)
                {
                    // Update
                    employee = adherentBindingSource.Current as Employee;
                    dbcontext.Entry(employee).State = EntityState.Modified;
                    dbcontext.SaveChanges();
                }
                GererContextes(Contexte.Initial);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            adherentBindingSource.CancelEdit();
            GererContextes(Contexte.Initial);
        }

        private void RechercherAdherent()
        {
            adherentBindingSource.Clear();
            Employee adherent = null;
            if (!string.IsNullOrEmpty(txtAdherentID.Text))
            {
                adherent = SelectionnerAdherentByID(txtAdherentID.Text);
                if (adherent == null)
                {
                    AdherentEP.SetError(txtAdherentID, "Identifiant inconnu");
                }
            }
            else
            {
                adherent = SelectionnerAdherent(txtDebNom.Text);
            }
            if (adherent != null)
            {
                adherentBindingSource.DataSource = adherent;
                GererContextes(Contexte.Affichage);
            }
        }

        private void txtAdherentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RechercherAdherent();
            }
        }

        private void txtDebNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RechercherAdherent();
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            GererContextes(Contexte.Nouveau);
            adherentBindingSource.AddNew();
            AdherentEP.Clear();
        }

        private void FrmAdherent_Load(object sender, EventArgs e)
        {
            repository = new PersonnelRepository();
            List<Employee> list = repository.GetEmployees();
            adherentBindingSource.DataSource = list;
        }
    }
}

