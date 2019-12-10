﻿using Personnel.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Personnel.BOL;
using Personnel.DAL;
using System.Data.Entity;

namespace Personnel.Winforms
{
    
    static class Program
    {
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
            
        }
    }
}
