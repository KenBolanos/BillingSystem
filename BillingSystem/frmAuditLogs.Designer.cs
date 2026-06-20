namespace BillingSystem
{
    partial class frmAuditLogs
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
            lblTitle = new Label();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            dgvAuditLogs = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(269, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audti Log Report";
            // 
            // lblFrom
            // 
            lblFrom.Anchor = AnchorStyles.Left;
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(74, 101);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 20);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Anchor = AnchorStyles.Left;
            dtpFrom.Location = new Point(126, 96);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(277, 27);
            dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            lblTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTo.AutoSize = true;
            lblTo.Location = new Point(421, 101);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 20);
            lblTo.TabIndex = 3;
            lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            dtpTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpTo.Location = new Point(455, 96);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(277, 27);
            dtpTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Right;
            btnSearch.BackColor = Color.Chartreuse;
            btnSearch.Location = new Point(752, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 47);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.AllowUserToAddRows = false;
            dgvAuditLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvAuditLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Columns.AddRange(new DataGridViewColumn[] { Date, Username, Role, Action, Details });
            dgvAuditLogs.Location = new Point(12, 142);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.RowHeadersVisible = false;
            dgvAuditLogs.RowHeadersWidth = 51;
            dgvAuditLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditLogs.Size = new Size(858, 306);
            dgvAuditLogs.TabIndex = 6;
            // 
            // Date
            // 
            Date.HeaderText = "Date / Time";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            // 
            // Details
            // 
            Details.HeaderText = "Details";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.Location = new Point(752, 456);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(98, 35);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmAuditLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(btnClose);
            Controls.Add(dgvAuditLogs);
            Controls.Add(btnSearch);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(lblTitle);
            Name = "frmAuditLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Log Report";
            Load += frmAuditLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnSearch;
        private DataGridView dgvAuditLogs;
        private Button btnClose;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Action;
        private DataGridViewTextBoxColumn Details;
    }
}