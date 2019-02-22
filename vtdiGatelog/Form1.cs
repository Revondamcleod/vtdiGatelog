using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdiGatelog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Botton Selected");
        }

        private void gateLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Log Botton Selected");
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports Botton Selected");
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowLogInForm();

            LogInForms logIn = new LogInForms();
            logIn.MdiParent = this;
            logIn.Show();

        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (this.isLoggedIn)


            GateInOut log = new GateInOut();
            //log.MdiParent = this;
            //log.Show();
            //}
            //else{


            //}
        }
    }
}
