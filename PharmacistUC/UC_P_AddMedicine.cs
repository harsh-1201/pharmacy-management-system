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
    public partial class UC_P_AddMedicine : UserControl
    {

        function fn = new function();
        String query;

        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text != "" && txtMedicineName.Text != "" && txtMedicineNo.Text != "" && txtQuantity.Text != "" && txtPerUnit.Text != "") 
            {
                String mid = txtMedicineID.Text;
                String mname = txtMedicineName.Text;
                String mnumber = txtMedicineNo.Text;
                String mdate = txtMFGDate.Text;
                String edate = txtExpDate.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 perunit = Int64.Parse(txtPerUnit.Text);

                query = "insert into medic (mid , mname , mnumber , mDate , eDate , quantity , perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdate + "','" + edate + "'," + quantity + "," + perunit + ")";
                fn.setData(query, "Medicine Added to Database");

            }
            else
            {
                MessageBox.Show("Enter all Data" , "Information" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNo.Clear();
            txtQuantity.Clear();
            txtPerUnit.Clear();
            txtMFGDate.ResetText();
            txtExpDate.ResetText();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
