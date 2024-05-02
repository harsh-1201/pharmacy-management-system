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
    public partial class Stock_Replort : Form
    {

        function fn = new function();
        string query;

        public Stock_Replort()
        {
            InitializeComponent();
        }

        private void Stock_Replort_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.medic' table. You can move, or remove it, as needed.
            this.medicTableAdapter.Fill(this.pharmacyDataSet1.medic);
            query = "select * from medic";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
