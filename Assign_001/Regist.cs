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
    public partial class _1Form4 : Form
    {
        public _1Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void _1Form4_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "";
            this.toolStripProgressBar1.Value = 29;
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void combGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Login = new _1Logincs();
            Login.Closed += (s, args) => this.Close();
            Login.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Form1 = new Open();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void BTregis_Click(object sender, EventArgs e)
        {

            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=oreader_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            string query = "INSERT INTO oreader_tbl(Name, Password, Age, Address, Phone_Email, Gender) VALUES (@Name, @Password, @Age, @Address, @Phone_Email, @Gender)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Address", txtAdd.Text);
                cmd.Parameters.AddWithValue("@Phone_Email", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Gender", combGender.SelectedItem);
                if (this.RBagree.Checked == false)
                {
                    MessageBox.Show("!!!!Please Accept Our Policy and Perfernces!!!!!");
                }
                else
                {
                    cmd.ExecuteNonQuery();

                    this.toolStripStatusLabel1.Text = "✔️";
                    this.toolStripProgressBar1.Value = 99;

                    string sqlUserID = "SELECT TOP 1 UserID FROM oreader_tbl ORDER BY UserID DESC";
                    using (SqlCommand cmdUserID = new SqlCommand(sqlUserID, conn))
                    {
                        object UserIDObj = cmdUserID.ExecuteScalar();
                        int UserID = Convert.ToInt32(UserIDObj);
                        MessageBox.Show("Your Registration Successful!, Your UserID is:" + UserID, "Information");
                    }

                    
                    conn.Close();

                    this.Hide();
                    Bok_menu b1 = new Bok_menu();
                    b1.Show();

                }
                

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
