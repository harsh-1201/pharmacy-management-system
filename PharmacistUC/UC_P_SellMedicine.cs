using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {

        function fn = new function();
        String query;
        DataSet ds;      

        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
           
            ListBoxMedicines.Items.Clear();

            query = "select mname from medic where eDate >= getdate() and quantity > '0'";
            ds = fn.getdata(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            ListBoxMedicines.Items.Clear();
            query = "select mname from medic where mname like '"+txtSearchBox.Text+"%' and eDate >=  getdate() and quantity > '0'";
            ds = fn.getdata(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ListBoxMedicines.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void ListBoxMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnits.Clear();

            String name = ListBoxMedicines.GetItemText(ListBoxMedicines.SelectedItem);

            txtMediName.Text = name;
            query = "select mid , eDate , perUnit from medic where mname = '"+name+"'";
            ds = fn.getdata(query);
            txtMediID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpDate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0][1].ToString());
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noofUnits = Int64.Parse(txtUnits.Text);
                Int64 totalAmount = unitPrice * noofUnits;
                txtTotalPrice.Text = totalAmount.ToString();    
            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n , totalAmount = 0 ;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "")
            {
                query = "select quantity from medic where mid = '"+txtMediID.Text+"'";
                ds = fn.getdata(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtUnits.Text);

                if (newQuantity >= 0)
                {
                    n = gunaDataGridView1.Rows.Add();
                    gunaDataGridView1.Rows[n].Cells[0].Value = txtMediID.Text;
                    gunaDataGridView1.Rows[n].Cells[1].Value = txtMediName.Text;
                    gunaDataGridView1.Rows[n].Cells[2].Value = txtExpDate.Text;
                    gunaDataGridView1.Rows[n].Cells[3].Value = txtPricePerUnit.Text;
                    gunaDataGridView1.Rows[n].Cells[4].Value = txtUnits.Text;
                    gunaDataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                    TotalLabel.Text = "Rs. " + totalAmount.ToString();

                    query = "update medic set quantity = '"+newQuantity+"' where mid = '"+txtMediID.Text+"'";
                    fn.setData(query , "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock. \nOnly "+quantity+" left." , "Warning !!" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load (this , null);
            }
            else
            {
                MessageBox.Show("Select Medicine First." , "Information !!" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        int valueAmount;
        String ValueID;
        protected Int64 noofUnits;

       

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                ValueID = gunaDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noofUnits = Int64.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            { 

            }
        }

        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ValueID != "")
            {
                try
                {
                    gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
                }
                catch ( Exception)
                {

                }
                finally
                {
                    query = "select quantity from medic where mid = '"+ValueID+"'";
                    ds = fn.getdata(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noofUnits;

                    query = "update medic set quantity = '"+newQuantity+"' where mid = '"+ValueID+"'";
                    fn.setData(query , "Medicine Removed from Cart");
                    totalAmount = totalAmount - valueAmount;
                    TotalLabel.Text = "Rs. " + totalAmount.ToString();
                }
                UC_P_SellMedicine_Load (this, null);
            }
            //else
            //{
            //    MessageBox.Show("Cart is Empty...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            

            //if (gunaDataGridView1 != null)
            //{
            DateTime dt = DateTime.Now;
                DGVPrinter print = new DGVPrinter();
                print.Title = "Medicine Bill";
                //print.SubTitle = String.Format("Date :- {0}", DateTime.Now.Date);
                print.SubTitle = dt.ToString("dd/MM/yyyy hh:mm:ss");
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Total Payable Amount : " + TotalLabel.Text + "";
                print.FooterSpacing = 15;
                print.PrintDataGridView(gunaDataGridView1);

                totalAmount = 0;
                TotalLabel.Text = "Rs. 00";
                gunaDataGridView1.DataSource = 0;
            
           
        }

        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtExpDate.ResetText();
            txtPricePerUnit.Clear();
            txtUnits.Clear();
        }
    }
}
