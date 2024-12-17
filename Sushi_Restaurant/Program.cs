
﻿using Sushi_Restaurant.Chi_Nhanh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Restaurant
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new addStaff());
            //Application.Run(new Brand());
            //Application.Run(new Login());
            //Application.Run(new viewEnvoice());
            //Application.Run(new viewIDCard());
            //Application.Run(new Brand("CN001"));
            Application.Run(new BranchRevenue("CN001"));
        }
    }
}
