using System;

namespace ornek_uygulama_dort_islem
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim = "";
            do
            {
                MenuYaz();
                secim = Console.ReadLine();
                İslemBaslat(secim);
            } while (secim == "1" || secim == "2" || secim == "3" || secim == "4" || secim == "5");

        }
        static void MenuYaz()
        {
            Console.Clear();

            Console.WriteLine("[1] Toplama");
            Console.WriteLine("[2] Çıkarma");
            Console.WriteLine("[3] Çarpma");
            Console.WriteLine("[4] Bölme");
            Console.WriteLine("[5] Sonuç");
            Console.WriteLine("");
            Console.WriteLine("Lütfen işlem numarasını giriniz.");
        }
        public static string İslemBaslat(string secim)
        {
            switch (secim)
            {
                case "1":
                    ToplamaYap();
                    break;
                case "2":
                    CikarmaYap();
                    break;
                case "3":
                    CarpmaYap();
                    break;
                case "4":
                    BolmeYap();
                    break;
                case "5":
                    CikisYap();
                    break;
                default:
                    MenuYaz();
                    break;
            }
            return secim;
        }

        static string CikisYap()
        {
            return "6";
        }

        public static string SonucYaz(string sonucMetni)
        {

            Console.WriteLine("");
            Console.WriteLine("Sonuç: " + sonucMetni);

            Console.WriteLine("");
            Console.Write("Devam emek için bir tuşa basınız...");
            Console.ReadKey();
            return null;
        }
        static void İslemBaslıgıYaz(string baslik)
        {
            Console.Clear();
            
            Console.WriteLine(baslik);
             
            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("");
            Console.WriteLine("");

        }
        static int SayiAl(string KacinciSayi)
        {
            Console.WriteLine(KacinciSayi + ". Sayı Giriniz.");
            int sayi = int.Parse(Console.ReadLine());

            return sayi;
        }
        static void ToplamaYap()
        {
            // Toplama Yapılcak 

            İslemBaslıgıYaz("TOPLAMA İŞLEMİ");

            int sayi1 = SayiAl("1");
            int sayi2 = SayiAl("2");

            int sonuc = sayi1 + sayi2;
            SonucYaz(sonuc.ToString());
        }
        static void CikarmaYap()
        {
            //  Çıkarma Yapılcak

            İslemBaslıgıYaz("ÇIKARMA İŞLEMİ");

            int sayi1 = SayiAl("1");
            int sayi2 = SayiAl("2");

            int sonuc = sayi1 + sayi2;
            SonucYaz(sonuc.ToString());
        }
        static void CarpmaYap()
        {
            // Çarpma Yapılcak 

            İslemBaslıgıYaz("ÇARPMA İŞLEMİ");

            int sayi1 = SayiAl("1");
            int sayi2 = SayiAl("2");

            int sonuc = sayi1 * sayi2;
            SonucYaz(sonuc.ToString());
        }
        static void BolmeYap()
        {
            // Bölme Yapılcak 

            İslemBaslıgıYaz("BÖLME İŞLEMİ");

            int sayi1 = SayiAl("1");
            int sayi2 = SayiAl("2");

            int sonuc = sayi1 / sayi2;
            SonucYaz(sonuc.ToString());
        }
}   }


