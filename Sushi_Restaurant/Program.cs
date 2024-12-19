
﻿using Sushi_Restaurant.Chi_Nhanh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sushi_Restaurant.Admin;

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
            // Application.Run(new branch_revenue());
            // Application.Run(new Login());
            //Application.Run(new viewEnvoice("CN1"));
            //Application.Run(new viewIDCard());
            //Application.Run(new Brand("CN1"));
            //Application.Run(new RevenueStatistics()); //chuan roi
            //Application.Run(new Admin_Manage()); // Đây sẽ là lớp Admin
            Application.Run(new company_revenue());
        }
    }
}
