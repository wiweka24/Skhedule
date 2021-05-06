
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
            this.clTanggal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDaily = new System.Windows.Forms.CheckBox();
            this.cbOnce = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clHari = new System.Windows.Forms.CheckedListBox();
            this.btnAct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDesk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clTanggal
            // 
            this.clTanggal.Location = new System.Drawing.Point(103, 95);
            this.clTanggal.Name = "clTanggal";
            this.clTanggal.Size = new System.Drawing.Size(120, 20);
            this.clTanggal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // cbDaily
            // 
            this.cbDaily.AutoSize = true;
            this.cbDaily.Location = new System.Drawing.Point(29, 31);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(47, 17);
            this.cbDaily.TabIndex = 2;
            this.cbDaily.Text = "daily";
            this.cbDaily.UseVisualStyleBackColor = true;
            this.cbDaily.CheckedChanged += new System.EventHandler(this.cbDaily_CheckedChanged_1);
            // 
            // cbOnce
            // 
            this.cbOnce.AutoSize = true;
            this.cbOnce.Location = new System.Drawing.Point(97, 31);
            this.cbOnce.Name = "cbOnce";
            this.cbOnce.Size = new System.Drawing.Size(50, 17);
            this.cbOnce.TabIndex = 3;
            this.cbOnce.Text = "once";
            this.cbOnce.UseVisualStyleBackColor = true;
            this.cbOnce.CheckedChanged += new System.EventHandler(this.cbOnce_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Waktu";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(103, 65);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(120, 20);
            this.tbNama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktivitas";
            // 
            // clHari
            // 
            this.clHari.FormattingEnabled = true;
            this.clHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.clHari.Location = new System.Drawing.Point(103, 121);
            this.clHari.Name = "clHari";
            this.clHari.Size = new System.Drawing.Size(120, 109);
            this.clHari.TabIndex = 7;
            this.clHari.SelectedIndexChanged += new System.EventHandler(this.clHari_SelectedIndexChanged);
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(83, 281);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 8;
            this.btnAct.Text = "Add";
            this.btnAct.UseVisualStyleBackColor = true;
            this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desk";
            // 
            // tbDesk
            // 
            this.tbDesk.Location = new System.Drawing.Point(103, 240);
            this.tbDesk.Name = "tbDesk";
            this.tbDesk.Size = new System.Drawing.Size(120, 20);
            this.tbDesk.TabIndex = 10;
            // 
            // ActForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 323);
            this.Controls.Add(this.tbDesk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.clHari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOnce);
            this.Controls.Add(this.cbDaily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clTanggal);
            this.Name = "ActForm";
            this.Text = "Tambah Aktivitas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker clTanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDaily;
        private System.Windows.Forms.CheckBox cbOnce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clHari;
        private System.Windows.Forms.Button btnAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDesk;
    }
}