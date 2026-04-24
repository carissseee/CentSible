using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentSible.Logic;   
using CentSible.Views;   
using CentSible.Models;


namespace CentSible.Views
{
    public partial class LoginForm : Form
    {
        private AccountLogic accountLogic = new AccountLogic();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = accountLogic.GetAuthenticatedUser(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    MessageBox.Show("Login Successful!");
                    new HomeForm(user).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            using (RegistrationForm regForm = new RegistrationForm())
            {
                regForm.ShowDialog();
            }
        }

    }
}