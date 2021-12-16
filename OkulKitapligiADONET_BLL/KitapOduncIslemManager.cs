using OkulKitapligiADONET_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulKitapligiADONET_BLL
{
    public class KitapOduncIslemManager
    {
        MyPocketDAL myPocketDAL = new MyPocketDAL("DESKTOP-HNE43R2", "OKULKITAPLIGI", "", "");
        public DataTable TumKitaplariGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("Kitaplar", "*", "SilindiMi=0");
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable TumOgrencileriGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("Ogrenciler", "OgrId, CONCAT(OgrAd,' ',OgrSoyad) as OgrenciAdSoyad", "SilindiMi=0");
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GrideVerileriGetir()
        {
            try
            {
                DataTable data = new DataTable();
                data = myPocketDAL.GetTheData("SELECT i.IslemId, CONCAT(o.OgrAd, ' ',o.OgrSoyad) AS OgrenciAdSoyad, k.KitapAdi, i.OduncAldigiTarih, i.OduncBitisTarihi FROM Islem i INNER JOIN Kitaplar k ON k.KitapId=i.KitapId INNER JOIN Ogrenciler o ON o.OgrId=i.OgrId");
                return data;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int KitabinStogunuGetir(int kitapId)
        {
            try
            {
                object data = myPocketDAL.GetTheDataByExecuteScalar($"SELECT Stok FROM Kitaplar WHERE KitapId={kitapId}");
                int stokAdeti = 0;
                if (data!=null)
                {
                    stokAdeti = Convert.ToInt32(data);
                }


                return stokAdeti;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
