using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulKitapligiADONET
{
    public partial class FormYazarlar : Form
    {
        public FormYazarlar()
        {
            InitializeComponent();
        }

        //Global alan

        //SQLCONNECTION Nesnesi: SQL veritabanına bağlantı kurmak için kullanacağımız classtır. System.Data.Client namespace'i içerisinde yer alır.
        string SQLBaglantiCumlesi = @"Server=OMER;Database=OKULKITAPLIGI;Trusted_Connection=True;";
        SqlConnection baglanti = new SqlConnection();


        private void FormYazarlar_Load(object sender, EventArgs e)
        {

            dataGridViewYazarlar.MultiSelect = false; // çoklu satır seçimi engellendi
            // bir hücreye tıkladığında bulunduğu satırı tamamen seçecek
            dataGridViewYazarlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;// fare ile datagrid üzerinde 

            //dataGridView'e sağ tıklanınca gelecek olan contextmenustrip ataması yapıldı
            dataGridViewYazarlar.ContextMenuStrip = contextMenuStrip1;

            //grid'in içine bilgileri getireceğiz


            TumYazazarlariGetir();
        }

        private void TumYazazarlariGetir()
        {
            try
            {

                //SQLCOMMAND nesnesi:Sorgularımızı ve prosedürlerimize ait komutları alan nesnedir.
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                string sorgu = "Select * from Yazarlar where SilindiMi=0 order by YazarId desc";
                komut.CommandText = sorgu;
                BaglantiyiAc();


                //DataSQLADAPTER nesnesi, sorgu çalışınca oluşan dataların aktarılması işlemini yapar. Adaptore hangi komut işleyeceğini ctor'da verebiliriz ya da daha sonradan verebiliriz.
                SqlDataAdapter adaptor = new SqlDataAdapter(komut);  //ctor'da komutunu verdik
                //SqlDataAdapter adaptor = new SqlDataAdapter();
                // adaptor.SelectCommand = komut; //  komutunu daha sonradan da verilebilir.

                //Adaptorun içindeki verileri sanalTabloya alıyoruz.
                DataTable sanalTablo = new DataTable();
                adaptor.Fill(sanalTablo);

                dataGridViewYazarlar.DataSource = sanalTablo;
                dataGridViewYazarlar.Columns["SilindiMi"].Visible = false;
                dataGridViewYazarlar.Columns["YazarAdSoyad"].Width = 220;
                dataGridViewYazarlar.Columns["KayitTarihi"].Width = 150;


                BaglantiyiKapat();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Beklenmedik bir hata oluştu! HATA: {ex.Message}",
                    "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            switch (btnEkle.Text)
            {

                case "EKLE":
                    try
                    {
                        if (string.IsNullOrEmpty(txtYazar.Text))
                        {
                            MessageBox.Show("Lütfen yazar bilgisini giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //ekleme yapacağız.

                            string insertCumlesi = $"insert into Yazarlar (KayitTarihi, YazarAdSoyad,SilindiMi) values ('{TarihiDuzenle(DateTime.Now)}','{txtYazar.Text.Trim()}',0)";

                            // uzun ve karmaşık tek tırnaklarda hatalı yazabiliyoruz.
                            // 20 tane kolon olsa kesin karışır.Bu nedenle string format yapısını bize sunan $'i kullanarak yazdık
                            //string insertCumlesi = "insert into Yazarlar (KayitTarihi, YazarAdSoyad,SilindiMi) values ('"+ DateTime.Now +"','"+txtYazar.Text+"',0)";

                            // Tarihi buradan göndermek istemezsek Getdate yazarak sql içinde alabiliriz.
                            //string insertCumlesi = $"insert into Yazarlar (KayitTarihi, YazarAdSoyad,SilindiMi) values (getdate(),'{txtYazar.Text.Trim()}',0)";


                            SqlCommand insertkomut = new SqlCommand(insertCumlesi, baglanti);
                            //baglantı açılacak metot çağıralım
                            BaglantiyiAc();
                            int sonucum = insertkomut.ExecuteNonQuery();
                            if (sonucum > 0) //effected rows var
                            {
                                MessageBox.Show("Yeni yazar sisteme eklendi.");
                                TumYazazarlariGetir();

                            }
                            else
                            {
                                MessageBox.Show("Bir hata oluştu. Yeni yazar eklenemedi!");
                            }

                            // bağlantı kapanacak metot çağıralım

                            BaglantiyiKapat();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ekleme işleminde beklenmedik hata oldu!" + ex.Message);
                    }
                    Temizle();
                    break;


                case "GÜNCELLE":
                    try
                    {
                        if (!string.IsNullOrEmpty(txtYazar.Text))
                        {
                            using (baglanti)
                            {
                                DataGridViewRow satir = dataGridViewYazarlar.SelectedRows[0];
                                int YazarId = Convert.ToInt32(satir.Cells["YazarId"].Value);

                                //1. yol
                                string updateSorgucumlesi = $"Update Yazarlar Set YazarAdSoyad='{txtYazar.Text.Trim()}' where YazarId={YazarId}";


                                SqlCommand updateCommand = new SqlCommand(updateSorgucumlesi, baglanti);
                                BaglantiyiAc();
                                int sonuc = updateCommand.ExecuteNonQuery();
                                if (sonuc > 0)
                                {
                                    MessageBox.Show($"Yazar güncellendi");
                                    TumYazazarlariGetir();
                                }
                                else
                                {
                                    MessageBox.Show("Yazar güncellenmedi!");
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Yazar adı olmadan güncelleştirme yapamam!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Güncelleme işleminde beklenmedik hata oldu!" + ex.Message);

                    }
                    Temizle();
                    break;


                default:
                    break;
            }
        }

        private void Temizle()
        {
            btnEkle.Text = "EKLE";
            txtYazar.Clear();
        }

        private void BaglantiyiKapat()
        {
            try
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantıyı kapatırken bir hata oldu! " + ex.Message);
            }
        }

        private void BaglantiyiAc()
        {

            try
            {
                // bağlantı açık değilse açalım
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.ConnectionString = SQLBaglantiCumlesi;
                    baglanti.Open();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı açılırken bir hata oluştu!" + ex.Message);
            }
        }

        private string TarihiDuzenle(DateTime tarih)
        {
            string tarihString = string.Empty;
            if (tarih != null)
            {
                //2021-12-13 10:30
                tarihString = tarih.Year + "-" + tarih.Month + "-" + tarih.Day + " " +
                    tarih.Hour + ":" + tarih.Minute + ":" + tarih.Second;
            }



            return tarihString;

        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Seçili olan satırdaki istediğiniz hücreden (kolondan) değer aldık
            if (dataGridViewYazarlar.SelectedRows.Count > 0)
            {

                DataGridViewRow satir = dataGridViewYazarlar.SelectedRows[0];
                string yazarAdSoyad = Convert.ToString(satir.Cells["YazarAdSoyad"].Value);
                btnEkle.Text = "GÜNCELLE";
                txtYazar.Text = yazarAdSoyad;

                // kısa olsun isterseniz
                // txtYazar.Text = Convert.ToString(satir.Cells["YazarAdSoyad"].Value);

            }
            else
            {
                MessageBox.Show("Güncelleme işlemi için tablodan bir yazar seçmeniz gerekiyor!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dataGridViewYazarlar.SelectedRows[0];
            int yazarId = (int)secilenSatir.Cells["YazarId"].Value;
            string yazar = Convert.ToString(secilenSatir.Cells["YazarAdSoyad"].Value);

            //Yazarın kitapları varsa Kitaplar tablosunda YazarI foregin key vardır.
            //Bu durumda silme işlemi yapılmamalıdır.

            // önce bir select sorgusu ile kitaplar tablosunda o yazara ait kayıt var mı diye bakmalıyız. 
            // Varsa silmesine izin vermeyeceğiz
            //Yoksa silmek ister misin diye son bir kez sorup evet derse sileceğiz.

            SqlCommand komut = new SqlCommand($"select * from Kitaplar where YazarId={yazarId}", baglanti); // Sql command nesnesine çalıştıracağı sorguyu ve hangi bağlantı üzerinde çalışacağını constructor'da verdik.

            komut.Connection = baglanti;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut); //adaptöre işleyeceği komutu adaptorun constructor'ında verdik.
            DataTable sanalTablo = new DataTable();
            BaglantiyiAc();
            adaptor.Fill(sanalTablo);
            if (sanalTablo.Rows.Count > 0)
            {
                MessageBox.Show($"{yazar} isimli yazarın Kitaplar tablosunda {sanalTablo.Rows.Count.ToString()} adet kitabı bulunmaktadır. Bu yazarı silmek için öncelikle sistemdeki ona tanımlı kitapları silmeni gerekmektedir. Lütfen Kitap İşlemleri sayfasına gidiniz!");
            }
            else
            {
                // kitabı yok. Foreign key patlaması olmaz. Silebiliriz.
                DialogResult cevap = MessageBox.Show($"{yazar} adlı yazarı silmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    //silecek
                    //komut.CommandText = $"Delete from Yazarlar where YazarId={yazarId}";
                    //@yzrid diyerek bir parametre oluşturmuş olduk.
                    komut.CommandText = $"Delete from Yazarlar where YazarId=@yzrid";
                    komut.Parameters.Clear();
                    //AddWithValue metodu @yzrid yerine yazarId değerini sqlcommand nesnesinin commendText'inde bulunan sorgu cümlesine entegre eder.
                    komut.Parameters.AddWithValue("@yzrid", yazarId);

                    BaglantiyiAc();
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Silindi");
                        TumYazazarlariGetir();
                    }
                    else
                    {
                        MessageBox.Show("HATA:Silinemedi!");
                    }
                    BaglantiyiKapat();

                }

            }



        }

        private void silPasifeCekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // kullancı silindi zannedecek ama biz aslında pasif yapacağız
            try
            {
                using (baglanti)
                {
                    DataGridViewRow satir = dataGridViewYazarlar.SelectedRows[0];
                    int YazarId = Convert.ToInt32(satir.Cells["YazarId"].Value);

                    ////1. yol
                    //string updateSorgucumlesi = $"Update Yazarlar Set SilindiMi=1 where YazarId={YazarId}";
                    //2. yol
                    string updateSorguCumlesi = $"Update Yazarlar Set SilindiMi=1 where YazarId=@yzrid";
                    SqlCommand updateCommand = new SqlCommand(updateSorguCumlesi, baglanti);
                    updateCommand.Parameters.Clear();
                    updateCommand.Parameters.AddWithValue("@yzrid", YazarId);

                    BaglantiyiAc();
                    int sonuc = updateCommand.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show($"Yazar silindi");
                        TumYazazarlariGetir();
                    }
                    else
                    {
                        MessageBox.Show("DİKKAT: Yazar SİLİNMEDİ!");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pasife çek silme işleminde hata: " + ex.Message);

            }
        }

        private void silBaskaBirYontemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Bu yöntem yukarıdakiler gibi kullanışlı değildir.
            try
            {

                DataGridViewRow secilenSatir = dataGridViewYazarlar.SelectedRows[0];
                int yazarId = (int)secilenSatir.Cells["YazarId"].Value;
                string yazar = Convert.ToString(secilenSatir.Cells["YazarAdSoyad"].Value);
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                DialogResult cevap = MessageBox.Show($"{yazar} adlı yazarı silmek istediğinize emin misiniz?", "ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    komut.CommandText = $"Delete from Yazarlar where YazarId=@yzrid";
                    komut.Parameters.Clear();
                    komut.Parameters.AddWithValue("@yzrid", yazarId);
                    BaglantiyiAc();
                    int sonuc = komut.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Silindi");
                        TumYazazarlariGetir();
                    }
                    else
                    {
                        MessageBox.Show("HATA:Silinemedi!");
                    }
                    BaglantiyiKapat();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA: " + ex.Message);
            }
        }
    }
}
