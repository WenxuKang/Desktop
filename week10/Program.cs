using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019
{
    public static class Program
    {

        public static Dictionary<FormName, Form> Forms;
    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create an instance of the forms Dictionary
            Forms = new Dictionary<FormName,Form>();
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM, new MainForm());



            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}
