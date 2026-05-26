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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create connection with mssql
            string cs = @"Data Source =SANDANIMNE; Initial Catalog =bill_db; Integrated Security =True ";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //commnd
            string sql = "SELECT * FROM tbl_bill WHERE BillNo = @BillNo";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@BillNo", this.txtbil.Text);

            //access data using data reader
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            BillPreviewForm preview = new BillPreviewForm(ds);
            this.Hide();
            preview.FormClosed += (s, args) =>
            {
                // after user closes preview → success msg + Thnx
                MessageBox.Show("Bill Generated Successfully..!!", "Information");
                this.Hide();
                Thnx thankYouForm = new Thnx();
                thankYouForm.Closed += (s2, a2) => this.Close();
                thankYouForm.Show();
            };
            preview.Show();

            //disconnect sql connection
            con.Close();

            

            
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
