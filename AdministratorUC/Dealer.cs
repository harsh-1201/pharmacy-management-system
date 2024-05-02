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
    public partial class Dealer : Form
    {
        function fn = new function();
        string query;

        public Dealer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtDealerID.Text;
            string o_name = txtOwnerName.Text;
            string add = txtAddress.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            string email = txtEmail.Text;
            string org_name = txtOName.Text;

            query = "insert into dealer (Id , O_name , address , mobile , email , org_name) values ('"+id+"' , '"+o_name+"' , '"+add+"' , "+mobile+" , '"+email+"' , '"+org_name+"')";
            fn.setData(query , "Record added Successfully");
        }

        private void Dealer_Load(object sender, EventArgs e)
        {
            query = "select MAX (Id)+1 from dealer";
            fn.MAX(query, txtDealerID);
        }
    }
}
