 **döngü yapıları**
 <https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Ak%C4%B1%C5%9F_kontrol_mekanizmalar%C4%B1/>
 <http://www.kodlamamerkezi.com/c-net/c-for-dongusu-ornekler-ile-detayli-anlatim/>
 <http://www.kemalkefeli.com/csharp-dersleri-icerik.html/>
 
 //----- FOR Döngüsü -----//
 
 class Program
 
    {
        static void Main(string[] args)
        
        {
            int toplam = 0;
            
            for (int i = 1; i <= 3; i++)
            
                toplam += i;
                
            Console.Write("toplam={0}", toplam);

                Console.Read();
        }
    }
    
    ÇIKTI: toplam=6
    ---------------------------------------------------------
    static void Main(string[] args)
        {
            float s;
            
            int si, f;
            
            bool a = true;
            
            for (; a; )
            
            {
                Console.Write("lütfen faktoriyelinin alınmasını istediğininz sayıyı girin:");
                
                s = Convert.ToSingle(Console.ReadLine());
                
                si = (int)s;
                
                if(si!=s || s<1)
                
                {
                    Console.WriteLine("lütfen pozitif tamsayı girin:");
                    
                    a = true;
                }
                
                else
                
                {
                    a = false;
                    
                    for (f = 1; si > 1; si--)
                    
                        f *= si;
                        
                    Console.Write("faktoriyeli:{0}", f);
                }
            }

                Console.Read();
                
 ÇIKTI:   lütfen faktoriyelinin alınmasını istediğininz sayıyı girin:3
 
          faktoriyeli:6
          
 ---------------------------------------------------------
 Aşağıdaki program klavyeden girilen 5 adet sayıyı küçükten büyüğe doğru sıralar.

    class Program
    {
        static void Main(string[] args)
        
        {
            int[] dizi = new int[5];
            
            for (int i = 0; i < 5;i++ )
            
            {
                Console.Write((i + 1) + ".sayı giriniz:");
                
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Sort(dizi);
            
            Console.WriteLine("--------------------");

            for (int i = 0; i < 5;i++ )
            
            {
                Console.WriteLine(dizi[i]);
            }


                Console.Read();
        }
    }
    
ÇIKTI: 1.sayı giriniz:6

       2.sayı giriniz:2
       
       3.sayı giriniz:3
       
       4.sayı giriniz:5
       
       5.sayı giriniz:1
       
        ------
        
       1
       
       2
       
       3
       
       5
       
       6
 -------------------------------
 
    class Program
    
    {
        static void Main(string[] args)
        
        {
               for(int a=0;a<7;a++)
               
               {
                   if (a % 2 == 1)
                   
                       continue;
                       
                   Console.WriteLine(a);

                   Console.Read();
               }
         }
     }
ÇIKTI: 0

       2
       
       4
       
       6
       
       continue: döngünün o anki iterasyonu sonlanır.
       
//----- WHILE Döngüsü -----//

int j = 0;

while (j < 5)

{
    Console.WriteLine(j);
    j++;
}
 
//----- FOREACH Döngüsü -----//

   foreach sadece dizilere uygulanabilen bir döngü yapısıdır.Kullanımı şu şekildedir:

int[] array = new int[] { 0, 1, 2, 3, 4 };

foreach (int item in array)

{
    Console.WriteLine(item);
}


   foreach döngüsüyle dizi elemanlarının değerini değiştiremeyiz, sadece ekrana yazdırmak gibi işler yapabiliriz.

Örnekler:

- 1'den 55'e kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program.

namespace ConsoleApplication13

{
    class Program
    
    {
        static void Main(string[] args)
        
        {
            int toplam = 0, sayi = 0, i = 5;
            
            for(;i<55;i+=5)
            
            {
                if (i % 35 == 0)
                
                    continue;
                    
                sayi++;
                
                toplam += i;
                
                Console.WriteLine(i);
                
            }
            Console.WriteLine("Sayısı: " + sayi);
            
            Console.WriteLine("Toplam: " + toplam);
            
            Console.ReadLine();
            
         }
     }
}

ÇIKTI: 5

       10
       
       15
       
       20
       
       25
       
       30
       
       35
       
       40
       
       45
       
       Sayısı:9
       
       Toplam:240
       
- Girilen pozitif herhangi bir tamsayıyı ikilik düzene çeviren program.

static void Main(string[] args)

 {
      string mod = " ";
            
      Console.Write("sayıyı giriniz:");
      
      float a = Convert.ToSingle(Console.ReadLine());
      
      int b = (int)a;
      
      if (a <= 0 || a != b)
                
          mod = "pozitif tamsayı girmediğiniz için sayı ikilik sisteme dönüştürülemedi";
          
      else
      
          for (; b > 0; b /= 2)
          
                    mod = b % 2 + mod;
                    
       Console.Write(mod);
       
       Console.ReadLine();
       
  }
  
ÇIKTI: sayıyı giriniz:5
      
       101
       
- Konsol ekranına girilen 0 ile 100 arasındaki 3 notun en büyüğünü, en küçüğünü ve ortalamasını yazan program

 static void Main(string[] args)
 
 {
    int eb = 0, toplam = 0, ek = 0;
    
    for(int a=0,b;a<3;a++)
    
    {
       
        Console.Write(a + 1 + ".notu giriniz:");
                
        b = Convert.ToInt32(Console.ReadLine());
                
        if(b>100 || b<0)
               
         {
                    
             Console.Write("yanlış not girdiniz.Tekrar giriniz:");
                    
             a--;
                    
             continue;
             
         }
         
         if(a==0)
         
         {
                    
             eb = b;
                    
             ek = b;
                
          }
          
          else
          
          {
                    
             if (b >eb)
                        
             eb = b;
                    
             if (b < ek)
                        
             ek = b;
                
           }
           
            toplam += b;
            
        }
        
      Console.Write("En büyük: {0}\nEn küçük: {1}\nOrtalama: " + toplam / 10, eb, ek);
                    
      Console.ReadLine();
         
 }
 
 ÇIKTI: 1.notu giriniz:34
  
        2.notu giriniz:56
        
        3.notu giriniz:88
        
        En büyük:88
        
        En küçük:34
        
        Ortalama:17
        
           
 **Diziler**

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

   **Console.Write** komutu ekrana yazı basmamızı sağlayan komuttur. Burada kullanıcıya tarih girmesini söylüyoruz. Bir alt satırda string tipinde bir değişken tanımlıyoruz ve kullanıcının girmiş olduğu değeri **Console.ReadLine** komutu yardımıyla bu değişkene atıyoruz.Split fonksiyonu parametre olarak bir karakter veya kelime alır. Aldığı parametreyi string değişken içinde arar ve bulduğu her noktadan bölüp, parçalarından bir dizi oluşturur.DateTime nesnesi tarih bilgilerini tutmamızı sağlar.
     
     **Console.ReadKey** satırını koymazsak, program çalışır ve sonlandığı anda hemen kapanır, ekrandaki değerleri göremeyiz. Bu satırı yazdığımızda, program çalışmasını bitirecek ve bu satıra geldiğinde bir tuşa basılmasını bekleyecek, dolayısıyla biz de ekranda yazılanları okuyabileceğiz.
     
     Dizi metotları ise önceden yazılmış, belirli işlemleri yapmaya yarayan kod bloklarıdırlar. Mesela elinizde bir sayı dizisi var ve sayıları sıralamak istiyorsunuz. Sort() metodunu kullanabilirsiniz.Bu metodları herhangi bir dizi değişkeninin sonuna "." koyduktan sonra yazabilirsiniz.
     
-	CopyTo: Bir dizinin bir bölümünü veya tamamını başka bir diziye kopyalamanızı sağlar.

-	GetLength: Dizinin uzunluğunu verir.
             x.GetLength(y) şeklinde kullanılır. Herhangi bir dizinin eleman sayısını int olarak tutar. x diziyi, y o dizinin hangi boyutunun eleman sayısının hesaplanacağını belirtir.

Örnek:

 int[][] dizi=new int[3][];
 
 dizi[0]=new int[]{1,2,3};
 
 dizi[1]=new int[]{4,5,6,7};
 
 dizi[2]=new int[]{8,9};
 
 for(int i=0;i<dizi.GetLength(0);i++)
 
   for(int j=0;j<dizi[i].GetLength(0);j++)
   
      Console.WriteLine("dizi[{0}][{1}]={2}",i,j,dizi[i][j]);
      
----> dizinin bütün elemanlarını teker teker ekrana yazar.

-	SetValue: Dizi içerisindeki herhangi bir alana değer atamanızı sağlar.

     Değişkenin sonuna "." koyarak çağırabileceğiniz bu metotlar dışında, diziler için genel olarak tasarlanan başka metotlar da vardır. Bu metotları ise "Array." diyerek çağırabilirsiniz.
     
-	BinarySearch: Verilen dizi içerisinde istediğiniz bir elemanı arar.

-	Clear: Dizinin elemanlarının bir kısmını veya tamamını silmenizi yani varsayılan değere çekmenizi sağlar.

Array.Clear(dizi,1,3);

   Bu kod dizi dizisinin 1. indeksinden itibaren 3 indeksini sıfırlar (varsayılan değere döndürür).

-	IndexOf: Aradığınız bir değerin dizinin kaçıncı elemanı olduğunu öğrenmenizi sağlar (birden fazla varsa ilkini söyler).

-	LastIndexOf: Aradığınız bir değerin dizinin kaçıncı elemanı olduğunu öğrenmenizi sağlar (birden fazla varsa sonuncusunu söyler).

-	Reverse: Diziyi tersine çevirir. İlk eleman artık son eleman olur.

 Array.Reverse(dizi,1,3);

     Bu kod dizi dizisinin 1. indeksten itibaren 3 elemanını ters çevirir.

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
       
//--- Dizileri Kopyalamak---//

int[] dizi1={1,2,3,4};

int[] dizi2=new int[10];
 
dizi1.CopyTo(dizi2,3);

     Burada dizi1'in tüm elemanları dizi2'ye 3. indeksten itibaren kopyalanıyor.

int[] dizi1={1,2,3,4};

int[] dizi2=new int[10];
 
Array.Copy(dizi1,dizi2,3);

     Burada 3 tane eleman dizi1'den dizi2'ye kopyalanır. Kopyalama işlemi 0. indeksten başlar.
     
 int[] dizi1={1,2,3,4,5,6,7};
 
 int[] dizi2=new int[10];
 
 Array.Copy(dizi1,2,dizi2,7,3);

       Burada dizi1'in 2. indeksinden itibaren 3 eleman, dizi2'ye 7. indeksten itibaren kopyalanıyor.  
      
//---Dizileri Sıralama---//
       
static void Main(string[] args)
        
{
    Array sayisal = Array.CreateInstance(typeof(int), 8);
            
    sayisal.SetValue(200, 0);
            
    sayisal.SetValue(10, 1);
            
    sayisal.SetValue(6, 2);
            
    sayisal.SetValue(4, 5);
            
    Console.WriteLine("sırasız dizi:");
            
    foreach (int sayi in sayisal)
                
    Console.Write(sayi + " ");
            
    Console.WriteLine("\n\nsıralı dizi:");
            
    Array.Sort(sayisal);
            
    foreach (int sayi in sayisal)
                
    Console.Write(sayi + " ");
                    
    Console.ReadLine();
         
}

ÇIKTI: sırasız dizi:

       200 10 6 0 0 4 0 0 
       
       sıralı dizi:
       
       0 0 0 0 4 6 10 200
       
//---Dizilerde Arama---//

using System;

 class Diziler
 
 {
    
    static void Main()
    
    {
       
       string[] dizi={"ayşe","osman","ömer","yakup","meltem","rabia","mahmut","zafer","yılmaz","çağlayan"};
       
       Array.Sort(dizi);
       
       Console.Write(Array.BinarySearch(dizi,3,4,"yakup"));
    
    }
 
 }

ÇIKTI: -8

    BinarySearch burada 3. indeksten itibaren 4 eleman içinde "yakup"u arar. Bulursa indeksini tutar. Bulamazsa negatif bir sayı tutar.
    
UYARI: Yalnızca tek boyutlu diziler Sort ile sıralanabilir, dolayısıyla da çok boyutlu dizilerde hem Sort ile sıralama hem de BinarySearch ile arama yapmak imkansızdır.
