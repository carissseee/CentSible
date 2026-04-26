using System;
using System.Windows.Forms;
using CentSible.Logic;


namespace CentSible.Views
{
    public partial class RegistrationForm : Form
    {
        private AccountLogic accountLogic = new AccountLogic();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e) { }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                accountLogic.RegisterUser(CreateUserTextRegis.Text, CreatePassTextRegis.Text, ConfirmPassTextRegis.Text);
                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreateAccountLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}