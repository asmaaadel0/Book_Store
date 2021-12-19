using System;
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
<<<<<<< HEAD
            //Application.Run(new home());
            Application.Run(new Form1());
=======
            Application.Run(new home());
            //Application.Run(new BuyForm());
>>>>>>> e5fa2134af13ecce6a8943c38f5e8533881585cb
        }
    }
}
