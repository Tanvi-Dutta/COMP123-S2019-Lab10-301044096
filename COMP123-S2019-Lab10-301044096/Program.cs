using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301044096
{
    public static class Program
    {
        public static Dictionary<Forms_Name, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //creating an instance of the forms dictionary
            Forms = new Dictionary<Forms_Name, Form>();
            Forms.Add(Forms_Name.mainForm, new MainForm());
            Forms.Add(Forms_Name.startForm, new StartForm());
            Forms.Add(Forms_Name.endForm, new EndForm());

            Application.Run(new StartForm());
        }
    }
}
