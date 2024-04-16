using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Acquaintance
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginField.ForeColor = Color.Gray;
            passwordField.ForeColor = Color.Gray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text.Equals("Введите логин..."))
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
                loginField.Text = "Введите логин...";
            }
        }

        private void passwordFields_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals("Введите пароль..."))
            {
                passwordField.Text = string.Empty;
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordFields_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text.Equals(string.Empty))
            {
                passwordField.ForeColor = Color.Gray;
                passwordField.Text = "Введите пароль...";
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (choice.Text.Equals("Пользователь")) 
            {
                if(loginField.Text == string.Empty || loginField.Text.Equals("Введите логин..."))
                {
                    MessageBox.Show("Пустое поле для логина");
                    return;
                }
                if(passwordField.Text == string.Empty || passwordField.Text.Equals("Введите пароль..."))
                {
                    MessageBox.Show("Пустое поле для пароля");
                    return;
                }
                using (var context_1 = new HeartFlutteringContext())
                {
                    Hash hash = new Hash();
                    string hashPassword = hash.CalculateMD5Hash(passwordField.Text);
                    loginField.Text = hashPassword;
                    var loginPasswords = context_1.LoginPasswords.Where(r => r.Login.Equals(loginField.Text) && r.Password.Equals(hashPassword));
                    List<LoginPassword> list = new List<LoginPassword>();
                    foreach (LoginPassword loginPassword in loginPasswords)
                    {
                        list.Add(loginPassword);
                    }
                    if (list.Count == 0) 
                    {
                        MessageBox.Show("Вы ввели неверно логин или пароль");
                        return;
                    }
                    int id = list[0].Id;
                    this.Hide();
                    HomeForm homeForm = new HomeForm();
                    using (var context_2 = new HeartFlutteringContext())
                    {
                        var users = context_2.Users.Where(r => r.Id == id);
                        List<User> listUsers = new List<User>();
                        foreach (User user in users)
                        {
                            listUsers.Add(user);
                        }

                        if(listUsers[0].Name != null) 
                        {
                            homeForm.nameField.Text = listUsers[0].Name;
                            homeForm.nameField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.nameField.Text = "Не заполнено";
                        }

                        if (listUsers[0].Surname != null)
                        {
                            homeForm.surnameField.Text = listUsers[0].Surname;
                            homeForm.surnameField.ForeColor = Color.Black;
                        }
                        else 
                        {
                            homeForm.surnameField.Text = "Не заполнено";
                        }

                        if (listUsers[0].DateOfBirth != null) 
                        {
                            homeForm.BirhdayField.Text = listUsers[0].DateOfBirth.ToString();
                            homeForm.BirhdayField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.BirhdayField.Text = "Не заполнено";
                        }

                        if (listUsers[0].City != null) 
                        {
                            homeForm.cityField.Text = listUsers[0].City;
                            homeForm.cityField.ForeColor = Color.Black;
                        }
                        else
                        {
                            homeForm.cityField.Text = "Не заполнено";
                        }

                        if (listUsers[0].Sex != null) 
                        {
                            if (listUsers[0].Sex == true) 
                            {
                                homeForm.sexField.Text = "Мужской";
                                homeForm.sexField.ForeColor = Color.Black;
                            }
                            else
                            {
                                homeForm.sexField.Text = "Женский";
                                homeForm.sexField.ForeColor = Color.Black;
                            }
                        }
                        else
                        {
                            homeForm.sexField.Text = "Не заполнено";
                        }

                        homeForm.Show();
                    }
                }
            }
        }
    }
}
