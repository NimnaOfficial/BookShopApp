using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_001
{
    public partial class Open : Form
    {
        public Open()
        {
            InitializeComponent();
        }

        private void BTrall_Click(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Admin_log a1 = new Admin_log();
            a1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Cont_open c1 = new Cont_open();
            c1.Show();
        }

        private void Open_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _1Form4 f4 = new _1Form4();
            f4.Show();
        }
    }
}
