using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kullanıcı Adı Şifre ile Giriş
            //Kullanıcı adı = Admin
            //Şifre = 1234 ise 
            //hoşgeldiniz değil ise kullanıcı adı veya şifre hatalı uyarısı verilecek.

            //Console.WriteLine("Kullanıcı adı giriniz = ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifre giriniz = ");
            //int sifre = Convert.ToInt32(Console.ReadLine());

            //if (kullaniciAdi == "Admin" )
            //{
            //    if (sifre == 1234)
            //    {
            //        Console.WriteLine("Hoşgeldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adınızı ve şifre hatalı");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kullanıcı adınızı ve şifre hatalı");
            //}

            #endregion

            #region Kayıtlı Kullanıcı Adı ve Şifre ile Giriş

            //string[] kullaniciAdlari = { "alp", "samet", "mevlüt" };
            //string[] sifreler = { "1234", "1235", "1236" };

            //Console.WriteLine("Kullanıcı adınızı giriniz = ");
            //string kullaniciAdi = Console.ReadLine();
            //Console.WriteLine("Şifrenizi giriniz = ");
            //string sifre = Console.ReadLine();

            //int index = -1;
            //for (int i = 0; i < kullaniciAdlari.Length; i++)
            //{
            //    if (kullaniciAdlari[i] == kullaniciAdi)
            //    {
            //        index = i;
            //        break;
            //    }

            //}
            //if (index == -1)
            //{
            //    Console.WriteLine("Kullanıcı bulunamadı lütfen bilgilerinizi kontrol ediniz.");
            //}
            //else
            //{
            //    if (sifreler[index] == sifre)
            //    {
            //        Console.WriteLine("Hoşgeldiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Şifre hatalı");
            //    }
            //}

            #endregion

            #region RFID ile giriş işlemi

            //string[] kullaniciAdlari = { "Alp", "Samet", "Mevlüt", "Batuhan" };
            //string[] kartNolar = { "0490753442", "3758322375", "3122814980", "2971462090" };

            //while (true)
            //{
            //    Console.WriteLine("LÜTFEN KARTINIZI OKUTUNUZ.");
            //    string kartNo = Console.ReadLine();
            //    Console.Clear();

            //    int index = -1;


            //    for (int i = 0; i < kartNolar.Length; i++)
            //    {
            //        if (kartNolar[i] == kartNo)
            //        {
            //            index = i;
            //            break;
            //        }

            //    }
            //    if (index != -1)
            //    {
            //        Console.WriteLine("Merhaba " + kullaniciAdlari[index]);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş reddedildi.");
            //    }

            //}

            #endregion

            #region BEM Market

            string[] kullaniciAdlari = { "Alp", "Samet", "Mevlüt", "Batuhan","Elif","Eliff" };
            string[] kartNolar = { "0490753442", "3758322375", "3122814980", "2971462090", "3050693098","2858123268" };

            string[] urunler = { "Domates", "Karpuz", "Ekmek", "Yumurta", "Ayran", "Sosis", "Salam" };
            double[] fiyatlar = { 48, 12.5, 12, 4.15, 32, 65, 122.9 };
            string[] birimler = { "KG", "KG", "Adet", "Adet", "LT", "Paket", "Adet" };

            #endregion Indırım Kart İşlemi

            #region İndirim Kart İşlemi
            Console.WriteLine("İndirimlerden faydalanmak için BEM Kartınızı okutunuz. Kartsız devam etmek için ' Enter' tuşuna basınız");
            string kartNo = Console.ReadLine();

            int index = -1;
            for (int i = 0; i < kartNolar.Length; i++)
            {
                if (kartNolar[i] == kartNo)
                {
                    index = i;
                    break;
                }

            }
            string mesaj = "";
            if (index != -1)
            {
                Console.WriteLine("Hoşgeldin " + kullaniciAdlari[index]);
            }
            mesaj += "BEM Markete Hoşgeldiniz";
            Console.WriteLine(mesaj);

            #endregion

            #region Menü Yazdırma

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + urunler[i] + "\t " + birimler[i] + " \t" + fiyatlar[i] + " \tTL");

            }



            #endregion

            #region Ürün Satın Aldırma

            string islem = "e";
            double toplam = 0;
            while (islem == "e")
            {
                Console.WriteLine("Almak istediğiniz ürünün numarasını girinz =");
                int urunno = Convert.ToInt32(Console.ReadLine());
                int urunindex = urunno - 1;

                Console.WriteLine("Kaç " + birimler[urunindex] + " " + urunler[urunindex] + "alacaksınız?");
                int adet = Convert.ToInt32(Console.ReadLine());

                double urunfiyat = fiyatlar[urunindex];
                toplam = (urunfiyat * adet);

                Console.WriteLine("Alışverişe devam edilsin mi? e/h?");
                islem = Console.ReadLine();
            }

            #endregion

            #region Satış sonlandırma 

            if (index != -1)
            {

                double indirim = toplam * 0.1;
                Console.WriteLine("BEM Kart sahibi olduğunuz için " + indirim + " TL indirim kazandınız.");
                Console.WriteLine("Toplam = " + (toplam - indirim) + " TL");
            }
            else
            {
                Console.WriteLine("Toplam = " + toplam + " TL");
            }
            #endregion



        }
    }
}
