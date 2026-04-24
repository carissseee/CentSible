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
using CentSible.Forms;   
using CentSible.Models;


namespace CentSible.Forms
{
    public partial class LoginForms : Form
    {
        private AccountLogic accountLogic = new AccountLogic();

        public LoginForms()
        {
            InitializeComponent();
        }

        private void LoginForms_Load(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = accountLogic.GetAuthenticatedUser(UserTextLogin.Text, PassTextLogin.Text);
                if (user != null)
                {
                    MessageBox.Show("Login Successful!");
                    new HomeForm(user).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (RegistrationForm regForm = new RegistrationForm())
            {
                regForm.ShowDialog();
            }

            this.Show();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}