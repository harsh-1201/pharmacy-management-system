using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class UC_ViewUser : UserControl
    {

        function fn = new function();
        String query;
        String CurrentUser = "";

        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public String ID
        {
            set {CurrentUser = value; }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '"+txtUserName.Text+"%'";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getdata(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        String userName;

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = gunaDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure..?", "Delete Confirmtion..!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (CurrentUser != userName)
                {
                    query = "delete from users where username = '" + userName + "'";
                    fn.setData(query, "User Record  Deleted .");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to Delete \n your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this , null);
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
