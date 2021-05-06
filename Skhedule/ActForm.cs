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
        public string jenis;
        public ActForm()
        {
            InitializeComponent();
        }

        private void cbDaily_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbDaily.Checked)
            {
                clTanggal.Hide();
                jenis = cbDaily.ToString();
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
                jenis = cbOnce.ToString();
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
                //Activity Act1 = new DailyActivity(tbNama.Text, tbDesk.Text, cbOnce.ToString());
                TambahData();
            } 
            else
            {
                MessageBox.Show("Aktivitas Rutin Berhasil ditambahkan");
                TambahDataDaily();
            }

        }

        private void TambahData()
        {
            var context = new SkheduleDBEntities();
            var act = new ActTable()
            {
                jenisAct = jenis,
                namaAct = tbNama.Text,
                waktuAct = clTanggal.Value,
                deskAct = tbDesk.Text
            };
            context.ActTables.Add(act);
            context.SaveChanges();
        }

        private void TambahDataDaily()
        {
            var contextDaily = new SkheduleDBEntities();
            var actDaily = new ActDailyTable()
            {
                jenisDact = jenis,
                namaDact = tbNama.Text,
                waktuDact = clHari.Text,
                deskDact = tbDesk.Text
            };
            contextDaily.ActDailyTables.Add(actDaily);
            contextDaily.SaveChanges();
        }

        private void clHari_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = clHari.SelectedIndex;
            string waktu = clHari.SelectedItem.ToString();
            int count = clHari.Items.Count;
            for(int x = 0; x < count; x++)
            {
                if(index != x)
                {
                    clHari.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
        }
    }
}
