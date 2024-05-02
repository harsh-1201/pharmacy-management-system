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
    public partial class UC_AddUser : UserControl
    {

        function fn = new function();
        String query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtUserRole.Text;
            String name = txtName.Text;
            String Dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String pass = txtPassword.Text;
            try 
            {
                query = "insert into users (userRole,C_name,dob,mobile,email,username,pass) values ('"+role+"','"+name+"','"+Dob+"',"+mobile+",'"+email+"','"+username+"','"+pass+"')";
                fn.setData(query, "Sign Up Successfully.");
            }
            catch (Exception)
            {
                MessageBox.Show("User Name already Exists.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserRole.SelectedIndex = -1;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            query = "select * from users where username = '"+txtUserName.Text+"'";
            DataSet ds = fn.getdata(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"F:\\TY Project\\Pharmacy Management System\\Pharmacy Management System in C#\yes.png";
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.ImageLocation = @"F:\\TY Project\\Pharmacy Management System\\Pharmacy Management System in C#\no.png";
                pictureBox1.Visible = true;
            }

        }
    }
}
