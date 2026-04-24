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
           
        }
    }
}