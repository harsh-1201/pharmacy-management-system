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
    public partial class Staff_Report : Form
    {

        function fn = new function();
        string query;

        public Staff_Report()
        {
            InitializeComponent();
        }

        private void Staff_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pharmacyDataSet.users);
            query = "select * from users";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
