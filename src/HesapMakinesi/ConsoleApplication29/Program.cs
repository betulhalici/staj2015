﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1, s2,islem;
            double sayi1, sayi2,sonuc=0;

            Console.Write("ilk sayıyı girin:");
            s1 = Console.ReadLine();
            Console.Write("ikinci sayıyı girin:");
            s2 = Console.ReadLine();

            sayi1 = Convert.ToDouble(s1);
            sayi2 = Convert.ToDouble(s2);
            Console.WriteLine("\n1-toplama\n2-çıkarma\n3-çarpma\n4-bölme\n\n islemi seciniz: ");
            islem = Console.ReadLine();

            switch(islem)
            {
                case "1":
                    sonuc = sayi1 + sayi2;
                    break;

                case "2":
                    sonuc = sayi1 - sayi2;
                    break;

                case "3":
                    sonuc = sayi1 * sayi2;
                    break;

                case "4":
                    sonuc = sayi1 / sayi2;
                    break;

                default:
                    Console.WriteLine("hatalı secim");
                    break;
            }
            Console.Write("\nSonuç: " + sonuc);
            Console.ReadLine();
            
        }
    }
}
