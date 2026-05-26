using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assign_001
{
    public partial class Admin_log : Form
    {
        public Admin_log()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form1 = new Open();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BTlog_Click(object sender, EventArgs e)
        {
            string UserID = "admin";
            string Passcode = "admin";

            string inputUserid = txtUser.Text;
            string inputPasscode = txtPass.Text;

            if (inputUserid == UserID && inputPasscode == Passcode)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var system = new Admin_menu();
                system.Closed += (s, args) => this.Close();
                system.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void Admin_log_Load(object sender, EventArgs e)
        {

        }
    }
}
