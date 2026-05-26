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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            string sql = "SELECT * FROM oreader_tbl WHERE UserID=@sk";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@sk", this.txtSK.Text);


            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                this.txtID.Text = dr.GetValue(0).ToString();
                this.txtName.Text = dr.GetValue(1).ToString();
                this.txtPass.Text = dr.GetValue(2).ToString();
                this.txtAge.Text = dr.GetValue(3).ToString();
                this.txtAdd.Text = dr.GetValue(4).ToString();
                this.txtPhone.Text = dr.GetValue(5).ToString();
                this.combGender.SelectedItem = dr.GetValue(6).ToString();


            }
            else
            {
                MessageBox.Show("!!!!!No records found!!!!!!", "Error");
            }


            conn.Close();
        }

        private void BTregis_Click(object sender, EventArgs e)
        {
            
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "DELETE FROM oreader_tbl WHERE UserID=@UserID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@UserID", this.txtID.Text);


            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Your Details are Deleted !!!: " + ret, "Information");



            con.Close();

            this.Hide();
            var form1 = new Open();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Bok_menu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
