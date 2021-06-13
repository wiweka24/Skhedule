
namespace Skhedule
{
    partial class ActForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActForm));
            this.clTanggal = new System.Windows.Forms.DateTimePicker();
            this.cbDaily = new System.Windows.Forms.CheckBox();
            this.cbOnce = new System.Windows.Forms.CheckBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.clHari = new System.Windows.Forms.CheckedListBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.tbDesk = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clTanggal
            // 
            this.clTanggal.CalendarFont = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTanggal.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTanggal.Location = new System.Drawing.Point(110, 192);
            this.clTanggal.Name = "clTanggal";
            this.clTanggal.Size = new System.Drawing.Size(225, 24);
            this.clTanggal.TabIndex = 0;
            this.clTanggal.ValueChanged += new System.EventHandler(this.clTanggal_ValueChanged);
            // 
            // cbDaily
            // 
            this.cbDaily.AutoSize = true;
            this.cbDaily.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDaily.Location = new System.Drawing.Point(119, 121);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(121, 20);
            this.cbDaily.TabIndex = 2;
            this.cbDaily.Text = "Aktivitas Harian";
            this.cbDaily.UseVisualStyleBackColor = true;
            this.cbDaily.CheckedChanged += new System.EventHandler(this.cbDaily_CheckedChanged_1);
            // 
            // cbOnce
            // 
            this.cbOnce.AutoSize = true;
            this.cbOnce.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnce.Location = new System.Drawing.Point(119, 153);
            this.cbOnce.Name = "cbOnce";
            this.cbOnce.Size = new System.Drawing.Size(133, 20);
            this.cbOnce.TabIndex = 3;
            this.cbOnce.Text = "Aktivitas Tertentu";
            this.cbOnce.UseVisualStyleBackColor = true;
            this.cbOnce.CheckedChanged += new System.EventHandler(this.cbOnce_CheckedChanged);
            // 
            // tbNama
            // 
            this.tbNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNama.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNama.Location = new System.Drawing.Point(43, 77);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(182, 17);
            this.tbNama.TabIndex = 5;
            this.tbNama.Text = "Nama Aktivitas...";
            this.tbNama.TextChanged += new System.EventHandler(this.tbNama_TextChanged);
            // 
            // clHari
            // 
            this.clHari.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clHari.FormattingEnabled = true;
            this.clHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.clHari.Location = new System.Drawing.Point(110, 222);
            this.clHari.Name = "clHari";
            this.clHari.Size = new System.Drawing.Size(225, 99);
            this.clHari.TabIndex = 7;
            this.clHari.SelectedIndexChanged += new System.EventHandler(this.clHari_SelectedIndexChanged);
            // 
            // btnAct
            // 
            this.btnAct.BackColor = System.Drawing.Color.Transparent;
            this.btnAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAct.BackgroundImage")));
            this.btnAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAct.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAct.ForeColor = System.Drawing.Color.White;
            this.btnAct.Location = new System.Drawing.Point(43, 402);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(145, 37);
            this.btnAct.TabIndex = 8;
            this.btnAct.UseVisualStyleBackColor = false;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // tbDesk
            // 
            this.tbDesk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDesk.Font = new System.Drawing.Font("MADE TOMMY", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesk.Location = new System.Drawing.Point(54, 342);
            this.tbDesk.Name = "tbDesk";
            this.tbDesk.Size = new System.Drawing.Size(281, 17);
            this.tbDesk.TabIndex = 10;
            this.tbDesk.Text = "deskripsi...";
            this.tbDesk.TextChanged += new System.EventHandler(this.tbDesk_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(300, 402);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(37, 37);
            this.btnDel.TabIndex = 11;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdt
            // 
            this.btnEdt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdt.BackgroundImage")));
            this.btnEdt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdt.ForeColor = System.Drawing.Color.White;
            this.btnEdt.Location = new System.Drawing.Point(194, 402);
            this.btnEdt.Name = "btnEdt";
            this.btnEdt.Size = new System.Drawing.Size(100, 37);
            this.btnEdt.TabIndex = 12;
            this.btnEdt.UseVisualStyleBackColor = true;
            this.btnEdt.Click += new System.EventHandler(this.btnEdt_Click);
            // 
            // ActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.btnEdt);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbDesk);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.clHari);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.cbOnce);
            this.Controls.Add(this.cbDaily);
            this.Controls.Add(this.clTanggal);
            this.DoubleBuffered = true;
            this.Name = "ActForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Aktivitas";
            this.Load += new System.EventHandler(this.ActForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker clTanggal;
        private System.Windows.Forms.CheckBox cbDaily;
        private System.Windows.Forms.CheckBox cbOnce;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.CheckedListBox clHari;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.TextBox tbDesk;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdt;
    }
}