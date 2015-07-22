######Hesap Makinesi Programı

   Programı biraz daha geliştirmem istendi.Örneğin; ekrana Sonuç=1 yazmak yerine 2/2=1 şeklinde yazan,bir de benden sürekli sayı girişi isteyen program aşağıdaki gibidir:

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace HesapMakinesi

{
    class Program

    {

        static void Main(string[] args)

        {

            string s1, s2,islem;

            double sayi1, sayi2,sonuc=0;

            int n=0;

            do
            {

                Console.Write("ilk sayıyı girin:");

                s1 = Console.ReadLine();

                Console.Write("ikinci sayıyı girin:");

                s2 = Console.ReadLine();

                sayi1 = Convert.ToDouble(s1);

                sayi2 = Convert.ToDouble(s2);

                Console.WriteLine("\n1-toplama\n2-çıkarma\n3-çarpma\n4-bölme\n5-çıkış\n");

                Console.WriteLine("İşlemi seçiniz:");

                islem = Console.ReadLine();

                if (islem == "27")

                    break;

                switch (islem)

                {

                    case "1":

                        sonuc = sayi1 + sayi2;

                        Console.Write("{0}+{1}={2}",sayi1,sayi2,sonuc);

                        Console.ReadLine();

                        break;

                    case "2":

                        sonuc = sayi1 - sayi2;

                        Console.Write("{0}-{1}={2}", sayi1, sayi2, sonuc);

                        Console.ReadLine();

                        break;

                    case "3":

                        sonuc = sayi1 * sayi2;

                        Console.Write("{0}*{1}={2}", sayi1, sayi2, sonuc);

                        Console.ReadLine();

                        break;

                    case "4":

                        sonuc = sayi1 / sayi2;

                        Console.Write("{0}/{1}={2}", sayi1, sayi2, sonuc);

                        Console.ReadLine();

                        break;

                    default:

                        Console.WriteLine("hatalı secim");

                        break;
                }
              
            } while (n !=27);
            
        }
    }
}

ÇIKTI: ilk sayıyı girin: 1

       ikinci sayıyı girin: 2
       
       1-toplama
       
       2-çıkarma
       
       3-çarpma
       
       4-bölme
         
         islemi seçiniz: 1
         
       1+2=3
       
       ilk sayıyı girin: 2

       ikinci sayıyı girin: 2
       
       1-toplama
       
       2-çıkarma
       
       3-çarpma
       
       4-bölme
         
         islemi seçiniz: 4
         
       2/2=1
       
          enter'a bastıkça bu şekilde ilerliyor,işlemi seçinizde 27'ye basana kadar.
