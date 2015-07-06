## 5.gün
   
   Stajımın 5.günü C# çalışmaya başladım,çeşitli örnekleri inceledim.
        
      Kaynak: <http://www.kemalkefeli.com/csharp-dersleri-icerik.html/>
              <https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/C_Sharp_hakk%C4%B1nda_temel_bilgiler/>
  
  **Operatörler**
  
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;
 
namespace ConsoleApplication1

{

    class Program
    
    {
        static void Main(string[] args)
        
        {
            int sonuc, a, b;
 
            //Aritmetik işlemler
            Console.WriteLine("Aritmetik İşlemler\n");
 
            sonuc = 4 * 3 / 2; //Öncelikler eşit olduğundan ilk görülen ilk yapılır
            Console.WriteLine(sonuc); //6
 
            sonuc = 2 + 8 / 4 - (3 * 2); //Önce parantez içi, sonra dört işlem önceliğine uyulur
            Console.WriteLine(sonuc); //-2
 
            a = 3;
            a = a + 1; //a değişkeninin değeri 1 arttı ve 4 oldu
            a += 1; //yine 1 arttı
            a++; //yine 1 arttı
            ++a; //yine 1 arttı, hepsi aynı anlama gelir
            Console.WriteLine(a); //7
 
            sonuc = 10 % 3; //10 sayısına mod 3 işlemi uygular
            Console.WriteLine(sonuc); //1
 
            a = 4;
            b = a++; //++ sağda ise önce atama yapılır sonra artırma yapılır
            Console.WriteLine("a: " + a + " b:" + b); //a=5, b=4
 
            a = 4;
            b = ++a; //++ solda ise önce artırma yapılır sonra atama yapılır
            Console.WriteLine("a: " + a + " b:" + b); //a=5, b=5
 
            //Karşılaştırma işlemleri
            Console.WriteLine("\nKarşılaştırma İşlemleri");
            bool sonuc2, sonuc3;
 
            sonuc2 = 50 > 45; //50 sayısı 45'ten büyüktür, doğru
            Console.WriteLine(sonuc2); //True (Doğru)
 
            sonuc = a << 1; //a'nın bitlerini bir sola kaydır, yani a'yı 2 ile çarp
            Console.WriteLine(sonuc); //4
 
            sonuc = a << 3; //a'nın bitlerini üç sola kaydır, yani a'yı 3 kez 2 ile çarp
            Console.WriteLine(sonuc); //32
 
            //Kaydırma işlemleri normal çarpma işlemine göre çok daha hızlıdır
            Console.ReadKey(); //Bir tuşa basana kadar sonuçların ekranda kalmasını sağlar
        }
    }
}

ÇIKTI: Aritmetik İşlemler 

       6
      -2
       7
       1
       a: 5 b: 4
       a: 5 b: 5 
       
       Karşılaştırma İşlemleri
       True 
       10
       40
       
--------------------------------

using System;

 class Operatorler
 
 {
 
 	static void Main()
 	
 	{
 		object i="50";
 		
 		string s=i as string;
 		
 		Console.Write(s);

   }
 }
 
     veya
     
 using System;
 
 class Operatorler
 
 {
 
 	static void Main()
 	
 	{
 	
 		int i=50;
 		
 		object s=i as object;
 		
 		Console.Write(s);
 	}
 }

ÇIKTI: 50
 ----------------------------------
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleApplication12

{

    class Program
    
    {
        static void Main(string[] args)
        
        {
            int i = 50;
            
            bool b1 = i is int;
            
            bool b2 = i is double;
            
            bool b3 = 12 is byte;
            
            bool b4 = 'c' is string;
            
            bool b5 = 12f + 7 is int;
            
            Console.Write("{0}\n{1}\n{2}\n{3}\n{4}", b1, b2, b3, b4, b5);
            
            Console.Read();
        }
    }
}

ÇIKTI: True

       False
       
       False
       
       False
       
       False
       
------------------------------------------

namespace ConsoleApplication12

{
    class Program
    
    {
        static void Main(string[] args)
        
