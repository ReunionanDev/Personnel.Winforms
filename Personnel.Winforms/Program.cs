using Personnel.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel.Winforms
{
    
    static class Program
    {
        static public HashSet<Employee> Adherents;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeData();
            Application.Run(new FrmAdherent());
        }

        private static void InitializeData()
        {
            Adherents = new HashSet<Employee>()
            {
                new Employee(){
                   AdherentID = "96GBA11",
                   LastName="Bost",
                   FirstName = "Vincent",
                   BirthDate = new DateTime(1988,08,30)
                },
                 new Employee(){
                   AdherentID = "00GTO15",
                   LastName="Pouligane",
                   FirstName = "Arnaud"
                },
                new Employee()
                {
                   AdherentID = "98ACE15",
                   LastName ="Morillon",
                   FirstName = "Jean"
                }
            };
        }
    }
}
