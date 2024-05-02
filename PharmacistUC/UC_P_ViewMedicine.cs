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
    public partial class UC_P_ViewMedicine : UserControl
    {

        function fn = new function();
        String query;

        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGV(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%'";
            setDataGV(query);
        }

        private void setDataGV(String query)
        {
            DataSet d = fn.getdata(query);
            gunaDataGridView1.DataSource = d.Tables[0];
        }

        String medicineID;

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineID = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Are you Sure..?", "Delete Confirmation..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from medic where mid = '" + medicineID + "'";
                fn.setData(query , "Medicine Record Deleted..");
                UC_P_ViewMedicine_Load(this, null);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicine_Load (this,null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
