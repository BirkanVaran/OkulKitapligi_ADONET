
namespace OkulKitapligiADONET
{
    partial class UC_MyButton
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
            this.myButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.myButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButton.Location = new System.Drawing.Point(0, 0);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(83, 33);
            this.myButton.TabIndex = 0;
            this.myButton.Text = "button1";
            this.myButton.UseVisualStyleBackColor = true;
            // 
            // UC_MyButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myButton);
            this.Name = "UC_MyButton";
            this.Size = new System.Drawing.Size(83, 33);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button myButton;
    }
}
