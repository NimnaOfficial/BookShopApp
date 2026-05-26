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
    public partial class frmDeleteAndUpdateAdmin : Form
    {
        public frmDeleteAndUpdateAdmin()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
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
            MessageBox.Show("Your Details are Updated Successfully !!!: " + ret, "Information");


            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmDeleteAndUpdateAdmin_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM oreader_tbl";
            SqlCommand com = new SqlCommand(sql, con);


            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            string sql = "SELECT * FROM oreader_tbl WHERE UserID=@UserID";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@UserID", this.txtSK.Text);


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
    }
}
