using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKitapligiADONET
{
    public partial class UC_MyButton : UserControl
    {
        public UC_MyButton()
        {
            InitializeComponent();
            myButton.MouseMove += new MouseEventHandler(btn_MouseMoveonMyButtonChangeTheColor);

            myButton.MouseLeave += new EventHandler(btn_MouseLeaveMyButtonChangeTheColor);

            myButton.BackColor = Color.White;
        }

        private void btn_MouseMoveonMyButtonChangeTheColor(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.PaleGoldenrod;
        }

        private void btn_MouseLeaveMyButtonChangeTheColor(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
        }
    }
}
