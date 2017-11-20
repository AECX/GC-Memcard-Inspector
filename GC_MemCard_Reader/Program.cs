using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_MemCard_Reader
{
    static class Program
    {
        public static mainForm form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new mainForm();
            Application.Run(form);
        }
    }
}
