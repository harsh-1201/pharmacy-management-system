using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdministratorUC
{
    public partial class Purchase : Form
    {

        function fn = new function();
        string query;

        public Purchase()
        {
            InitializeComponent();
        }

        int total;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string p_name = txtP_name.Text;
            string perUnit = txtperUnit.Text;
            string quantity = txtQuantity.Text;
            string total = txtTotal.Text;
            string dealer = txtDealer.Text;
           

            query = "insert into purchase (p_name ,perUnit , quantity , totalPrice , name_dealer) values ('" + p_name + "','" + perUnit + "','" + quantity + "','" + total + "','" + dealer + "')";
            fn.setData(query, "Record added Successfully.");

            clearAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
           
            clearAll();
            if(txtTotal.Text != "0")
            {
                txtTotal.Text = "0";
            }
            else
            {
                txtTotal.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            Int64 totalPrice = Convert.ToInt64(txtQuantity.Text) * Convert.ToInt64(txtperUnit.Text);
            txtTotal.Text = Convert.ToString(totalPrice);
        }

        private void clearAll()
        {
            txtDealer.Clear();
            txtP_name.Clear();
            txtperUnit.Clear();
            txtQuantity.Clear();
        }
    }
}
