using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            // get directory

            
            // Read the file as one string. 
            
            Application.Run(new login());

        }
    }
}
