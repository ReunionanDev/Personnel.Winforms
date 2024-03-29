﻿using Personnel.BOL;
using Personnel.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel.Winforms
{
    public partial class FrmRecAdherent : Form
    {
        BindingSource adherentBSG;
        PersonnelRepository repository;

        public FrmRecAdherent()
        {
            InitializeComponent();
        }

        public FrmRecAdherent(string debNom, BindingSource adherentBS) : this()
        {
            adherentBSG = adherentBS;
            repository = new PersonnelRepository();
            List<Employee> employees = repository.GetEmployees().Where(a=>a.LastName.StartsWith(debNom,StringComparison.CurrentCultureIgnoreCase)).ToList();

            if (employees.Count > 0)
            {
                adherentBindingSource.DataSource = employees;
            }
        }

        private void SelectionnerAdherent()
        {
            if (adherentBindingSource.Current != null)
            {
                adherentBSG.Add(adherentBindingSource.Current);
            }
            DialogResult = DialogResult.OK;
        }

        private void adherentDataGridView_DoubleClick(object sender, EventArgs e)
        {
            SelectionnerAdherent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectionnerAdherent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmRecAdherent_Load(object sender, EventArgs e)
        {

        }
    }
}