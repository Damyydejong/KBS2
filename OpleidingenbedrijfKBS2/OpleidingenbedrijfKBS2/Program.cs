using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpleidingenbedrijfKBS2
{
    static class Program
    {
        static Startscherm st; 


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            st = new Startscherm();
            Application.Run(st);
        }
    }
}
