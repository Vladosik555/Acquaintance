namespace Acquaintance
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginField.ForeColor = Color.Gray;
            passwordFields.ForeColor = Color.Gray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals("¬ведите логин..."))
            {
                loginField.Text = string.Empty;
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text.Equals(string.Empty))
            {
                loginField.ForeColor = Color.Gray;
                loginField.Text = "¬ведите логин...";
            }
        }

        private void passwordFields_Enter(object sender, EventArgs e)
        {
            if (passwordFields.Text.Equals("¬ведите пароль..."))
            {
                passwordFields.Text = string.Empty;
                passwordFields.ForeColor = Color.Black;
            }
        }

        private void passwordFields_Leave(object sender, EventArgs e)
        {
            if (passwordFields.Text.Equals(string.Empty))
            {
                passwordFields.ForeColor = Color.Gray;
                passwordFields.Text = "¬ведите пароль...";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CollapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
