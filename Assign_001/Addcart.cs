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
    public partial class Addcart : Form
    {
        public Addcart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //create connection with mssql
            string cs = @"Data Source =SANDANIMNE; Initial Catalog =products_db; Integrated Security =True ";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //commnd
            string sql = "SELECT * FROM product_tbl WHERE BookID = @BookID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", this.txtsh.Text);

            //access data using data reader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                //bind data with controls
                this.txtBid.Text = dr.GetValue(0).ToString();
                this.txtBname.Text = dr.GetValue(1).ToString();
                this.txtPric.Text = dr.GetValue(5).ToString();

            }
            else
            {
                MessageBox.Show("Invalid SID..!");
            }


            //disconnect sql connection
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {

            //create connection with mssql
            string cs = @"Data Source =SANDANIMNE; Initial Catalog =cart_db; Integrated Security =True ";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            

            //commnd
            string sql = "INSERT INTO tbl_cart(BookID,Uname,Bname,Qty,Price,Total) VALUES(@BookID,@Uname,@Bname,@Qty,@Price,@Total)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BookID", this.txtBid.Text);
            cmd.Parameters.AddWithValue("@Uname", this.txtuser.Text);
            cmd.Parameters.AddWithValue("@Bname", this.txtBname.Text);
            cmd.Parameters.AddWithValue("@Qty", (int)qty.Value);

            int qtyv = Convert.ToInt32(this.qty.Value);
            decimal price = 0;
            decimal.TryParse(this.txtPric.Text, out price);



            decimal total = qtyv * price;
            cmd.Parameters.AddWithValue("@Total", total);
            cmd.Parameters.AddWithValue("@Price", price);

            //execute command
            if (this.txtBid.Text == "")
            {
                MessageBox.Show("Please Select Book ID..!!", "Error");
                return;
            }
            else
            {
                this.toolStripProgressBar1.Value = 99;

                int ret = cmd.ExecuteNonQuery();
                MessageBox.Show("Added to cart..!!" + ret, "Information");
            }
            

            //disconnect sql connection
            con.Close();

            this.toolStripProgressBar1.Value = 99;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void Addcart_Load(object sender, EventArgs e)
        {

        }
    }
}
