using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kumbara.Classes;
namespace Kumbara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Para> paralar = new List<Para>();
        List<Para> kumbaradakiParalar = new List<Para>();
        Kumbaraa kumbara = new Kumbaraa();
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {


            kumbara.Isim = "Kumbaracik";
            kumbara.Hacim = 0;
            kumbara.Miktar = 0;
            #region PARALARI TANIMLAMA
            // para ları tanımlıyoruz 
            Para Demir005 = new Para();
            Demir005.Isim = " 0.05 TL ";
            Demir005.Miktar = 0.05;
            Demir005.Yukseklik = 1.7;
            Demir005.Cap = 1.7;
            Demir005.Hacim = Para.Pi * ((Demir005.Cap / 2) * (Demir005.Cap / 2)) * Demir005.Yukseklik;
            // paralar adlı listeye atıyoruz.
            paralar.Add(Demir005);

            Para Demir010 = new Para();
            Demir010.Isim = " 0.10 TL ";
            Demir010.Miktar = 0.10;
            Demir010.Yukseklik = 1.7;
            Demir010.Cap = 1.925;
            Demir010.Hacim = Para.Pi * ((Demir010.Cap / 2) * (Demir010.Cap / 2)) * Demir010.Yukseklik;

            paralar.Add(Demir010);

            Para Demir025 = new Para();
            Demir025.Isim = " 0.25 TL ";
            Demir025.Miktar = 0.25;
            Demir025.Yukseklik = 1.9;
            Demir025.Cap = 2.385;
            Demir025.Hacim = Para.Pi * ((Demir025.Cap / 2) * (Demir025.Cap / 2)) * Demir025.Yukseklik;

            paralar.Add(Demir025);

            Para Demir05 = new Para();
            Demir05.Isim = " 0.5 TL ";
            Demir05.Miktar = 0.5;
            Demir05.Yukseklik = 1.95;
            Demir05.Cap = 2.15;
            Demir05.Hacim = Para.Pi * ((Demir05.Cap / 2) * (Demir05.Cap / 2)) * Demir05.Yukseklik;

            paralar.Add(Demir05);

            Para Demir1 = new Para();
            Demir1.Isim = " 1 TL ";
            Demir1.Miktar = 1;
            Demir1.Yukseklik = 1.95;
            Demir1.Cap = 2.615;
            Demir1.Hacim = Para.Pi * ((Demir1.Cap / 2) * (Demir1.Cap / 2)) * Demir1.Yukseklik;

            paralar.Add(Demir1);

            Para Kagit5 = new Para();
            Kagit5.Isim = " 5 TL ";
            Kagit5.Miktar = 5;
            Kagit5.Yukseklik = 0.25;
            Kagit5.Boy = 6.4;
            Kagit5.En = 13;
            Kagit5.Hacim = Kagit5.Boy * Kagit5.En * Kagit5.Yukseklik;

            paralar.Add(Kagit5);

            Para Kagit10 = new Para();
            Kagit10.Isim = " 10 TL ";
            Kagit10.Miktar = 10;
            Kagit10.Yukseklik = 0.25;
            Kagit10.Boy = 6.4;
            Kagit10.En = 13.6;
            Kagit10.Hacim = Kagit10.Boy * Kagit10.En * Kagit10.Yukseklik;

            paralar.Add(Kagit10);

            Para Kagit20 = new Para();
            Kagit20.Isim = " 20 TL ";
            Kagit20.Miktar = 20;
            Kagit20.Yukseklik = 0.25;
            Kagit20.Boy = 6.8;
            Kagit20.En = 14.2;
            Kagit20.Hacim = Kagit20.Boy * Kagit20.En * Kagit20.Yukseklik;

            paralar.Add(Kagit20);

            Para Kagit50 = new Para();
            Kagit50.Isim = " 50 TL ";
            Kagit50.Miktar = 50;
            Kagit50.Yukseklik = 0.25;
            Kagit50.Boy = 6.4;
            Kagit50.En = 14.8;
            Kagit50.Hacim = Kagit50.Boy * Kagit50.En * Kagit50.Yukseklik;

            paralar.Add(Kagit50);

            Para Kagit100 = new Para();
            Kagit100.Isim = " 100 TL ";
            Kagit100.Miktar = 100;
            Kagit100.Yukseklik = 0.25;
            Kagit100.Boy = 7.2;
            Kagit100.En = 15.4;
            Kagit100.Hacim = Kagit100.Boy * Kagit100.En * Kagit100.Yukseklik;

            paralar.Add(Kagit100);

            Para Kagit200 = new Para();
            Kagit200.Isim = " 200 TL ";
            Kagit200.Miktar = 200;
            Kagit200.Yukseklik = 0.25;
            Kagit200.Boy = 7.2;
            Kagit200.En = 16;
            Kagit200.Hacim = Kagit200.Boy * Kagit200.En * Kagit200.Yukseklik;

            paralar.Add(Kagit200);
            #endregion
            //Paraları  paralar adlı listeye attık 
            foreach (Para para in paralar)
            {
                cmbParalar.Items.Add(para.Isim);
            }
        }
        private void cmbParalar_SelectedIndexChanged(object sender, EventArgs e)
        {  // Combo box ta para seçildikçe para ile ilgili bilgilerin yazdırıldıgı ekran 
            foreach (Para para in paralar)
            {
                if (para.Isim == cmbParalar.SelectedItem.ToString())
                {
                    lstEkran.Items.Add(para.Isim + "Miktarı : " + para.Miktar + " Hacim : " + para.Hacim);
                }
            }
        }
        int katlanmaDurumu = 0;
        private void btnParaAt_Click(object sender, EventArgs e)
        { // para atıldıgı zaman paralar  listesinde paraları dönüyor ve combo box taki isimle olan parayı buluyor ve onunmiktarına göre parayı kumbaranın miktar propperty sine ekliyor    
            if (kumbara.Hacim > 499)
            {
                Hata.HacimTasma();
            }
            else if (kirmaSayisi == 2)
            {
                Hata.KirilmisEkleme();
            }
            else
            {
                try
                {
                    foreach (Para para in paralar)
                    {
                        if (para.Isim == cmbParalar.SelectedItem.ToString())
                        {
                            if (para.Miktar > 4.99 && katlanmaDurumu == 0)
                            {
                                Hata.KumbarayaKoymadanOnce();
                            }
                            else
                            {
                                // paranın boşluksuz değerini tuttuk
                                double hacim = para.Hacim;
                                para.Bosluk();
                                lstEkran.Items.Add(para.Isim + " isimli paranın atılırkenki hacmi : " + para.Hacim);
                                kumbaradakiParalar.Add(para);

                                // boşluguyla birlikte kumbaraya attık
                                para.ParaAt(kumbara);
                                // paranın boşluksuz değerini tekrar paraya verdik
                                para.Hacim = hacim;
                                katlanmaDurumu = 0;
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    Hata.ParaEklemekIcin();
                }
            }
        }
        private void btnKatla_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Para para in paralar)
                {

                    if (para.Isim == cmbParalar.SelectedItem.ToString())
                    {
                        if (para.Miktar < 5)
                        {
                            Hata.DemirParaKatlanmaz();
                            // döngünün içinde hata kontrolü yaptırmamız gerekti  "break" komutu kullamasaydık

                            // 5 ten küçük olan  paralar kadar hata mesajı verirdi....
                            break;
                        }
                        else
                        {
                            lstEkran.Items.Add(" Katlanmadan  Önceki => En : " + para.En + " Boy : " + para.Boy + " Yükseklik : " + para.Yukseklik);
                            para.Katla();
                            lstEkran.Items.Add(" Katlamadan Sonraki => En : " + para.En + " Boy : " + para.Boy + " Yükseklik : " + para.Yukseklik);
                            katlanmaDurumu = 1;
                        }
                    }

                }
            }
            catch (NullReferenceException)
            {
                Hata.KatlamakSecmek();
            }
        }
        private void btnSalla_Click(object sender, EventArgs e)
        { // salladıktan önceki ve sonraki hacimleri gösterir 
            lstEkran.Items.Add("Eski Hacim  : " + kumbara.Hacim);
            Salla();
            lstEkran.Items.Add("YEni Hacim  : " + kumbara.Hacim);
        }
        void Salla()
        { //  Toplam  kumbaranın içindeki paraların boşluklu hacmini buluyoruz 
            // içindeki paraların boşluksuz hacmini  buluyoruz  bu hacimden 0.25 fazla olması gerekiyor.

            //   Bu method sayesinde Kumpara için deki paraların  boşluksuz hacimlerini toplayp üzerine sadece   yüzde  25 ekliyorum eğer  

            // BU SAYEDE :  Sallamadan önce yeni para atılmışmı diye kontrol etmeye gerek kalmıyor zaten salladıgında en fazla ine bilecegi deger olan paraların  %25 fazlasını her salladıgında veriyor.
            double toplamKumbaraHacmi = 0;
            double bosluksuzOlmasiGerenekHacim = 0;
            foreach (Para item in kumbaradakiParalar)
            {
                foreach (Para para in paralar)
                {
                    if (item.Isim == para.Isim)
                    {
                        bosluksuzOlmasiGerenekHacim = bosluksuzOlmasiGerenekHacim + para.Hacim;
                    }
                }
                toplamKumbaraHacmi = toplamKumbaraHacmi + item.Hacim;
            }
            kumbara.Hacim = bosluksuzOlmasiGerenekHacim * 1.25;
        }
        int kirmaSayisi = 0;
        private void btnKir_Click(object sender, EventArgs e)
        {   // 2 kere kırılmış bir kumbara birleştirilemeyeceği için tekrarda kırılamasın.
            if (kirmaSayisi == 2)
            {
                Hata.Kirma2();
            }
            else
            {
                MessageBox.Show("Kumbaranızdaki  toplam para miktarınız : " + kumbara.Miktar);
                kumbara.KumbarayiKir();
                kirmaSayisi++;
            }
        }
        // listemizi temizler.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstEkran.Items.Clear();
        }
    }
}
