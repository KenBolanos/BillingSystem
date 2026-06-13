namespace BillingSystem
{
    partial class AddCustomerForm
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
            lblFullName = new Label();
            lblAddress = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblBalance = new Label();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(121, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Customer";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(44, 67);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(44, 111);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(44, 157);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(121, 20);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(44, 207);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(44, 255);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(105, 20);
            lblBalance.TabIndex = 5;
            lblBalance.Text = "Initial Balance:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(191, 64);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(196, 27);
            txtFullName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(191, 108);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(196, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(191, 154);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(196, 27);
            txtContact.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtBalance
            // 
            txtBalance.Enabled = false;
            txtBalance.Location = new Point(191, 252);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(196, 27);
            txtBalance.TabIndex = 10;
            txtBalance.Text = "0.00";
            txtBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SpringGreen;
            btnSave.Location = new Point(33, 314);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Aqua;
            btnClear.Location = new Point(159, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 38);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OrangeRed;
            btnBack.Location = new Point(288, 314);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(109, 38);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblBalance);
            Controls.Add(lblEmail);
            Controls.Add(lblContact);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Add Customer";
            Load += AddCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblContact;
        private Label lblEmail;
        private Label lblBalance;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}