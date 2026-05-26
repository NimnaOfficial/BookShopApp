using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assign_001
{
    public partial class ViwCart : Form
    {
        
       
        private string cs = @"Data Source=SANDANIMNE; Initial Catalog=cart_db; Integrated Security=True";

        public ViwCart()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {


          
        }

        // Save Button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            

           

        }

        private void ViwCart_Load(object sender, EventArgs e)
        {
            this.toolStripProgressBar1.Value = 33;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updt_Click(object sender, EventArgs e)
        {
            // create connection with mssql
            string cs = @"Data Source =SANDANIMNE; Initial Catalog =cart_db; Integrated Security =True ";
            SqlConnection con = new SqlConnection(cs);
            con.Open();



            //commnd
            string sql = "UPDATE tbl_cart SET Uname =@Uname, Qty =@Qty, Total =@Total WHERE Uname =@Uname";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Uname",this.txtuser.Text);
            cmd.Parameters.AddWithValue("@Qty", (int)qty.Value);

            int qtyv = Convert.ToInt32(this.qty.Value);
            decimal price = 0;
            decimal.TryParse(this.txtPric.Text, out price);



            decimal total = qtyv * price;
            cmd.Parameters.AddWithValue("@Total", total);


            //execute command



            int ret = cmd.ExecuteNonQuery();
            MessageBox.Show(" Cart Update Successfull..!!" + ret, "Information");



            //disconnect sql connection
            con.Close();

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create connection with mssql
            string cs = @"Data Source =SANDANIMNE; Initial Catalog =cart_db; Integrated Security =True ";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //commnd
            string sql = "SELECT * FROM tbl_cart WHERE Uname = @Uname";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Uname", this.txtus.Text);

            //access data using data reader
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                //bind data with controls
                this.txtcart.Text = dr.GetValue(0).ToString();
                this.txtBid.Text = dr.GetValue(1).ToString();
                this.txtuser.Text = dr.GetValue(2).ToString();
                this.txtBname.Text = dr.GetValue(3).ToString();
                this.qty.Text = dr.GetValue(4).ToString();
                this.txtPric.Text = dr.GetValue(5).ToString();
                this.txtto.Text = dr.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("Invalid SID..!");
            }


            //disconnect sql connection
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=cart_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


            string sql = "DELETE FROM tbl_cart WHERE CartNo =@CartNo";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@CartNo", this.txtcart.Text);


            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Your Details are Deleted !!!: " + "Information");
        }
    }
}
