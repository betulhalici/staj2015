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
        static void Main(string[] args)
        {
            int n = 0;
            string s1, s2, islem;
            double sayi1 = 0.0, sayi2 = 0.0, sonuc = 0;

            do
            {
                for (; ; )
                {
                    try
                    {
                        Console.Write("ilk sayıyı girin:");
                        s1 = Console.ReadLine();
                        sayi1 = Convert.ToDouble(s1);
                        break;
                    }

                    catch (Exception)
                    {
                        continue;
                    }
                 }

                for (; ; )
                {
                    try
                    {
                        Console.Write("ikinci sayıyı girin:");
                        s2 = Console.ReadLine();
                        sayi2 = Convert.ToDouble(s2);
                        break;
                     }

                    catch (Exception)
                    {
                        continue;
                    }
               
                }

                Console.WriteLine("\n1-toplama\n2-çıkarma\n3-çarpma\n4-bölme\n5-çıkış\n");

                Console.WriteLine("İşlemi seçiniz:");
                islem = Console.ReadLine();

                if (islem == "27")
                    break;

                switch (islem)
                {
                    case "1":
                        sonuc = sayi1 + sayi2;
                        Console.Write("{0}+{1}={2}\n", sayi1, sayi2, sonuc);
                        Console.ReadLine();
                        break;

                    case "2":
                        sonuc = sayi1 - sayi2;
                        Console.Write("{0}-{1}={2}\n", sayi1, sayi2, sonuc);
                        Console.ReadLine();
                        break;

                    case "3":
                        sonuc = sayi1 * sayi2;
                        Console.Write("{0}*{1}={2}\n", sayi1, sayi2, sonuc);
                        Console.ReadLine();
                        break;

                    case "4":
                        sonuc = sayi1 / sayi2;
                        Console.Write("{0}/{1}={2}\n", sayi1, sayi2, sonuc);
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("hatalı secim");
                        break;
                }

            } while (n != 27);
            Console.ReadLine();
          }
      }
 }

