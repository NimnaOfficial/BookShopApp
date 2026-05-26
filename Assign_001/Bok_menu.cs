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
    public partial class Bok_menu : Form
    {
        public Bok_menu()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Mys = new Mys();
            Mys.Closed += (s, args) => this.Close();
            Mys.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var _1Form4 = new _1Form4();
            _1Form4.Closed += (s, args) => this.Close();
            _1Form4.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form5 = new Cont();
            form5.Closed += (s, args) => this.Close();
            form5.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Open();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void orderBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmDeleteUser = new frmDeleteUser();
            frmDeleteUser.Closed += (s, args) => this.Close();
            frmDeleteUser.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmUpdateUser = new frmUpdateUser();
            frmUpdateUser.Closed += (s, args) => this.Close();
            frmUpdateUser.Show();
        }

        private void BTfant_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Fan = new Fan();
            Fan.Closed += (s, args) => this.Close();
            Fan.Show();
        }

        private void BThorr_Click(object sender, EventArgs e)
        {
            
        }

        private void BTadven_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Adv= new Adv();
            Adv.Closed += (s, args) => this.Close();
            Adv.Show();
        }

        private void Btnov_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Nov = new Nov();
            Nov.Closed += (s, args) => this.Close();
            Nov.Show();
        }

        private void BTroma_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Rom = new Rom();
            Rom.Closed += (s, args) => this.Close();
            Rom.Show();
        }

        private void announcmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Open();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form9 = new Order();
            form9.Closed += (s, args) => this.Close();
            form9.Show();
        }

        private void BTthorrr_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Hor = new Hor();
            Hor.Closed += (s, args) => this.Close();
            Hor.Show();
        }
    }
}
