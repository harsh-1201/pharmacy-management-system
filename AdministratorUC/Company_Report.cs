using System;
using System.Collections;
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
    public partial class Company_Report : Form
    {

        function fn = new function();
        string query;

        public Company_Report()
        {
            InitializeComponent();
        }

        private void Company_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMSDataSet4.company' table. You can move, or remove it, as needed.
            this.companyTableAdapter1.Fill(this.pMSDataSet4.company);
            

            query = "select * from company";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
