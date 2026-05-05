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
            PassTextLogin.PasswordChar = '\0';
            PassTextLogin.TextChanged += PassTextLogin_TextChanged;
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
                    Navigator.Home = new HomeForm(user);
                    Navigator.Goal = new GoalForm(user);
                    Navigator.Summary = new SummaryForm(user);
                    Navigator.Transaction = new TransactionForm(user);
                    Navigator.Prediction = new PredictionForm(user);

                    Navigator.Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void PassTextLogin_TextChanged(object sender, EventArgs e)
        {
            bool isPlaceholder = PassTextLogin.Text == PassTextLogin.Placeholder || string.IsNullOrWhiteSpace(PassTextLogin.Text);

            PassTextLogin.PasswordChar = isPlaceholder ? '\0' : '*';
        }

        private void PassTextLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassTextLogin.Text) || PassTextLogin.Text == PassTextLogin.Placeholder)
            {
                PassTextLogin.PasswordChar = '\0';
            }
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
    }
}