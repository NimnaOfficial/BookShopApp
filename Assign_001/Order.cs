using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Assign_001
{
    public partial class Order : Form
    {
        string cs = @"Data Source =SANDANIMNE; Initial Catalog =cart_db; Integrated Security =True ";

        public Order()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Bok_menu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void BTcomform_Click(object sender, EventArgs e)
        {
            {
                string cs1 = @"Data Source =SANDANIMNE; Initial Catalog =Bill_db; Integrated Security =True ";
                SqlConnection con = new SqlConnection(cs);
                SqlConnection con1 = new SqlConnection(cs1);
                con.Open();
                con1.Open();

                //commnd
                string sql = "SELECT Total FROM tbl_cart WHERE CartNo = @CartNo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CartNo", this.txtid.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    //bind data with controls
                    this.txttot.Text = dr.GetValue(0).ToString();
                    int deliveryCharge = 200;
                    decimal currentTotal;

                    if (decimal.TryParse(this.txttot.Text, out currentTotal))
                    {
                        decimal newTotal = currentTotal + deliveryCharge;
                        this.txttot.Text = newTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid total amount format.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Detail..!");
                }
                

                //commnd
                string sql1 = "INSERT INTO tbl_Bill( Cname,Addrss,Phone,Date,Total,Pay) VALUES(@Cname,@Addrss,@Phone,@Date,@Total,@Pay)";
                SqlCommand cmd1 = new SqlCommand(sql1, con1);
                cmd1.Parameters.AddWithValue("@Cname", this.txtcust.Text);
                cmd1.Parameters.AddWithValue("@Addrss", this.txtadd.Text);
                cmd1.Parameters.AddWithValue("@Phone", this.txtphone.Text);
                cmd1.Parameters.AddWithValue("@Date", this.dateSel.Value);
                cmd1.Parameters.AddWithValue("@Total", Convert.ToDecimal(txttot.Text.Trim()));
                cmd1.Parameters.AddWithValue("@Pay", comboBox1.Text.Trim());

                if (this.CBagree.Checked == false)
                {
                    MessageBox.Show("Please agree to the terms and conditions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int ret = cmd1.ExecuteNonQuery();
                    MessageBox.Show("Order has made", "SuccessFully..!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    string sqlBillNo = "SELECT TOP 1 BillNo FROM tbl_Bill ORDER BY BillNo DESC";
                    using (SqlCommand cmdBillNo = new SqlCommand(sqlBillNo, con1))
                    {
                        object billNoObj = cmdBillNo.ExecuteScalar();
                        int billNo = Convert.ToInt32(billNoObj);
                        MessageBox.Show("Bill added successfully! Bill No: " + billNo, "Information");
                    }

                }

                con.Close();
                con1.Close();

                this.Hide();
                var Bill = new Bill();
                Bill.Closed += (s, args) => this.Close();
                Bill.Show();

            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ViwCart = new ViwCart();
            ViwCart.Closed += (s, args) => this.Close();
            ViwCart.Show();
        }
    }
}
