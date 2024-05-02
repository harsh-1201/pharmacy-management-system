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
    public partial class Company : Form
    {

        function fn = new function();
        string query;

        public Company()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtCompanyID.Text;
            string name = txtCompanyName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string country = txtCountry.Text;
            string state = txtState.Text;
            string city = txtCity.Text;
            string url = txtURL.Text;

            query = "insert into company (c_id , name , contact , email , address , country , state , city , url)  values ('"+id+"' , '"+name+"' , '"+contact+"' , '"+email+"' , '"+address+"' , '"+country+"' , '"+state+"' , '"+city+"' , '"+url+"')";
            fn.setData(query , "Record added successfully");

            clearAll();


        }

        private void Company_Load(object sender, EventArgs e)
        {
            query = "select MAX (c_id)+1 from company";
            fn.MAX(query, txtCompanyID);
        }

        public void clearAll()
        {
            txtCompanyID.Clear();
            txtCompanyName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtCountry.Clear();
            txtState.Clear();
            txtCity.Clear();
            txtURL.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
