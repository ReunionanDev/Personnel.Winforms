using Personnel.BOL;
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
        public FrmRecAdherent()
        {
            InitializeComponent();
        }
        public FrmRecAdherent(string debNom, BindingSource adherentBS) : this()
        {
            adherentBSG = adherentBS;
            HashSet<Employee> adherents = Program.Adherents.Where(a=>a.LastName.StartsWith(debNom,StringComparison.CurrentCultureIgnoreCase)).ToHashSet();

            if (adherents.Count > 0)
            {
                adherentBindingSource.DataSource = adherents;

            }

        }

        private void adherentDataGridView_DoubleClick(object sender, EventArgs e)
        {
            SelectionnerAdherent();
        }

        private void SelectionnerAdherent()
        {
            if (adherentBindingSource.Current != null)
            {
                adherentBSG.Add(adherentBindingSource.Current);
            }
            DialogResult = DialogResult.OK;

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