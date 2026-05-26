using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_001
{
    public partial class _1Logincs : Form
    {
        public _1Logincs()
        {
            InitializeComponent();
        }

        private void _1Logincs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            
            string sql = "SELECT * FROM oreader_tbl WHERE Name=@un AND Password=@pw";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@un", this.txtUN.Text);
            com.Parameters.AddWithValue("@pw", this.txtPW.Text);

            
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                MessageBox.Show("Congatulations Sir!!, " +
                       "Your Log in was Successful!","information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);               
                this.Hide();
                var form3 = new Bok_menu();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var _1Form4 = new _1Form4();
            _1Form4.Closed += (s, args) => this.Close();
            _1Form4.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form1 = new Open();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void txtUN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
