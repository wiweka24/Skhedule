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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(tbUname.Text, tbPass.Text);
            if (user.login(user.Ussername, user.Password))
            {
                //MessageBox.Show("login succesfully");
                ActForm Act = new ActForm();
                Act.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("incorrect ussername or password");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm f2 = new SignUpForm();
            f2.Show();
            this.Hide();
        }
    }
}
