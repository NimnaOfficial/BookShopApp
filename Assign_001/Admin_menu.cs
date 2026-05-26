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
    public partial class Admin_menu : Form
    {
        public Admin_menu()
        {
            InitializeComponent();
        }

        private void backToOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Open();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteAndUpdateAdmin du = new frmDeleteAndUpdateAdmin();
            du.MdiParent = this;
            du.Show();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockEdit se = new frmStockEdit();
            se.MdiParent = this;
            se.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viw_ords f10 = new Viw_ords();
            f10.MdiParent = this;
            f10.Show();
        }

        private void editOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Admin_menu_Load(object sender, EventArgs e)
        {

        }

        private void getMemberReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoMemcs r4 = new repoMemcs();
            r4.MdiParent = this;
            r4.Show();
        }

        private void getStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repoOrds r2 = new repoOrds();
            r2.MdiParent = this;
            r2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
