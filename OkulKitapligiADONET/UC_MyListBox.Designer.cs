
namespace OkulKitapligiADONET
{
    partial class UC_MyListBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myListBox = new System.Windows.Forms.ListBox();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myListBox
            // 
            this.myListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myListBox.FormattingEnabled = true;
            this.myListBox.ItemHeight = 16;
            this.myListBox.Location = new System.Drawing.Point(0, 51);
            this.myListBox.Name = "myListBox";
            this.myListBox.Size = new System.Drawing.Size(219, 340);
            this.myListBox.TabIndex = 0;
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(13, 13);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(190, 22);
            this.myTextBox.TabIndex = 1;
            this.myTextBox.TextChanged += new System.EventHandler(this.myTextBox_TextChanged);
            // 
            // UC_MyListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.myListBox);
            this.Name = "UC_MyListBox";
            this.Size = new System.Drawing.Size(219, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox myListBox;
        public System.Windows.Forms.TextBox myTextBox;
    }
}
