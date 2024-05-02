using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {

        function fn = new function();
        string query;

        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMedName.Text != "")
            {
                query = "select * from medic where mname = '" + txtMedName.Text + "'";
                DataSet ds = fn.getdata(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedID.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtMedNo.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Value =Convert.ToDateTime(ds.Tables[0].Rows[0][4]);
                    txtEDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][5]);
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with Name : " + txtMedName.Text + " Exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            txtMedName.Clear();
            txtMedID.Clear();
            txtMedNo.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
            txtAddQuantity.Clear();

            if (txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        Int64 totalQuantity;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMedName.Text;
            String mnumber = txtMedNo.Text;
            String mdate = txtMDate.Text;
            String edate = txtEDate.Text;
            Int64 Aquantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 priceunit = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = Aquantity + addQuantity;

            query = "update medic set mname = '" + mname + "' , mnumber = '" + mnumber + "' , mDate =  '" + mdate + "' , eDate = '" + edate + "' , quantity = " + totalQuantity + " , perUnit = " + priceunit + " where mname = '" + txtMedName.Text + "'";
            fn.setData(query, "Medicines Details Updated..");
        }
    }
}
