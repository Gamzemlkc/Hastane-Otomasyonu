﻿namespace Hastane.WFA.DoktorForm
{
    partial class DoktorEkleForm
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
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nuMaas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.lstHemsireler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(224, 342);
            this.btnTemizle.Size = new System.Drawing.Size(77, 42);
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(123, 342);
            this.btnKaydet.Size = new System.Drawing.Size(77, 42);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(124, 195);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(176, 20);
            this.txtTelefon.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Telefon ";
            // 
            // nuMaas
            // 
            this.nuMaas.Location = new System.Drawing.Point(124, 221);
            this.nuMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuMaas.Name = "nuMaas";
            this.nuMaas.Size = new System.Drawing.Size(177, 20);
            this.nuMaas.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Maaş";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Ünvan";
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(123, 275);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(176, 21);
            this.cmbUnvan.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Birim";
            // 
            // cmbBirim
            // 
            this.cmbBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirim.FormattingEnabled = true;
            this.cmbBirim.Location = new System.Drawing.Point(124, 248);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(176, 21);
            this.cmbBirim.TabIndex = 59;
            this.cmbBirim.SelectedIndexChanged += new System.EventHandler(this.cmbBirim_SelectedIndexChanged);
            // 
            // lstHemsireler
            // 
            this.lstHemsireler.FormattingEnabled = true;
            this.lstHemsireler.Location = new System.Drawing.Point(358, 52);
            this.lstHemsireler.Name = "lstHemsireler";
            this.lstHemsireler.Size = new System.Drawing.Size(191, 238);
            this.lstHemsireler.TabIndex = 60;
            this.lstHemsireler.SelectedIndexChanged += new System.EventHandler(this.lstHemsireler_SelectedIndexChanged_1);
            // 
            // DoktorEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 415);
            this.Controls.Add(this.lstHemsireler);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbUnvan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nuMaas);
            this.Controls.Add(this.label7);
            this.Name = "DoktorEkleForm";
            this.Text = "DoktorEkleForm";
            this.Load += new System.EventHandler(this.DoktorEkleForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.txtTCKN, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.cmbKanGrubu, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.btnTemizle, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.nuMaas, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtTelefon, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.cmbUnvan, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cmbBirim, 0);
            this.Controls.SetChildIndex(this.lstHemsireler, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nuMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nuMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.ListBox lstHemsireler;
    }
}