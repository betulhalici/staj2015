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
        static double SayiGirisi(string soru)
        {
           for(; ;)
           {
               try
               {
                  Console.WriteLine(soru);
                  string kullaniciGirisi=Console.ReadLine();
                  return Convert.ToDouble(kullaniciGirisi);
                }
                catch(Exception)
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
                case "1":
                    Console.WriteLine("Toplama: {0}", Toplama(sayi1, sayi2));
                    break;

                case "2":
                    Console.WriteLine("Çıkarma: {0}", Çıkarma(sayi1, sayi2));
                    break;

                case "3":
                    Console.WriteLine("Çarpma: {0}", Çarpma(sayi1, sayi2));
                    break;

                case "4":
                    Console.WriteLine("Bölme: {0}", Bölme(sayi1, sayi2));
                    break;
            }
        }
        static double Toplama(double sayi1, double sayi2)
        {
            double toplama = sayi1 + sayi2;
            return toplama;
        }

        static double Çıkarma(double sayi1, double sayi2)
        {
            double çıkarma = sayi1 - sayi2;
            return çıkarma;
        }

        static double Çarpma(double sayi1, double sayi2)
        {
            double çarpma = sayi1 * sayi2;
            return çarpma;
        }

        static double Bölme(double sayi1, double sayi2)
        {
            double bölme = sayi1 / sayi2;
            return bölme;
        }
         
        static void Main(string[] args)
        {
            int n = 0;
            string islem;
            double sayi1 = 0.0, sayi2 = 0.0;

            do
            {
                sayi1=SayiGirisi("ilk sayıyı girin:");
                sayi2=SayiGirisi("ikinci sayıyı girin:");
               
                islem = İslemSec();

               if (islem == "27")
                    break;

               İslemYap(islem, sayi1, sayi2);
            } while (n != 27);
        }
    }
}

