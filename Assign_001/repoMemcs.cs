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
    public partial class repoMemcs : Form
    {
        public repoMemcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            //Connection
            string cs = @"Data Source=SANDANIMNE; Initial Catalog=oreader_db; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Command
            string sql = "SELECT * FROM oreader_tbl";
            SqlCommand com = new SqlCommand(sql, con);


            //Access data using Data Adaptor
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //disconnect
            con.Close();

            //Bind data with Crystal Report
            CrystalReport2 rpt5 = new CrystalReport2();
            rpt5.Load(@"C:\Users\SANDANIMNE\Desktop\pastpaps\gui_CW\COCSE244F-021_[ Final Assignment GUi ]\VS_Code\Assign_001\CrystalReport2.rpt");
            rpt5.SetDataSource(ds.Tables[0]);

            this.crystalReportViewer1.ReportSource = rpt5;


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void repoMemcs_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
