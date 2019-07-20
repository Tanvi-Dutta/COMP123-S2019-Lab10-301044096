using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301044096
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //used to hide main form and show end form
            Program.Forms[Forms_Name.endForm].Show();
            this.Hide();
        }
        /// <summary>
        /// Event to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

    }
}
