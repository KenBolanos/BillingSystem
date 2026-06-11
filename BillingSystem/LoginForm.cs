namespace BillingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            username = Convert.ToString(txtUsername.Text).Trim();
            password = Convert.ToString(txtPassword.Text).Trim();

            if (username == string.Empty || password == string.Empty)
            {
                if (username == string.Empty)
                {
                    MessageBox.Show("Username should not be empty.");
                    txtUsername.Focus();
                }
                else if (password == string.Empty)
                {
                    MessageBox.Show("Password should not be empty.");
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Username and Password should not be empty.");
                    txtUsername.Focus();
                }
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Password should not be empty.");
                txtPassword.Focus();
            }
            else if (username == string.Empty && password == string.Empty)
            {
                MessageBox.Show("Username and Password should not be empty.");
                txtUsername.Focus();
            }
            else
            {
                CustomerListForm frm2 = new CustomerListForm();
                frm2.Show(this);
                this.Hide();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
