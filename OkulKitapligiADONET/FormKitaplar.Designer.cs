
namespace OkulKitapligiADONET
{
    partial class FormKitaplar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UC_MyButton_Ekle = new OkulKitapligiADONET.UC_MyButton();
            this.numericUpDown_Ekle_Stok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Ekle_SayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.cmbBox_Ekle_Tur = new System.Windows.Forms.ComboBox();
            this.cmbBox_Ekle_Yazar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKitapEkle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxKitapGuncelle = new System.Windows.Forms.ComboBox();
            this.groupBoxKitapGuncelle = new System.Windows.Forms.GroupBox();
            this.UC_MyButton_Guncelle = new OkulKitapligiADONET.UC_MyButton();
            this.numericUpDown_Guncelle_Stok = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Guncelle_SayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBox_Guncelle_Yazar = new System.Windows.Forms.ComboBox();
            this.cmbBox_Guncelle_Tur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GuncelleKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.UC_MyButton_Sil = new OkulKitapligiADONET.UC_MyButton();
            this.richTextBoxKitap = new System.Windows.Forms.RichTextBox();
            this.cmbBox_Sil_Kitap = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ekle_Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ekle_SayfaSayisi)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxKitapGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Guncelle_Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Guncelle_SayfaSayisi)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewKitaplar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(670, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LİSTELE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToAddRows = false;
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.AllowUserToOrderColumns = true;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(11, 10);
            this.dataGridViewKitaplar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.RowHeadersWidth = 51;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(640, 373);
            this.dataGridViewKitaplar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UC_MyButton_Ekle);
            this.tabPage2.Controls.Add(this.numericUpDown_Ekle_Stok);
            this.tabPage2.Controls.Add(this.numericUpDown_Ekle_SayfaSayisi);
            this.tabPage2.Controls.Add(this.cmbBox_Ekle_Tur);
            this.tabPage2.Controls.Add(this.cmbBox_Ekle_Yazar);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtKitapEkle);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(670, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EKLE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UC_MyButton_Ekle
            // 
            this.UC_MyButton_Ekle.Location = new System.Drawing.Point(430, 230);
            this.UC_MyButton_Ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_MyButton_Ekle.Name = "UC_MyButton_Ekle";
            this.UC_MyButton_Ekle.Size = new System.Drawing.Size(106, 67);
            this.UC_MyButton_Ekle.TabIndex = 10;
            // 
            // numericUpDown_Ekle_Stok
            // 
            this.numericUpDown_Ekle_Stok.Location = new System.Drawing.Point(211, 274);
            this.numericUpDown_Ekle_Stok.Name = "numericUpDown_Ekle_Stok";
            this.numericUpDown_Ekle_Stok.Size = new System.Drawing.Size(182, 26);
            this.numericUpDown_Ekle_Stok.TabIndex = 9;
            // 
            // numericUpDown_Ekle_SayfaSayisi
            // 
            this.numericUpDown_Ekle_SayfaSayisi.Location = new System.Drawing.Point(211, 230);
            this.numericUpDown_Ekle_SayfaSayisi.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_Ekle_SayfaSayisi.Name = "numericUpDown_Ekle_SayfaSayisi";
            this.numericUpDown_Ekle_SayfaSayisi.Size = new System.Drawing.Size(182, 26);
            this.numericUpDown_Ekle_SayfaSayisi.TabIndex = 8;
            // 
            // cmbBox_Ekle_Tur
            // 
            this.cmbBox_Ekle_Tur.FormattingEnabled = true;
            this.cmbBox_Ekle_Tur.Location = new System.Drawing.Point(211, 167);
            this.cmbBox_Ekle_Tur.Name = "cmbBox_Ekle_Tur";
            this.cmbBox_Ekle_Tur.Size = new System.Drawing.Size(325, 28);
            this.cmbBox_Ekle_Tur.TabIndex = 7;
            // 
            // cmbBox_Ekle_Yazar
            // 
            this.cmbBox_Ekle_Yazar.FormattingEnabled = true;
            this.cmbBox_Ekle_Yazar.Location = new System.Drawing.Point(211, 115);
            this.cmbBox_Ekle_Yazar.Name = "cmbBox_Ekle_Yazar";
            this.cmbBox_Ekle_Yazar.Size = new System.Drawing.Size(325, 28);
            this.cmbBox_Ekle_Yazar.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tür:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Yazar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stok Adeti:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sayfa Sayısı:";
            // 
            // txtKitapEkle
            // 
            this.txtKitapEkle.Location = new System.Drawing.Point(211, 60);
            this.txtKitapEkle.Name = "txtKitapEkle";
            this.txtKitapEkle.Size = new System.Drawing.Size(325, 26);
            this.txtKitapEkle.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Adı:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxKitapGuncelle);
            this.tabPage3.Controls.Add(this.groupBoxKitapGuncelle);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(670, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GÜNCELLE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxKitapGuncelle
            // 
            this.comboBoxKitapGuncelle.BackColor = System.Drawing.Color.LightCyan;
            this.comboBoxKitapGuncelle.FormattingEnabled = true;
            this.comboBoxKitapGuncelle.Location = new System.Drawing.Point(134, 73);
            this.comboBoxKitapGuncelle.Name = "comboBoxKitapGuncelle";
            this.comboBoxKitapGuncelle.Size = new System.Drawing.Size(432, 28);
            this.comboBoxKitapGuncelle.TabIndex = 0;
            this.comboBoxKitapGuncelle.SelectedIndexChanged += new System.EventHandler(this.comboBoxKitapGuncelle_SelectedIndexChanged);
            // 
            // groupBoxKitapGuncelle
            // 
            this.groupBoxKitapGuncelle.Controls.Add(this.UC_MyButton_Guncelle);
            this.groupBoxKitapGuncelle.Controls.Add(this.numericUpDown_Guncelle_Stok);
            this.groupBoxKitapGuncelle.Controls.Add(this.numericUpDown_Guncelle_SayfaSayisi);
            this.groupBoxKitapGuncelle.Controls.Add(this.label6);
            this.groupBoxKitapGuncelle.Controls.Add(this.label5);
            this.groupBoxKitapGuncelle.Controls.Add(this.cmbBox_Guncelle_Yazar);
            this.groupBoxKitapGuncelle.Controls.Add(this.cmbBox_Guncelle_Tur);
            this.groupBoxKitapGuncelle.Controls.Add(this.label4);
            this.groupBoxKitapGuncelle.Controls.Add(this.label3);
            this.groupBoxKitapGuncelle.Controls.Add(this.txt_GuncelleKitapAdi);
            this.groupBoxKitapGuncelle.Controls.Add(this.label2);
            this.groupBoxKitapGuncelle.Location = new System.Drawing.Point(75, 128);
            this.groupBoxKitapGuncelle.Name = "groupBoxKitapGuncelle";
            this.groupBoxKitapGuncelle.Size = new System.Drawing.Size(491, 266);
            this.groupBoxKitapGuncelle.TabIndex = 1;
            this.groupBoxKitapGuncelle.TabStop = false;
            // 
            // UC_MyButton_Guncelle
            // 
            this.UC_MyButton_Guncelle.Location = new System.Drawing.Point(20, 218);
            this.UC_MyButton_Guncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_MyButton_Guncelle.Name = "UC_MyButton_Guncelle";
            this.UC_MyButton_Guncelle.Size = new System.Drawing.Size(456, 31);
            this.UC_MyButton_Guncelle.TabIndex = 2;
            // 
            // numericUpDown_Guncelle_Stok
            // 
            this.numericUpDown_Guncelle_Stok.Location = new System.Drawing.Point(380, 169);
            this.numericUpDown_Guncelle_Stok.Name = "numericUpDown_Guncelle_Stok";
            this.numericUpDown_Guncelle_Stok.Size = new System.Drawing.Size(96, 26);
            this.numericUpDown_Guncelle_Stok.TabIndex = 9;
            // 
            // numericUpDown_Guncelle_SayfaSayisi
            // 
            this.numericUpDown_Guncelle_SayfaSayisi.Location = new System.Drawing.Point(136, 169);
            this.numericUpDown_Guncelle_SayfaSayisi.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_Guncelle_SayfaSayisi.Name = "numericUpDown_Guncelle_SayfaSayisi";
            this.numericUpDown_Guncelle_SayfaSayisi.Size = new System.Drawing.Size(117, 26);
            this.numericUpDown_Guncelle_SayfaSayisi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stok:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // cmbBox_Guncelle_Yazar
            // 
            this.cmbBox_Guncelle_Yazar.FormattingEnabled = true;
            this.cmbBox_Guncelle_Yazar.Location = new System.Drawing.Point(74, 68);
            this.cmbBox_Guncelle_Yazar.Name = "cmbBox_Guncelle_Yazar";
            this.cmbBox_Guncelle_Yazar.Size = new System.Drawing.Size(402, 28);
            this.cmbBox_Guncelle_Yazar.TabIndex = 6;
            // 
            // cmbBox_Guncelle_Tur
            // 
            this.cmbBox_Guncelle_Tur.FormattingEnabled = true;
            this.cmbBox_Guncelle_Tur.Location = new System.Drawing.Point(74, 118);
            this.cmbBox_Guncelle_Tur.Name = "cmbBox_Guncelle_Tur";
            this.cmbBox_Guncelle_Tur.Size = new System.Drawing.Size(402, 28);
            this.cmbBox_Guncelle_Tur.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tür:";
            // 
            // txt_GuncelleKitapAdi
            // 
            this.txt_GuncelleKitapAdi.Location = new System.Drawing.Point(74, 19);
            this.txt_GuncelleKitapAdi.Name = "txt_GuncelleKitapAdi";
            this.txt_GuncelleKitapAdi.Size = new System.Drawing.Size(402, 26);
            this.txt_GuncelleKitapAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncellemek istediğiniz kitabı seçiniz...";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.UC_MyButton_Sil);
            this.tabPage4.Controls.Add(this.richTextBoxKitap);
            this.tabPage4.Controls.Add(this.cmbBox_Sil_Kitap);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(670, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SİL";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // UC_MyButton_Sil
            // 
            this.UC_MyButton_Sil.Location = new System.Drawing.Point(207, 348);
            this.UC_MyButton_Sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UC_MyButton_Sil.Name = "UC_MyButton_Sil";
            this.UC_MyButton_Sil.Size = new System.Drawing.Size(223, 43);
            this.UC_MyButton_Sil.TabIndex = 3;
            // 
            // richTextBoxKitap
            // 
            this.richTextBoxKitap.Location = new System.Drawing.Point(207, 126);
            this.richTextBoxKitap.Name = "richTextBoxKitap";
            this.richTextBoxKitap.ReadOnly = true;
            this.richTextBoxKitap.Size = new System.Drawing.Size(223, 204);
            this.richTextBoxKitap.TabIndex = 2;
            this.richTextBoxKitap.Text = "";
            // 
            // cmbBox_Sil_Kitap
            // 
            this.cmbBox_Sil_Kitap.FormattingEnabled = true;
            this.cmbBox_Sil_Kitap.Location = new System.Drawing.Point(207, 80);
            this.cmbBox_Sil_Kitap.Name = "cmbBox_Sil_Kitap";
            this.cmbBox_Sil_Kitap.Size = new System.Drawing.Size(223, 28);
            this.cmbBox_Sil_Kitap.TabIndex = 1;
            this.cmbBox_Sil_Kitap.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Sil_Kitap_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(284, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Silinmesini istediğiniz kitabı seçiniz...";
            // 
            // FormKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 456);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKitaplar";
            this.Text = "KİTAP İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FormKitaplar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ekle_Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ekle_SayfaSayisi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxKitapGuncelle.ResumeLayout(false);
            this.groupBoxKitapGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Guncelle_Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Guncelle_SayfaSayisi)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.ComboBox comboBoxKitapGuncelle;
        private System.Windows.Forms.GroupBox groupBoxKitapGuncelle;
        private System.Windows.Forms.NumericUpDown numericUpDown_Guncelle_Stok;
        private System.Windows.Forms.NumericUpDown numericUpDown_Guncelle_SayfaSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBox_Guncelle_Yazar;
        private System.Windows.Forms.ComboBox cmbBox_Guncelle_Tur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GuncelleKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UC_MyButton UC_MyButton_Guncelle;
        private UC_MyButton UC_MyButton_Ekle;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ekle_Stok;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ekle_SayfaSayisi;
        private System.Windows.Forms.ComboBox cmbBox_Ekle_Tur;
        private System.Windows.Forms.ComboBox cmbBox_Ekle_Yazar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKitapEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private UC_MyButton UC_MyButton_Sil;
        private System.Windows.Forms.RichTextBox richTextBoxKitap;
        private System.Windows.Forms.ComboBox cmbBox_Sil_Kitap;
        private System.Windows.Forms.Label label12;
    }
}