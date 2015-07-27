using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        const string İslemToplama = "1";
        const string İslemCikarma = "2";
        const string İslemCarpma = "3";
        const string İslemBolme = "4";
        const string İslemBitir = "5";
        
        static double SayiGirisi(string soru)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(soru);
                    string kullaniciGirisi = Console.ReadLine();
                    return Convert.ToDouble(kullaniciGirisi);
                }
                catch (Exception)
                {
                }
            }
        }
        static string İslemSec()
        {
            Console.WriteLine("\n1-toplama\n2-çıkarma\n3-çarpma\n4-bölme\n5-çıkış\n");
            Console.WriteLine("İşlemi seçiniz:");
            return Console.ReadLine();
        }

        static void İslemYap(string islem, double sayi1, double sayi2)
        {
            switch (islem)
            {
                case İslemToplama:
                    Console.WriteLine("Toplama: {0}", Toplama(sayi1, sayi2));
                    break;

                case İslemCikarma:
                    Console.WriteLine("Çıkarma: {0}", Çıkarma(sayi1, sayi2));
                    break;

                case İslemCarpma:
                    Console.WriteLine("Çarpma: {0}", Çarpma(sayi1, sayi2));
                    break;

                case İslemBolme:
                    Console.WriteLine("Bölme: {0}", Bölme(sayi1, sayi2));
                    break;
            }
        }
        static double Toplama(double sayi1, double sayi2)
        {
            var toplama = sayi1 + sayi2;
            return toplama;
        }

        static double Çıkarma(double sayi1, double sayi2)
        {
            var çıkarma = sayi1 - sayi2;
            return çıkarma;
        }

        static double Çarpma(double sayi1, double sayi2)
        {
            var çarpma = sayi1 * sayi2;
            return çarpma;
        }

        static double Bölme(double sayi1, double sayi2)
        {
            var bölme = sayi1 / sayi2;
            return bölme;
        }

        static void Main(string[] args)
        {
            string islem;
            do
            {
                var sayi1 = SayiGirisi("ilk sayıyı girin:");
                var sayi2 = SayiGirisi("ikinci sayıyı girin:");
                
                islem = İslemSec();

                İslemYap(islem, sayi1, sayi2);
                
             } while (islem != "5");
        }
    }
}

