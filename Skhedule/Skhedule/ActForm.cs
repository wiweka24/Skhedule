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
        ActTable aktivitas;
        ActDailyTable aktivitas1;
        
        public ActForm()
        {
            InitializeComponent();
        }

        public ActForm(string nama, string jenisAct, DateTime tanggal, string desk)
        {
            InitializeComponent();
            checkJenis(jenisAct);
            aktivitas = new ActTable
            {
                namaAct = nama,
                jenisAct = jenisAct,
                waktuAct = tanggal,
                deskAct = desk,
            };
            tbNama.Text = nama;
            clTanggal.Value = tanggal;
            tbDesk.Text = desk;

            //Dummy Value
            aktivitas1 = new ActDailyTable
            {
                namaDact = "",
            };
        }

        public ActForm(string nama, string jenisAct, string tanggal, string desk)
        {
            InitializeComponent();
            checkJenis(jenisAct);
            aktivitas1 = new ActDailyTable
            {
                namaDact = nama,
                jenisDact = jenisAct,
                waktuDact = tanggal,
                deskDact = desk,
            };
            tbNama.Text = nama;
            tbDesk.Text = desk;

            //Dummy Value
            aktivitas = new ActTable
            {
                namaAct = "",
            };
        }

        private void checkJenis(string jenisAct)
        {
            if (jenisAct == "once")
                cbOnce.Checked = true;
            else
                cbDaily.Checked = true;
        }

        private void cbDaily_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbDaily.Checked)
            {
                clTanggal.Hide();
                jenis = cbDaily.Text;
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
                jenis = cbOnce.Text;
            }
            else if (!cbOnce.Checked)
            {
                clHari.Show();
            }
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            if (cbOnce.Checked && cbDaily.Checked)
                MessageBox.Show("Hanya Bisa Checklist Salah Satu");
            else if (!cbOnce.Checked && !cbDaily.Checked)
                MessageBox.Show("Harus Checklist Salah Satu");
            else if (cbOnce.Checked)
            {
                int cekJenis = checkNama(tbNama.Text);
                if (tbNama.Text == "")
                {
                    MessageBox.Show("Nama Aktivitas Kosong");
                }
                else
                {
                    if (cekJenis == 2)
                    {
                        MessageBox.Show("Aktivitas Berhasil Ditambahkan");
                        TambahData();
                        Close();
                    }
                    else
                        MessageBox.Show("Nama Aktivitas Sama, Silahkan Ganti");
                }
            } 
            else
            {
                int cekJenis1 = checkNama(tbNama.Text);
                if (tbNama.Text == "")
                {
                    MessageBox.Show("Nama Aktivitas Kosong");
                }
                else if (clHari.CheckedItems.Count > 1 || clHari.CheckedItems.Count < 1)
                {
                    MessageBox.Show("Harus Pilih Salah Satu Hari");
                }
                else if (clHari.CheckedItems.Count == 1)
                {
                    if (cekJenis1 == 2)
                    {
                        MessageBox.Show("Aktivitas Rutin Berhasil Ditambahkan");
                        TambahDataDaily();
                        Close();
                    }
                    else
                        MessageBox.Show("Nama Aktivitas Sama, Silahkan Ganti");
                }
            }
        }

        private void TambahData()
        {
            using (var context = new SkheduleDBEntities())
            {
                var act = new ActTable()
                {
                    jenisAct = jenis,
                    namaAct = tbNama.Text,
                    waktuAct = clTanggal.Value.Date,
                    deskAct = tbDesk.Text
                };
                context.ActTables.Add(act);
                context.SaveChanges();
            }
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

        private int checkNama(string nama)
        {
            var db = new SkheduleDBEntities();
            var query = from ActTable in db.ActTables select ActTable;
            foreach (var item in query)
            {
                if (item.namaAct == nama)
                    return 1;
            }
            var query1 = from ActDailyTable in db.ActDailyTables select ActDailyTable;
            foreach(var item in query1)
            {
                if (item.namaDact == nama)
                    return 1;
            }
            return 2;
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            using (var db = new SkheduleDBEntities())
            {
                var query = from ActTable in db.ActTables select ActTable;
                var query1 = from ActDailyTable in db.ActDailyTables select ActDailyTable;
                foreach (var item in query)
                {
                    if (item.namaAct == aktivitas.namaAct)
                    {
                        int cekJenis = checkNama(tbNama.Text);
                        if (tbNama.Text == "")
                        {
                            MessageBox.Show("Nama Aktivitas Kosong");
                        }
                        else
                        {
                            if (cekJenis == 2)
                            {
                                item.jenisAct = jenis;
                                item.namaAct = tbNama.Text;
                                item.waktuAct = clTanggal.Value.Date;
                                item.deskAct = tbDesk.Text;
                                MessageBox.Show("Aktivitas berhasil diperbarui");
                                Close();
                            }
                            else
                                MessageBox.Show("Nama Aktivitas Sama, Silahkan Ganti");
                        }
                    }
                }
                foreach (var item in query1)
                {
                    if (item.namaDact == aktivitas1.namaDact)
                    {
                        int cekJenis1 = checkNama(tbNama.Text);
                        if (tbNama.Text == "")
                        {
                            MessageBox.Show("Nama Aktivitas Kosong");
                        }
                        else if (clHari.CheckedItems.Count > 1 || clHari.CheckedItems.Count < 1)
                        {
                            MessageBox.Show("Harus Pilih Salah Satu Hari");
                        }
                        else if (clHari.CheckedItems.Count == 1)
                        {
                            if (cekJenis1 == 2)
                            {
                                item.jenisDact = jenis;
                                item.namaDact = tbNama.Text;
                                item.waktuDact = clHari.Text;
                                item.deskDact = tbDesk.Text;
                                MessageBox.Show("Aktivitas berhasil diperbarui");
                                Close();
                            }
                            else
                                MessageBox.Show("Nama Aktivitas Sama, Silahkan Ganti");
                        }
                    }
                }
                db.SaveChanges();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (var db = new SkheduleDBEntities())
            {
                var query = from ActTable in db.ActTables select ActTable;
                var query1 = from ActDailyTable in db.ActDailyTables select ActDailyTable;
                foreach (var item in query)
                {
                    if (item.namaAct == aktivitas.namaAct)
                        db.ActTables.RemoveRange(db.ActTables.Where(a => a.namaAct == aktivitas.namaAct));
                }
                foreach (var item in query1)
                {
                    if (item.namaDact == aktivitas1.namaDact)
                        db.ActDailyTables.RemoveRange(db.ActDailyTables.Where(b => b.namaDact == aktivitas1.namaDact));
                }
                db.SaveChanges();
                MessageBox.Show("Aktivitas berhasil dihapus");
                Close();
            }
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

        private void ActForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbDesk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
