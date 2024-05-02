using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class Sales_Report : Form
    {

        function fn = new function();
        string query;

        public Sales_Report()
        {
            InitializeComponent();
        }

        private void Sales_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet1.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.pMSDataSet1.sales);

            query = "select * from sales";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
