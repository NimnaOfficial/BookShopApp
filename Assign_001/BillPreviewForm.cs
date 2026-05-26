using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign_001
{
    public partial class BillPreviewForm : Form
    {
        public BillPreviewForm(DataSet ds)
        {
            InitializeComponent();

            BillReport1 rpt1 = new BillReport1();
            rpt1.Load(@"C:\Users\SANDANIMNE\Desktop\pastpaps\gui_CW\COCSE244F-021_[ Final Assignment GUi ]\VS_Code\Assign_001\BillReport1.rpt");
            rpt1.SetDataSource(ds.Tables[0]);

            crystalReportViewer1.ReportSource = rpt1;
        }

        public BillPreviewForm()
        {
            InitializeComponent();
        }

        private void BillPreviewForm_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
