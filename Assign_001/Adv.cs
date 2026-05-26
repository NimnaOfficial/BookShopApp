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
    public partial class Adv : Form
    {
        public Adv()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Bok_menu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Addcart = new Addcart();
            Addcart.Closed += (s, args) => this.Close();
            Addcart.Show();
        }
    }
}
