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
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "UPDATE oreader_tbl SET Name=@Name,Password=@Password,Age=@Age,Address=@Address,Phone_Email=@Phone_Email,Gender=@Gender WHERE UserID=@UserID";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@UserID", this.txtID.Text);
            com.Parameters.AddWithValue("@Name", this.txtName.Text);
            com.Parameters.AddWithValue("@Password", this.txtPass.Text);
            com.Parameters.AddWithValue("@Age", this.txtAge.Text);
            com.Parameters.AddWithValue("@Address", this.txtAdd.Text);
            com.Parameters.AddWithValue("@Phone_Email", this.txtPhone.Text);
            com.Parameters.AddWithValue("@Gender", this.combGender.SelectedItem);


            int ret = com.ExecuteNonQuery();


            MessageBox.Show("Your Details are Updated Successfully !!! " + ret, "Information");



            con.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Bok_menu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
