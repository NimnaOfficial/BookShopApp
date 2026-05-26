using CrystalDecisions.CrystalReports.Engine;
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
    public partial class repoOrds : Form
    {
        public repoOrds()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Connection
            string cs = @"Data Source=SANDANIMNE; Initial Catalog=products_db; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Command
            string sql = "SELECT * FROM product_tbl";
            SqlCommand com = new SqlCommand(sql, con);


            //Access data using Data Adaptor
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //disconnect
            con.Close();

            //Bind data with Crystal Report
            CrystalReport1 rpt4 = new CrystalReport1();
            rpt4.Load(@"C:\Users\SANDANIMNE\Desktop\pastpaps\gui_CW\COCSE244F-021_[ Final Assignment GUi ]\VS_Code\Assign_001\CrystalReport1.rpt");
            rpt4.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer1.ReportSource = rpt4;

        }
    
        

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void repoOrds_Load(object sender, EventArgs e)
        {
           
        }
    }
}
