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
    public partial class Dealer_Report : Form
    {

        function fn = new function();
        string query;

        public Dealer_Report()
        {
            InitializeComponent();
        }

        private void Dealer_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet2.dealer' table. You can move, or remove it, as needed.
            this.dealerTableAdapter.Fill(this.pMSDataSet2.dealer);

            query = "select * from dealer";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
