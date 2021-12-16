
namespace OkulKitapligiADONET
{
    partial class FormOduncIslemleri_SONRA
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
            this.groupBoxOgrenci = new System.Windows.Forms.GroupBox();
            this.uC_MyListBox1 = new OkulKitapligiADONET.UC_MyListBox();
            this.groupBoxKitap = new System.Windows.Forms.GroupBox();
            this.uC_MyListBoxKitaplar = new OkulKitapligiADONET.UC_MyListBox();
            this.groupBoxOgrenci.SuspendLayout();
            this.groupBoxKitap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOgrenci
            // 
            this.groupBoxOgrenci.Controls.Add(this.uC_MyListBox1);
            this.groupBoxOgrenci.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOgrenci.Name = "groupBoxOgrenci";
            this.groupBoxOgrenci.Size = new System.Drawing.Size(249, 426);
            this.groupBoxOgrenci.TabIndex = 0;
            this.groupBoxOgrenci.TabStop = false;
            this.groupBoxOgrenci.Text = "Öğrenci";
            // 
            // uC_MyListBox1
            // 
            this.uC_MyListBox1.Location = new System.Drawing.Point(6, 21);
            this.uC_MyListBox1.Name = "uC_MyListBox1";
            this.uC_MyListBox1.Size = new System.Drawing.Size(219, 391);
            this.uC_MyListBox1.TabIndex = 0;
            // 
            // groupBoxKitap
            // 
            this.groupBoxKitap.Controls.Add(this.uC_MyListBoxKitaplar);
            this.groupBoxKitap.Location = new System.Drawing.Point(267, 12);
            this.groupBoxKitap.Name = "groupBoxKitap";
            this.groupBoxKitap.Size = new System.Drawing.Size(269, 426);
            this.groupBoxKitap.TabIndex = 0;
            this.groupBoxKitap.TabStop = false;
            this.groupBoxKitap.Text = "Kitap";
            // 
            // uC_MyListBoxKitaplar
            // 
            this.uC_MyListBoxKitaplar.Location = new System.Drawing.Point(25, 21);
            this.uC_MyListBoxKitaplar.Name = "uC_MyListBoxKitaplar";
            this.uC_MyListBoxKitaplar.Size = new System.Drawing.Size(219, 391);
            this.uC_MyListBoxKitaplar.TabIndex = 0;
            // 
            // FormOduncIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxKitap);
            this.Controls.Add(this.groupBoxOgrenci);
            this.Name = "FormOduncIslemleri";
            this.Text = "KİTAP ÖDÜNÇ ALIM İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FormOduncIslemleri_Load);
            this.groupBoxOgrenci.ResumeLayout(false);
            this.groupBoxKitap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOgrenci;
        private System.Windows.Forms.GroupBox groupBoxKitap;
        private UC_MyListBox uC_MyListBox1;
        private UC_MyListBox uC_MyListBoxKitaplar;
    }
}