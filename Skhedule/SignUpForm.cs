using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skhedule
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            User newuser = new User(tbUssername.Text, tbPassword.Text);
            string Confirm = tbConfirm.Text;
            if (newuser.signUp(newuser.Password, Confirm))
            {
                LoginForm f1 = new LoginForm();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password tidak sama");
            }
        }
    }
}
