using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_ExpiryChecking : UserControl
    {

        function fn = new function();
        String query;

        public UC_P_ExpiryChecking()
        {
            InitializeComponent();
        }

        

        private void UC_P_ExpiryChecking_Load_1(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select *  from medic where edate >= getdate()";
                DataSet ds = fn.getdata(query);
                gunaDataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Valid Medicines";
                setLabel.ForeColor = Color.Black;
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select *  from medic where edate <= getdate()";
                DataSet ds = fn.getdata(query);
                gunaDataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "Expired Medicines";
                setLabel.ForeColor = Color.Red;
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select *  from medic";
                DataSet ds = fn.getdata(query);
                gunaDataGridView1.DataSource = ds.Tables[0];
                setLabel.Text = "";
                setLabel.ForeColor = Color.Black;
            }
        }
    }
}
