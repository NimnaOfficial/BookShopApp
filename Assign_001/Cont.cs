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
    public partial class Cont : Form
    {
        public Cont()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var WEB = new WEB();
            WEB.Closed += (s, args) => this.Close();
            WEB.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Bok_menu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Cont_Load(object sender, EventArgs e)
        {

        }
    }
}
