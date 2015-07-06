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

**diziler**

//Birinci tanımlama şekli

int[] dizi;

dizi = new int[20];
 
//İkinci tanımlama şekli

int[] dizi2 = new int[20];
 
//Birinci ve ikinci tanımlama için değer ataması

dizi2[0] = 50;

dizi2[1] = 60;

//20 değeri de bu şekilde tanımlayabiliriz
 
//Üçüncü tanımlama şekli ve değer ataması

int[] dizi3 = new int[5] { 10, 20, 30, 40, 50 };
 
//Dördüncü tanımlama şekli ve değer ataması

int[] dizi4 = { 10, 20, 30, 40, 50 };

    For döngüsü kullanarak, dizi içeriğini ekrana şu şekilde basabiliriz:

for (int i = 0; i < dizi4.Length; i++)

{
    Console.Write(dizi4[i] + " ");
}

Programın amacı şu olsun: kullanıcıdan bir tarih alalım, daha sonra bu string tipindeki tarihi gerçek bir tarih nesnesine dönüştürüp bir ay sonrasını ekrana basalım.

using System;

namespace ConsoleApplication2

{

    class Program
    
    {
        static void Main(string[] args)
        
        {
            Console.Write("Lütfen tarih giriniz (ör: 29.08.1990): ");
            
            string kullaniciGirisi = Console.ReadLine();
 
            string[] tarihBilesenleri = kullaniciGirisi.Split('.');
 
            DateTime tarihNesnesi = new DateTime(Convert.ToInt32(tarihBilesenleri[2]),
                                                 Convert.ToInt32(tarihBilesenleri[1]),
                                                 Convert.ToInt32(tarihBilesenleri[0]));
 
            Console.WriteLine(tarihNesnesi.AddMonths(1).ToShortDateString());
            Console.ReadKey();
        }
    }
}

   **Console.Write** komutu ekrana yazı basmamızı sağlayan komuttur. Burada kullanıcıya tarih girmesini söylüyoruz. Bir alt satırda string tipinde bir değişken tanımlıyoruz ve kullanıcının girmiş olduğu değeri **Console.ReadLine** komutu yardımıyla bu değişkene atıyoruz.Split fonksiyonu string tipindeki değişkenlere uygulanabilir. Parametre olarak bir karakter veya kelime alır. Aldığı parametreyi string değişken içinde arar ve bulduğu her noktadan bölüp, parçalarından bir dizi oluşturur.
     DateTime nesnesi tarih bilgilerini tutmamızı sağlar. Aslında gün, ay, yıl, saat, dakika, saniye gibi değerlerin tümünü içerisinde barındıran bir tiptir.Bu tarih nesnesi, tarih ile alakalı bir çok işlemde bize yardımcı olacaktır. Yeni bir tarih nesnesi tanımlıyoruz ve değer olarak da kullanıcının girmiş olduğu tarihi vermeye çalışacağız. new DateTime(Yil, Ay, Gun)şeklinde tanımlama yapıyoruz. Yalnız buradaki yıl, ay ve gün değişkeni normalde int tipinde olması lazım; ancak bizim elimizde string dizisi olduğu için her bir değeri int tipine dönüştürmemiz gerek. Bu noktada Convert.ToInt32 metodunu kullanıyoruz.Convert.ToInt32(tarihBilesenleri[2]) diyerek, tarihBilesenleri dizisinin 3. elemanını alıp, Convert metodu ile string tipinden int tipine dönüştürüyoruz. Aynı şekilde ay ve günü de dönüştürüyoruz.
     En alttaki Console.ReadKey satırını koymazsak, program çalışır ve sonlandığı anda hemen kapanır, ekrandaki değerleri göremeyiz. Bu satırı yazdığımızda, program çalışmasını bitirecek ve bu satıra geldiğinde bir tuşa basılmasını bekleyecek, dolayısıyla biz de ekranda yazılanları okuyabileceğiz.
     
     Dizi metotları ise önceden yazılmış, belirli işlemleri yapmaya yarayan kod bloklarıdırlar. Mesela elinizde bir sayı dizisi var ve sayıları sıralamak istiyorsunuz. Sort() metodunu kullanabilirsiniz.Bu metodları herhangi bir dizi değişkeninin sonuna "." koyduktan sonra yazabilirsiniz.
     
-	CopyTo: Bir dizinin bir bölümünü veya tamamını başka bir diziye kopyalamanızı sağlar.

-	GetLength: Dizinin uzunluğunu verir.

-	SetValue: Dizi içerisindeki herhangi bir alana değer atamanızı sağlar.

     Değişkenin sonuna "." koyarak çağırabileceğiniz bu metotlar dışında, diziler için genel olarak tasarlanan başka metotlar da vardır. Bu metotları ise "Array." diyerek çağırabilirsiniz.
     
-	BinarySearch: Verilen dizi içerisinde istediğiniz bir elemanı arar.

-	Clear: Dizinin elemanlarının bir kısmını veya tamamını silmenizi yani varsayılan değere çekmenizi sağlar.

-	IndexOf: Aradığınız bir değerin dizinin kaçıncı elemanı olduğunu öğrenmenizi sağlar (birden fazla varsa ilkini söyler).

-	LastIndexOf: Aradığınız bir değerin dizinin kaçıncı elemanı olduğunu öğrenmenizi sağlar (birden fazla varsa sonuncusunu söyler).

-	Reverse: Diziyi tersine çevirir. İlk eleman artık son eleman olur.

-	Sort: Diziyi sıralar.

using System;
 
namespace Ders7

{

    class Program
    
    {
        static void Main(string[] args)
        
        {
            int[] dizi = new int[] { 3, 4, 1, 2 };
            
            dizi.GetLength(0); // Tek boyutlu diziler için 0 yazılır. Sonuç: 4
            
            dizi.SetValue(5, 3); // "2" değerini "5" olarak değiştirir.
 
            int sira = Array.IndexOf(dizi, 1); // dizi içerisinde "1" elemanının sırasını söyler. Sonuç: 2
            
            Console.WriteLine(sira); // 2
 
            Array.Reverse(dizi); // Diziyi tersine çevirir. Sonuç: 5, 1, 4, 3
            
            Array.Sort(dizi); // Diziyi küçükten büyüğe sıralar. Sonuç: 1, 3, 4, 5
 
            //dizi'nin son halini yazdıralım... 1,3,4,5 olmasını bekliyoruz
            
            for (int i = 0; i < dizi.GetLength(0); i++)
            
            {
                Console.Write(dizi[i] + " ");
            }
 
            Console.ReadKey();
        }
    }
}

ÇIKTI: 2

       1 3 4 5
