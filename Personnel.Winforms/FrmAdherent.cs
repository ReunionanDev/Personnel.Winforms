﻿using System;
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
        private Contexte contexteActuel;
        PersonnelDBContext dbcontext = new PersonnelDBContext();
        PersonnelRepository repository;
        Employee employee = new Employee();

        public FrmAdherent()
        {
            InitializeComponent();
            GererContextes(Contexte.Initial);
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
                Establishment establishment = dbcontext.Establishments.Find(employee.EstablishmentSiret); // Find the etablishment with the primary key in parameter
                EtablissementTextbox.Text = establishment.Name;
                Role role = dbcontext.Roles.Find(employee.RoleId); // Find the role with the primary key in parameter
                roleTextbox.Text = role.Label;
                return employee;
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
                GererContextes(Contexte.Show);
            }
        }
        #endregion

        #region Controls events
        private void btnEditer_Click(object sender, EventArgs e)
        {
            GererContextes(Contexte.Edition);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            // Check if the employee is valid
            if ((adherentBindingSource.Current as Employee).IsValid)
            {
                if (contexteActuel == Contexte.New)
                {
                    // Create an employee
                    employee.LastName = nomTextBox.Text.Trim();
                    employee.FirstName = prenomTextBox.Text.Trim();
                    employee.BirthDate = Convert.ToDateTime(DateNaissanceTextbox.Text.Trim());
                    employee.GrossSalary = Convert.ToDecimal(salaireTextbox.Text.Trim());
                    employee.EmployeeID = adherentIDTextBox.Text.Trim();
                    if (!String.IsNullOrEmpty(arriveeTextbox.Text.Trim()))
                    {
                        employee.StartDate = Convert.ToDateTime(arriveeTextbox.Text.Trim());
                    }
                    if (!String.IsNullOrEmpty(arriveeTextbox.Text.Trim()))
                    {
                        employee.EndDate = Convert.ToDateTime(departTextbox.Text.Trim());
                    }
                    employee.WorkQuantity = double.Parse(TempsTextbox.Text.Trim());

                    using (PersonnelDBContext context = new PersonnelDBContext())
                    {
                        context.Employees.Add(employee);
                        context.SaveChanges();
                    }
                }
                if (contexteActuel == Contexte.Edition)
                {
                    // Update the employee
                    employee = adherentBindingSource.Current as Employee;
                    dbcontext.Entry(employee).State = EntityState.Modified;
                    dbcontext.SaveChanges();
                }
                GererContextes(Contexte.Initial);
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
            GererContextes(Contexte.Initial);
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
            GererContextes(Contexte.New);
            adherentBindingSource.Clear();
            adherentBindingSource.AddNew();
            AdherentEP.Clear();
        }

        private void FrmAdherent_Load(object sender, EventArgs e)
        {
            PersonnelDBContext dbcontext = new PersonnelDBContext();
            repository = new PersonnelRepository();
            adherentBindingSource.DataSource = repository.GetEmployees();
        }
        #endregion

        #region UI context management
        enum Contexte
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

        private void GererContextes(Contexte contexte)
        {
            contexteActuel = contexte;
            switch (contexte)
            {
                case Contexte.Initial:
                    AffichageInitial();
                    break;
                case Contexte.Show:
                    AffichageShow();
                    break;
                case Contexte.Edition:
                    AffichageEdition();
                    break;
                case Contexte.New:
                    AffichageNew();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}

