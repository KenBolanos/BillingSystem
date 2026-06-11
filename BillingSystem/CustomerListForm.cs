using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm frm1 = new LoginForm();
            frm1.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomerForm frm1 = new AddCustomerForm();
            frm1.Show();
        }
    }
}
