namespace BillingSystem
{
    partial class frmBillingHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCustomerName = new Label();
            dgvBillingHistory = new DataGridView();
            btnClose = new Button();
            BillingMonth = new DataGridViewTextBoxColumn();
            PreviousReading = new DataGridViewTextBoxColumn();
            PresentReading = new DataGridViewTextBoxColumn();
            Consumption = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(28, 18);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(146, 25);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Billing History -";
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.AllowUserToAddRows = false;
            dgvBillingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Columns.AddRange(new DataGridViewColumn[] { BillingMonth, PreviousReading, PresentReading, Consumption, Rate, TotalAmount, Status });
            dgvBillingHistory.Location = new Point(12, 75);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.RowHeadersVisible = false;
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillingHistory.Size = new Size(903, 328);
            dgvBillingHistory.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(806, 428);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 39);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BillingMonth
            // 
            BillingMonth.HeaderText = "Billing Month";
            BillingMonth.MinimumWidth = 6;
            BillingMonth.Name = "BillingMonth";
            // 
            // PreviousReading
            // 
            PreviousReading.HeaderText = "Previous Reading";
            PreviousReading.MinimumWidth = 6;
            PreviousReading.Name = "PreviousReading";
            // 
            // PresentReading
            // 
            PresentReading.HeaderText = "Present Reading";
            PresentReading.MinimumWidth = 6;
            PresentReading.Name = "PresentReading";
            // 
            // Consumption
            // 
            Consumption.HeaderText = "Consumption";
            Consumption.MinimumWidth = 6;
            Consumption.Name = "Consumption";
            // 
            // Rate
            // 
            Rate.HeaderText = "Rate";
            Rate.MinimumWidth = 6;
            Rate.Name = "Rate";
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 479);
            Controls.Add(btnClose);
            Controls.Add(dgvBillingHistory);
            Controls.Add(lblCustomerName);
            MaximizeBox = false;
            Name = "frmBillingHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing History";
            Load += frmBillingHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private DataGridView dgvBillingHistory;
        private Button btnClose;
        private DataGridViewTextBoxColumn BillingMonth;
        private DataGridViewTextBoxColumn PreviousReading;
        private DataGridViewTextBoxColumn PresentReading;
        private DataGridViewTextBoxColumn Consumption;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
    }
}