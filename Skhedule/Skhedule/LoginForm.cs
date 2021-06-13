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
            if (tbUname.Text == "" || tbPass.Text == "")
            {
                MessageBox.Show("Kedua input tidak boleh kosong!");
            }
            using (var db = new SkheduleDBEntities())
            {
                var query = from UserTable in db.UserTables where UserTable.userUname == tbUname.Text select UserTable;
                foreach (var item in query)
                {
                    if(item.userPassword == tbPass.Text)
                    {
                        Kalender Kalender = new Kalender();
                        Kalender.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username/ Password salah");
                    }
                }
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpForm SignupForm = new SignUpForm();
            SignupForm.ShowDialog();
        }
    }
}
