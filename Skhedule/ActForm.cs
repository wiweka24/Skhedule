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
    public partial class ActForm : Form
    {
        public ActForm()
        {
            InitializeComponent();
        }

        private void cbDaily_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbDaily.Checked)
            {
                clTanggal.Hide();
                //Activity Act1 = new OnceActivity();
            }
            else if (!cbDaily.Checked)
            {
                clTanggal.Show();
            }
        }

        private void cbOnce_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnce.Checked)
            {
                clHari.Hide();
            }
            else if (!cbOnce.Checked)
            {
                clHari.Show();
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (cbOnce.Checked && cbDaily.Checked)
            {
                MessageBox.Show("Hanya Bisa Checklist Salah Satu");
            }
            else if (!cbOnce.Checked && !cbDaily.Checked)
            {
                MessageBox.Show("Harus Checklist Salah Satu");
            }
            else if (cbOnce.Checked)
            {
                MessageBox.Show("Aktivitas Berhasil ditambahkan");
                Activity Act1 = new DailyActivity(tbNama.Text, tbDesk.Text, cbOnce.ToString());
            }
            else
            {
                MessageBox.Show("Aktivitas Rutin Berhasil ditambahkan");
                Activity Act2 = new DailyActivity(tbNama.Text, tbDesk.Text, cbOnce.ToString());
            }
        }
    }
}
