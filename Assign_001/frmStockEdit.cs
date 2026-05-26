using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Assign_001
{
    public partial class frmStockEdit : Form
    {
        public frmStockEdit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=products_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            string sql = "SELECT * FROM product_tbl WHERE BookID=@sk";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@sk", this.txtSK.Text);


            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                this.txtID.Text = dr.GetValue(0).ToString();
                this.txtName.Text = dr.GetValue(1).ToString();
                this.txtwriter.Text = dr.GetValue(2).ToString();
                this.txtcate.Text = dr.GetValue(3).ToString();
                this.txtyear.Text = dr.GetValue(4).ToString();
                this.txtprice.Text = dr.GetValue(5).ToString();
                this.txtable.Text = dr.GetValue(6).ToString();



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
                        Initial Catalog=products_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "DELETE FROM product_tbl WHERE BookID=@BookID";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@BookID", this.txtID.Text);


            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Your Details are Deleted !!!: " + ret, "Information");


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=products_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "UPDATE product_tbl SET BookID=@BookID,Name=@Name,Author=@Author,Category=@Category,ReleasedDate=@ReleasedDate,Price=@Price,Availability=@Availability WHERE BookID=@BookID";
            SqlCommand com = new SqlCommand(sql, con);

            com.Parameters.AddWithValue("@BookID", this.txtID.Text);
            com.Parameters.AddWithValue("@Name", this.txtName.Text);
            com.Parameters.AddWithValue("@Author", this.txtwriter.Text);
            com.Parameters.AddWithValue("@Category", this.txtcate.Text);
            com.Parameters.AddWithValue("@ReleasedDate", this.txtyear.Text);
            com.Parameters.AddWithValue("@Price", this.txtprice.Text);
            com.Parameters.AddWithValue("@Availability", this.txtable.Text);
            


            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Your Details are Updated Successfully !!!: " + ret, "Information");


            con.Close();
        }

        private void BTadd_Click(object sender, EventArgs e)
        {

            
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=products_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            
            string sql = "INSERT INTO product_tbl(BookID,Name,Author,Category,ReleasedDate,Price,Availability) " +
                "               VALUES(@BookID,@Name,@Author,@Category,@ReleasedDate,@Price,@Availability)";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@BookID", this.txtID.Text);
            com.Parameters.AddWithValue("@Name", this.txtName.Text);
            com.Parameters.AddWithValue("@Author", this.txtwriter.Text);
            com.Parameters.AddWithValue("@Category", this.txtcate.Text);
            com.Parameters.AddWithValue("@ReleasedDate", this.txtyear.Text);
            com.Parameters.AddWithValue("@Price", this.txtprice.Text);
            com.Parameters.AddWithValue("@Availability", this.txtable.Text);

            
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("New Book has Added Successfully !!!: " + ret, "Information");

            
            con.Close();



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void frmStockEdit_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=products_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM product_tbl";
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
                        Initial Catalog=products_db;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            string sql = "SELECT * FROM product_tbl WHERE BookID=@sk";
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@sk", this.txtSK.Text);


            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read() == true)
            {
                this.txtID.Text = dr.GetValue(0).ToString();
                this.txtName.Text = dr.GetValue(1).ToString();
                this.txtwriter.Text = dr.GetValue(2).ToString();
                this.txtcate.Text = dr.GetValue(3).ToString();
                this.txtyear.Text = dr.GetValue(4).ToString();
                this.txtprice.Text = dr.GetValue(5).ToString();
                this.txtable.Text = dr.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("!!!!!No records found!!!!!!", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSK.Text = "";
            txtID.Text = "";
            txtwriter.Text = "";
            txtyear.Text = "";
            txtName.Text = "";
            txtcate.Text = "";
            txtprice.Text = "";
            txtID.Text = "";
            txtable.Text = "";

        }
    }
}
