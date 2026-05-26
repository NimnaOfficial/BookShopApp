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
    public partial class Viw_ords : Form
    {
        public Viw_ords()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cs = @"Data Source=SANDANIMNE;
                        Initial Catalog=nimna_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "SELECT * FROM nimna_tbl";
            SqlCommand com = new SqlCommand(sql, con);


            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
