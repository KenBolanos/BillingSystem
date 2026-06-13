using BillingSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            ConfigureDataGridView();
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
            frm1.ShowDialog();
            this.Close();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // SELECT all customers, most recently added first
                    string sql = @"SELECT CustomerID,
                                  FullName,
                                  Address,
                                  ContactNumber,
                                  Email,
                                  Balance,
                                  Status
                           FROM   Customers
                           ORDER  BY FullName ASC;";


                    using (var sda = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Improve column headers for readability
                        if (dgvCustomers.Columns.Count > 0)
                        {
                            dgvCustomers.Columns["CustomerID"].DataPropertyName = "CustomerID";
                            dgvCustomers.Columns["FullName"].DataPropertyName = "FullName";
                            dgvCustomers.Columns["Address"].DataPropertyName = "Address";
                            dgvCustomers.Columns["ContactNumber"].DataPropertyName = "ContactNumber";
                            dgvCustomers.Columns["Email"].DataPropertyName = "Email";
                            dgvCustomers.Columns["Balance"].DataPropertyName = "Balance";

                            // Bind the DataTable to the grid
                            dgvCustomers.DataSource = dt;
                        }

                        lblTitle.Text = $"Customer List  ({dt.Rows.Count} record(s))";

                        conn.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers:\n{ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomers(string keyword)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized SELECT with WHERE ... LIKE
                    string sql = @"SELECT CustomerID,
                                  FullName,
                                  Address,
                                  ContactNumber,
                                  Email,
                                  Balance,
                                  Status
                           FROM   Customers
                           WHERE  FullName      LIKE @keyword
                              OR  Address       LIKE @keyword
                              OR  ContactNumber LIKE @keyword
                           ORDER  BY FullName ASC;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        // %keyword% matches the search text anywhere in the column
                        cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dgvCustomers.Rows.Count > 0 )
                            {
                                dgvCustomers.Columns["CustomerID"].DataPropertyName = "CustomerID";
                                dgvCustomers.Columns["FullName"].DataPropertyName = "FullName";
                                dgvCustomers.Columns["Address"].DataPropertyName = "Address";
                                dgvCustomers.Columns["ContactNumber"].DataPropertyName = "ContactNumber";
                                dgvCustomers.Columns["Email"].DataPropertyName = "Email";
                                dgvCustomers.Columns["Balance"].DataPropertyName = "Balance";

                                dgvCustomers.DataSource = dt;

                            }
                            
                            lblTitle.Text = $"Customer List  ({dt.Rows.Count} result(s))";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching customers:\n{ex.Message}",
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Empty search box → show all customers again
                LoadCustomers();
            }
            else
            {
                SearchCustomers(keyword);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger the search button click
                btnSearch_Click(sender, e);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfigureDataGridView()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.Columns["CustomerID"].DataPropertyName = "CustomerID";
            dgvCustomers.Columns["FullName"].DataPropertyName = "FullName";
            dgvCustomers.Columns["Address"].DataPropertyName = "Address";
            dgvCustomers.Columns["ContactNumber"].DataPropertyName = "ContactNumber";
            dgvCustomers.Columns["Email"].DataPropertyName = "Email";
            dgvCustomers.Columns["Balance"].DataPropertyName = "Balance";
        }


    }
}
