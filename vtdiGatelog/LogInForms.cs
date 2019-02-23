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
    public partial class LogInForms : Form
    {
        public LogInForms()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LogInForms_Load(object sender, EventArgs e)
        {
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Code Is In The Right Class
            var username = btUsername.Text;
            var password = btPassword.Text;

            //Declaring an object of the database midel *CONTEXTS is the database
            var contexts = new VTDI_gate_log_dbEntities();
            // "q => q stands for LAMBDA token could represent as something else"
            var userAny = contexts.Users.Any(q => q.Username == username && q.Password == password);


            if (username != "admin" || password != "pass")
            //if (user)
            {
                MessageBox.Show($"welcome {username}");
            }
            else
            {
                MessageBox.Show("Invalid Credential");
            }
        }

    }
}
