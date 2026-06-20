namespace BillingSystem
{
    partial class frmChangePassword
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
            lblChangePassword = new Label();
            lblCurrentPassword = new Label();
            lblNewPassword = new Label();
            lblRetypePassword = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtRetypePassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblPasswordStatus = new Label();
            lblRequirementsStatus = new Label();
            SuspendLayout();
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangePassword.Location = new Point(107, 23);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(177, 28);
            lblChangePassword.TabIndex = 0;
            lblChangePassword.Text = "Change Password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.AutoSize = true;
            lblCurrentPassword.Location = new Point(12, 78);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(125, 20);
            lblCurrentPassword.TabIndex = 1;
            lblCurrentPassword.Text = "Current Password:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(12, 136);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(107, 20);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "New Password:";
            // 
            // lblRetypePassword
            // 
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Location = new Point(12, 195);
            lblRetypePassword.Name = "lblRetypePassword";
            lblRetypePassword.Size = new Size(123, 20);
            lblRetypePassword.TabIndex = 3;
            lblRetypePassword.Text = "Retype Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(143, 75);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(198, 27);
            txtCurrentPassword.TabIndex = 4;
            txtCurrentPassword.TextChanged += CheckPasswords;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(143, 133);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(198, 27);
            txtNewPassword.TabIndex = 5;
            txtNewPassword.TextChanged += CheckPasswords;
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(143, 192);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.PasswordChar = '*';
            txtRetypePassword.Size = new Size(198, 27);
            txtRetypePassword.TabIndex = 6;
            txtRetypePassword.TextChanged += CheckPasswords;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(33, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 52);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Password";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(224, 435);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(132, 52);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPasswordStatus
            // 
            lblPasswordStatus.AutoSize = true;
            lblPasswordStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordStatus.Location = new Point(62, 262);
            lblPasswordStatus.Name = "lblPasswordStatus";
            lblPasswordStatus.Size = new Size(0, 17);
            lblPasswordStatus.TabIndex = 9;
            // 
            // lblRequirementsStatus
            // 
            lblRequirementsStatus.AutoSize = true;
            lblRequirementsStatus.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequirementsStatus.Location = new Point(62, 233);
            lblRequirementsStatus.Name = "lblRequirementsStatus";
            lblRequirementsStatus.Size = new Size(0, 17);
            lblRequirementsStatus.TabIndex = 10;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 511);
            Controls.Add(lblRequirementsStatus);
            Controls.Add(lblPasswordStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtRetypePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblRetypePassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(lblChangePassword);
            MaximizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            Load += frmChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChangePassword;
        private Label lblCurrentPassword;
        private Label lblNewPassword;
        private Label lblRetypePassword;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtRetypePassword;
        private Button btnSave;
        private Button btnCancel;
        private Label lblPasswordStatus;
        private Label lblRequirementsStatus;
    }
}