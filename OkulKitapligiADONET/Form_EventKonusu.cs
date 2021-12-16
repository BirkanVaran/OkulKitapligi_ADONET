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
    public partial class Form_EventKonusu : Form
    {
        public Form_EventKonusu()
        {
            InitializeComponent();
        }

        // button1 için properties'e sağ tıklayıp Events'a geçip oradan MouseMove'a tıklayınca bu metot otomatik gelmişti.
        //private void button1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button1.BackColor = Color.Pink;
        //}
        // button2 için properties'e sağ tıklayıp Events'a geçip oradan MouseMove'a tıklayınca bu metot otomatik gelmişti.
        //private void button2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    button1.BackColor = Color.Pink;
        //}

        private void btn_FareUzerineGelinceRenkDegissin(object sender, EventArgs e)
        {
            //    button1.BackColor = Color.Pink;
            //    button2.BackColor = Color.Pink;

            //  Ya çok daha fazla button varsa?
            foreach (var item in this.Controls)
            {
                if (item is Button && ((Button)sender).Name==((Button)item).Name )
                {
                    ((Button)item).BackColor = Color.PaleGoldenrod;

                }
            }

        }
        private void btn_FareAyrilincaDefaultRengeDonsun(object sender, EventArgs e)
        {
            //    button1.BackColor = Color.Pink;
            //    button2.BackColor = Color.Pink;

            //  Ya çok daha fazla button varsa?
            foreach (var item in this.Controls)
            {
                if (item is Button && ((Button)sender).Name == ((Button)item).Name)
                {
                    ((Button)item).BackColor = SystemColors.Control;

                }
            }

        }
        private void Form_EventKonusu_Load(object sender, EventArgs e)
        {
            //buttonların MouseLeave event'larını properties ekranındaki event sekmesinden değil Form'un load'ında kod ekranında biz verebiliriz.

            //button1.MouseLeave += new EventHandler(btn_FareAyrilincaDefaultRengeDonsun);

            //button2.MouseLeave += new EventHandler(btn_FareAyrilincaDefaultRengeDonsun);

            //button3.MouseLeave += new EventHandler(btn_FareAyrilincaDefaultRengeDonsun);

            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).MouseLeave += new EventHandler(btn_FareAyrilincaDefaultRengeDonsun);
                }
            }

            tabControl1.Click += new EventHandler(TabaTiklandi);
        }

       private void TabaTiklandi(object sender, EventArgs e)
        {
            MessageBox.Show("tıkladın!!!");
        }
    }
}