        {
            bool b1 = 35 > 10 && 10 == 50;
            
            bool b2 = 35 > 10 && 10 != 50;
            
            bool b3 = 5 is int || 12 * 3 == 200;
            
            bool b4 = 5 < 4 || 45 / 5 == 9;
            
            bool b5 = !(5 < 4);
            
            Console.Write(b1 + " " + b2 + " " + b3 + " " + b4 + " " + b5);
            
            Console.Read();
        }
    }
}

ÇIKTI: False True True True True

--------------------------------

using System;

 class Operatorler
 
 {
 
 	static void Main()
 	
 	{
 		int a=0xff;
 	
 		int b=0Xff;
 		
 		Console.Write(a+" "+b);
 		
 	}
 	
 }
 
 ÇIKTI: 255 255
 
 -----------------------------------------------
 class Program
    {
        static void Main(string[] args)
        
        {
            byte b = 7, a = 1, c;
            
            c = a = b;
            
            Console.Write(a + " " + b+" "+c);
            
            Console.Read();
        }
        
    }
    
    ÇIKTI: 7 7 7
    
    -------------------------------------
    
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.Write("vikikitapı seviyor musunuz? (e,h):");
            
            string durum = Console.ReadLine();
            
            Console.Write(durum == "e" ? "Teşekkürler!!" : "Sağlık olsun...");
            
            Console.Read();
        }
        
    }
    
    ÇIKTI: vikikitabı seviyor musunuz? <e/h>: e
           Teşekkürler!!




 
**if else koşul yapısı**

int a = 3;

int b = 4;
 
if (a > b)

{
    Console.WriteLine("a sayısı b sayısından büyüktür.");
}

else if (a < b)

{
    Console.WriteLine("a sayısı b sayısından küçüktür.");
}

else

{
    Console.WriteLine("a sayısı b sayısına eşittir.");
}

ÇIKTI: a sayısı b sayısından küçüktür.

-----------------------

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleApplication12

{

    class Program
    
    {
        static void Main(string[] args)
        
        {
            int a = 5, b = 7;
            
            if(a<b)
            
            {
                Console.WriteLine("a b'den küçük");
                
                Console.Write(a);
            }
            
            else
            
            {
                Console.WriteLine("a b'den küçük değil");
                
                Console.Write(b);
            }
            
            Console.Read();
        }
    }
}

ÇIKTI: a b'den küçük

       5


**switch case**

int islem = 1;
 
switch (islem)

{
    case 1:
        Console.WriteLine("1");
        break;
        
    case 2:
        Console.WriteLine("2");
        break;
        
    case 3:
    
    case 4:
        Console.WriteLine("3-4");
        break;
        
    default:
        Console.WriteLine("Gecersiz");
        break;
}

   switch (değişken) tanımlamasındaki değişkenin değeri yazdığımız case değerleri ile kontrol ediliyor. Burada islem=1 olduğu için case 1 ifadesine girilecek ve ekrana 1 yazılacak ardından da break komutu ile switch den çıkılacak. Burda birkaç ekstra özellik var, kodda da göreceğiniz gibi case 3 durumunun kodu yok ve hemen altında case 4 tanımlanmış. Eğer böyle yazarsanız 3 ve 4 için aynı işlemi yap anlamına gelecektir. Bir diğer nokta da bir nevi hata kontrolü olarak da kullanılabilecek olan default anahtar kelimesi. Eğer değişkenin değeri yazdığımız case ifadeleri arasında bulunamazsa otomatik olarak default ifadesi çalıştırılacak. Yazmak zorunda değilsiniz elbette, yazmadığınız taktirde switch bloğu içerisinde hiçbir şey yapılmadan çıkılacaktır.

 **döngü yapıları**
 
 //----- FOR Döngüsü -----//
 
for (int i = 0; i < 5; i++)

{
    Console.WriteLine(i);
}
 
//----- WHILE Döngüsü -----//

int j = 0;

while (j < 5)

{
    Console.WriteLine(j);
    j++;
}
 
//----- FOREACH Döngüsü -----//

int[] array = new int[] { 0, 1, 2, 3, 4 };

foreach (int item in array)

{
    Console.WriteLine(item);
}

