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
    public partial class UC_A_Report : UserControl
    {
        public UC_A_Report()
        {
            InitializeComponent();
        }

        private void staffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff_Report sr = new Staff_Report();
            sr.Show();
        }

        private void stockInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Replort stock = new Stock_Replort();
            stock.Show();
        }

        private void purchaseInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Report purchase = new Purchase_Report();
            purchase.Show();
        }

        private void salesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Report sales = new Sales_Report();
            sales.Show();
        }

        private void dealerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dealer_Report dealer_Report = new Dealer_Report();
            dealer_Report.Show();
        }

        private void companyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Company_Report company = new Company_Report();
            company.Show();
        }
    }
}
