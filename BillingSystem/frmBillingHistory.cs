using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using ScottPlot.MultiplotLayouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        private readonly int _customerId;

        public frmBillingHistory()
        {
            InitializeComponent();
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            LoadBillingHistory(_customerId);
        }

        public frmBillingHistory(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            ConfigureGridColumns();
        }

        private void LoadBillingHistory(int customerId)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT c.FullName,
                                  b.BillingMonth,
                                  b.PreviousReading,
                                  b.PresentReading,
                                  b.Consumption,
                                  b.RatePerCubic,
                                  b.TotalAmount,
                                  b.Status
                           FROM   Customers c
                           LEFT JOIN Billing b ON b.CustomerID = c.CustomerID
                           WHERE  c.CustomerID = @CustomerID
                           ORDER  BY b.BillingMonth DESC;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show(
                                    "The selected customer could not be found in the database.",
                                    "Customer Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                this.Close();
                                return;
                            }

                            lblCustomerName.Text = $"Billing History — {dt.Rows[0]["FullName"]}";

                            bool hasBillingRecords = dt.Rows[0]["BillingMonth"] != DBNull.Value;

                            if (!hasBillingRecords)
                            {
                                dgvBillingHistory.DataSource = null;

                                MessageBox.Show(
                                    "No billing records were found for this customer.",
                                    "No Records",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                return;
                            }

                            dt.Columns.Remove("FullName");
                            dgvBillingHistory.DataSource = dt;

                            dgvBillingHistory.ClearSelection();
                            dgvBillingHistory.CurrentCell = null;

                            this.BeginInvoke((MethodInvoker)delegate
                            {
                                dgvBillingHistory.ClearSelection();
                                dgvBillingHistory.CurrentCell = null;
                            });

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading billing history:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigureGridColumns()
        {
            dgvBillingHistory.AutoGenerateColumns = false;
            dgvBillingHistory.Columns["BillingMonth"].DataPropertyName = "BillingMonth";
            dgvBillingHistory.Columns["PreviousReading"].DataPropertyName = "PreviousReading";
            dgvBillingHistory.Columns["PresentReading"].DataPropertyName = "PresentReading";
            dgvBillingHistory.Columns["Consumption"].DataPropertyName = "Consumption";
            dgvBillingHistory.Columns["Rate"].DataPropertyName = "RatePerCubic";
            dgvBillingHistory.Columns["TotalAmount"].DataPropertyName = "TotalAmount";
            dgvBillingHistory.Columns["Status"].DataPropertyName = "Status";
        }

        private void ApplyTheme()
        {
            btnClose.BackColor = AppTheme.DangerColor;
            btnClose.ForeColor = Color.White;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.BackColor = AppTheme.PrimaryColor;
            dgvBillingHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBillingHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

            dgvBillingHistory.AlternatingRowsDefaultCellStyle.BackColor = AppTheme.GridRowAlt;
        }
    }
}
