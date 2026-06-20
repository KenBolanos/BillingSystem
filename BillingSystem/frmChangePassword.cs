using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            ApplyTheme();
        }

        private void CheckPasswords(object sender, EventArgs e)
        {
            string currentpass = txtCurrentPassword.Text;
            string newpass = txtNewPassword.Text;
            string retype = txtRetypePassword.Text;

            btnSave.Enabled = false;

            if (string.IsNullOrEmpty(currentpass) && string.IsNullOrEmpty(newpass) && string.IsNullOrEmpty(retype))
            {
                lblRequirementsStatus.Text = "";
                lblPasswordStatus.Text = "";
                return;
            }

            bool hasMinimum = newpass.Length >= 8;
            bool hasUpper = newpass.Any(char.IsUpper);
            bool hasLower = newpass.Any(char.IsLower);
            bool hasNumeric = newpass.Any(char.IsDigit);
            bool hasSpecial = newpass.Any(c => !char.IsLetterOrDigit(c));

            List<string> missing = new List<string>();

            //for disaplying what password requirements that is still missing
            if (!hasMinimum) missing.Add("* At least 8 characters long");
            if (!hasUpper) missing.Add("* At least one (1) uppercase letter (A-Z)");
            if (!hasLower) missing.Add("* At least one (1) lowercase letter (a-z)");
            if (!hasNumeric) missing.Add("* At least one (1) numeric digit (0-9)");
            if (!hasSpecial) missing.Add("* At least one (1) special character (e.g. !@#$%^&*)");

            if (string.IsNullOrEmpty(currentpass))
            {
                missing.Add("* Enter your current password");
            }

            bool meetsAllRequirements = missing.Count == 0;

            if (!meetsAllRequirements)
            {
                lblRequirementsStatus.Text = "Password must still include:" + Environment.NewLine +
                                              string.Join(Environment.NewLine, missing);
                lblRequirementsStatus.ForeColor = Color.Red;
                lblPasswordStatus.Text = "";
                return;
            }

            lblRequirementsStatus.Text = "✔ Password meets all requirements";
            lblRequirementsStatus.ForeColor = Color.Green;

            //check if the current password is the same as the new password
            //and save button will remain disabled
            if (!string.IsNullOrEmpty(currentpass) && newpass == currentpass)
            {
                lblRequirementsStatus.Text = "✔ Password meets all requirements";
                lblRequirementsStatus.ForeColor = Color.Green;

                lblPasswordStatus.Text = "❌ New password cannot be the same as your current password";
                lblPasswordStatus.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(retype))
            {
                lblPasswordStatus.Text = "❌ Passwords do not match";
                lblPasswordStatus.ForeColor = Color.Red;
            }
            else if (newpass == retype)
            {
                lblPasswordStatus.Text = "✔ Passwords match";
                lblPasswordStatus.ForeColor = Color.Green;
                btnSave.Enabled = true;
            }
            else
            {
                lblPasswordStatus.Text = "❌ Passwords do not match";
                lblPasswordStatus.ForeColor = Color.Red;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidatePassword();
        }

        private void ValidatePassword()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE Users
                           SET Password = @NewPassword
                           WHERE  UserID = @userID
                             AND  Password = @Password;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", AppSession.CurrentUserID);
                        cmd.Parameters.AddWithValue("@Password", txtCurrentPassword.Text);
                        cmd.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            AuditLogger.Log("PASSWORD_CHANGE",
                                $"{AppSession.CurrentFullName} ({AppSession.CurrentRole}) changed password.");

                            MessageBox.Show("Password Changed Successfully.", "Password Change",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Change Password:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyTheme()
        {
            btnSave.BackColor = AppTheme.SuccessColor;
            btnSave.ForeColor = Color.White;
            btnCancel.BackColor = AppTheme.DangerColor;
            btnCancel.ForeColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
