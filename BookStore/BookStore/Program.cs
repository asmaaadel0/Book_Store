﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ADMINS());
            //Application.Run(new BuyForm());
            //Application.Run(new Form1("asmaa333"));
            //Application.Run(new Form1("salma"));
            Application.Run(new home());
        }
    }
}
