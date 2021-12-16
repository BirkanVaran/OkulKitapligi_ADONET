using OkulKitapligiADONET_BLL;
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
    public partial class FormOduncIslemleri_SONRA : Form
    {
        public FormOduncIslemleri_SONRA()
        {
            InitializeComponent();
        }
        // GLOBAL ALAN
        KitapOduncIslemManager kitapOduncIslemManager = new KitapOduncIslemManager();

        private void FormOduncIslemleri_Load(object sender, EventArgs e)
        {
            // From Load olduğunda kitaplar ListBox'a gelecek.
            TumKitaplariUC_MyListBoxKitaplaraGetir();

            // Form Load olduğunda öğrenciler ListBox'a gelecek.
        }

        private void TumKitaplariUC_MyListBoxKitaplaraGetir()
        {
            uC_MyListBoxKitaplar.myListBox.DataSource = kitapOduncIslemManager.TumKitaplariGetir();
        }
    }
}
