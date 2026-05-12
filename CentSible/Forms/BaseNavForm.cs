using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentSible.Models;

namespace CentSible.Forms
{
    public abstract class BaseNavForm : Form
    {
        protected Account _user;
        protected bool _isNavigating = false;
        public BaseNavForm(Account user)
        {
            _user = user;
            this.FormClosing += (s, e) => {
                if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
                {
                    Application.Exit();
                }
                    
            };
        }
        protected virtual void InitializeNavigation() { }
        protected void PerformNavigation(Action navAction)
        {
            _isNavigating = true;
            navAction.Invoke();
        }
    }
}