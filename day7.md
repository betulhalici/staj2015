**Metodlar ve Fonksiyonlar**

<http://www.kemalkefeli.com/csharp-dersleri-icerik.html/>

<https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Metotlar/>

   Metot, sadece belirli bir işi yapan küçük programcıklardır. 

//---Metot Oluşturma ve Kullanımı---//

int MetotAdi(int a,int b)
{
   return a+b;
}
 
   Bu metod 2 tane int girdi alır ve bu girdilerin toplamını int türünden tutar. Ancak bu metodu programımız içinde kullanabilmemiz için bu metodun içinde bulunduğu sınıf türünden bir nesne oluşturup "." operatörüyle bu nesne üzerinden metodumuza erişmeliyiz.
   
using System;

 class Metotlar
 
 {
    int Topla(int a,int b)
    
    {
    
       return a+b;
     
   }
   
    static void Main()
    
    {
    
       Metotlar nesne=new Metotlar();
       
       int a=nesne.Topla(2,5);
       
       Console.Write(a);
    
    }
 
 }
 
  ÇIKTI: 7
 
- static olarak tanımlanan metotlara erişmek için metodun içinde bulunduğu sınıf türünden bir nesne oluşturmaya gerek yoktur. static olarak tanımlanan metotlara sadece metodun adını yazarak erişilebilir.

using System;

 class Metotlar
 
 {
    
    static int Topla(int a,int b)
    
    {
    
       return a+b;
       
    }
    
    static void Main()
    
    {
       int a=Topla(2,5);
       
       Console.Write(a);
    }
 }

•	Bütün programlarda önce Main metodu çalışır. Diğer metotlar Main metodunun içinden çağrılmadıkça çalışmaz.

•	Eğer metot, içinde bulunduğumuz sınıfta değil de, başka bir sınıf içinde yaratılmışsa o metodu kullanabilmek için önce sınıfı yazmamız gerekir.

using System;

 class Metotlar1
 
 {
    public static int Topla(int a,int b)
    
    {
       return a+b;
    }
 }
 
 class Metotlar2
 
 {
 
    static void Main()
    
    {
    
       int a=Metotlar1.Topla(2,5);
       
       Console.Write(a);
    }
 }

  public derleyiciye bu metoda her sınıftan erişilebileceğini söylüyor.
  
•static olmayan bir metodu başka bir sınıf içinde oluşturma:

using System;

 class Metotlar1
 
 {
    public int Topla(int a,int b)
    
    {
       return a+b;
    }
 }
 
 class Metotlar2
 {
    static void Main()
    
    {
       Metotlar1 nesne=new Metotlar1();
       
       int a=nesne.Topla(3,9);
       
       Console.Write(a);
    }
    
 }

•	Bütün değer tutan metotlar bir değermiş gibi kullanılabilir, ancak değişkenmiş gibi kullanılamaz.

•	Herhangi bir değer tutmayan (WriteLine gibi) metotları void anahtar sözcüğüyle oluştururuz.

using System;

 class Metotlar1
 
 {
    static void Yaz(object a,int b)
    
    {
       for(;b>0;b--)
       
          Console.Write(a);
    }
    
    static void Main()   
    
    {
       Yaz("deneme",5);
    }
    
 }

ÇIKTI: denemedenemedenemedenemedeneme

Örnek: Faktöriyel hesaplayan metot.

  static void Main(string[] args)
  {
      Console.WriteLine("n değerini girin: ");  //Permutasyon hesaplama P(n,r)
      
      int n = Convert.ToInt32(Console.ReadLine());
 
      Console.WriteLine("r değerini girin: ");
      
      int r = Convert.ToInt32(Console.ReadLine());
 
      double permutation = CalculateFactorial(n) / CalculateFactorial(n - r);  //P(n,r)=n!/(n-r)!
 
      Console.WriteLine("Sonuç: " + permutation);
            
      Console.ReadKey();
        
  }
 
  static double CalculateFactorial(int value)
  
  {
      double result = 1;
      
      for (int i = value; i > 0; i--)
      
      {
          result *= i;
      }
      
      return result;
  }
  
//---Metotlarla ilgili önemli özellikler---//
  
•	Metotları kullanırken parametrelerini doğru sayıda, doğru sırada ve doğru türde vermeliyiz.

•	Değer tutan metotlarda return satırıyla belirtilen ifade, metodu yaratırken verilen türle uyumlu olmalıdır.

•	Değer tutmayan (void ile belirtilmiş) metotlarda return komutunun herhangi bir ifadeyle kullanılması yasaktır.

•	Değer tutmayan metotların bir değermiş gibi kullanılması yasaktır.

•	Metotlar değer tutmayabileceği gibi, parametre de almayabilirler.

//---Metot parametresi olarak diziler---//

using System; 

 class Metotlar1
 
  {   
  
    static void Yaz(int[] dizi)   
    
    {                                              
          foreach(int i in dizi)             ÇIKTI: 1
                                                    2
          Console.WriteLine(i);                     4
    }                                               7
                                                    9
    static void Main()
    
    {
          int[] dizi={1,2,4,7,9};
          
          Yaz(dizi);
    }
 }
 
//---Dizi ve değişken parametreler arasındaki fark---//

Aşağıdaki iki programı karşılaştıralım:

 using System;
 
 class Metotlar1
 
 {
   static void Degistir(int[] dizi)
   
   {                                          
         for(int i=0;i<5;i++)  
                                                          ÇIKTI: 10
             dizi[i]=10;                                         10
   }                                                             10
                                                                 10
   static void Yaz(Array dizi)                                   10
   
   {
         foreach(object a in dizi)
         
             Console.WriteLine(a);
   }
   
   static void Main()
   
   {
         int[] dizi={1,2,4,7,8};
         
         Degistir(dizi);
         
         Yaz(dizi);
   }
   
 }
---------------------------------------
using System;

 class Metotlar1
 
 {
   static void Degistir(int sayi)
   
   {
         sayi=10;
   }
   
   static void Yaz(int sayi)
                                             ÇIKTI: 1
   {
         Console.WriteLine(sayi);
   }
   
   static void Main()
   {
         int sayi=1;
         
         Degistir(sayi);
         
         Yaz(sayi);
   }
   
 }

 Bu iki programı çalıştırdığınızda göreceksiniz ki metoda parametre olarak aktarılan dizinin metot içinde bir elemanının değiştirilmesi esas diziyi etkiliyor. Ancak metoda parametre olarak aktarılan değişkenin metot içinde değiştirilmesi esas değişkeni etkilemiyor. Çünkü bir metoda parametre olarak bir dizi verildiğinde derleyici metoda dizinin bellekteki adresini verir; metot o adresteki verilerle çalışır. Dolayısıyla da dizinin herhangi bir elemanındaki değişiklik esas diziyi etkileyecektir. Çünkü gerek esas program, gerekse de metot aynı adresteki verilere erişir. Halbuki bir metoda parametre olarak bir değişken verdiğimizde metot için değişkenin bellekteki adresi önemli değildir, metot için önemli olan değişkenin değeridir. Metot, değişkeni kullanabilmek için geçici bir bellek bölgesi yaratır ve parametre olarak aldığı değişkenin değerini bu geçici bellek bölgesine kopyalar ve o geçici bellek bölgesiyle çalışır. Metottan çıkıldığında da o geçici bellek bölgesi silinir.

--->ref anahtar sözcüğü

using System;

 class Metotlar1
 
 {
 
   static void Degistir(ref int sayi)   
   
   {
         sayi=10;
   }
   
   static void Yaz(int sayi)
   
   {
         Console.WriteLine(sayi);
   }
   
   static void Main()
   
   {
         int sayi=1;  //int sayi; olursa program hatalı çalışır.
         
         Degistir(ref sayi);
         
         Yaz(sayi);
         
   }
   
 }
 ref anahtar sözcüğü değişkenlerin metotlara adres gösterme yoluyla aktarılmasını sağlar.ref sözcüğünün hem metodu çağırırken , hem de metodu oluşturuken değişkenden önce yazılması gerekiyor. Bu program ekrana 10 yazacaktır. Ayrıca ref sözcüğüyle bir değişkenin metoda adres gösterme yoluyla aktarılabilmesi için esas programda değişkene bir ilk değer verilmelidir. Yoksa program hata verir.
 
 ---->out anahtar sözcüğü
 
    Kullanımı ref anahtar sözcüğüyle tamamen aynıdır. Tek farkı out ile belirtilen değişkenlere esas programda bir ilk değer verilmesinin zorunlu olmamasıdır. 
    
using System;

 class Metotlar
 
 {
 
   static void Degistir(out int sayi)
   
   {
         sayi=10;
   }
   
   static void Yaz(int sayi)
   
   {
         Console.WriteLine(sayi);
   }
   
   static void Main()
   
   {
         int sayi;
         
         Degistir(out sayi);
         
         Yaz(sayi);
   }
   
 }
NOT: ref sözcüğünün dizilerle kullanımı gereksiz olmasına rağmen C# bunu kısıtlamamıştır. Ancak out sözcüğü dizilerle kullanılamaz.

Örnek : Değer ile parametre geçme:

static void Main(string[] args)

{
    int number = 5;
    
    Console.WriteLine(number);
 
    ChangeNumber(number);
    
    Console.WriteLine(number);
 
    Console.ReadKey();
}
 
static void ChangeNumber(int value)
{
    value = 8;
}

çıktı:5

      5
Örnek : Referans kullanımı

static void Main(string[] args)

{
    int[] number = { 5 };
    
    Console.WriteLine(number[0]);
 
    ChangeNumber(number);
    
    Console.WriteLine(number[0]);
 
    Console.ReadKey();
}
 
static void ChangeNumber(int[] value)
{
    value[0] = 8;
}

ÇIKTI:    5

          8

  Örneğin bir bölme işlemi yapmak istiyoruz; ancak sonucun yanında kalanı da öğrenmek istiyoruz. O zaman aşağıdaki gibi bir kod yazmamız gerekiyor.

static void Main(string[] args)

{
    int first = 10;
    
    int second = 3;
    
    int remain;
 
    int divResult = Division(first, second, out remain);
 
    Console.WriteLine(divResult + " " + remain);
 
    Console.ReadKey();
}
 
static int Division(int x, int y, out int z)

{
    int result = x / y;
    
    z = x - (result * y);
 
    return result;
}

ÇIKTI: 3 1

//---Metotların aşırı yüklenmesi---//

   C#'ta parametre sayısı ve/veya parametrelerin türleri farklı olmak şartıyla aynı isimli birden fazla metot oluşturulabilir. Buna metotların aşırı yüklenmesi denir.
 
 using System;

 class Metotlar
 
 {
   static void Metot1(int x,int y)
   
   {
         Console.WriteLine("1. metot çağrıldı.");
   }
   
   static void Metot1(float x,float y)
   
   {
         Console.WriteLine("2. metot çağrıldı.");
   }                                                     ÇIKTI: 3. metot çağrıldı.
                                                    
   static void Metot1(string x,string y)                        1. metot çağrıldı.
               
   {                                                            2. metot çağrıldı.
         Console.WriteLine("3. metot çağrıldı.");
   }
   
   static void Main()
   {
         Metot1("deneme","deneme");
         
         Metot1(5,6);
         
         Metot1(10f,56f);
   }
   
 }
--------------------------------------- 
 using System;
 
 class Metotlar
 
 {
 
   static void Metot1(float x,float y)    
   
   {
         Console.WriteLine("1. metot çağrıldı.");
   }
   
   static void Metot1(double x,double y)
   
   {
         Console.WriteLine("2. metot çağrıldı.");
   }
   
   static void Main()
   
   {
         Metot1(5,6);
   }
   
 }
 
Bu programda iki metodun da parametre sayısı eşit, iki metotta da tam tür uyumu yok ve iki metotta da bilinçsiz tür dönüşümü mümkün. Bu durumda en az kapasiteli türlü metot çağrılır. Yani bu programda birinci metot çağrılır.

using System;

 class Metotlar
 
 {
 
   static void Metot1(float x,float y)
   
   {
         Console.WriteLine("1. metot çağrıldı.");
   }
   
   static void Metot1(int x,int y)
   {
         Console.WriteLine("2. metot çağrıldı.");
   }
   
   static void Main()
   {
         Metot1('f','g');
   }
   
 }
 
Bu durumda ikinci metot çağrılır. Çünkü char hem inte hem de floata bilinçsiz olarak dönüşebilir. Ancak int daha az kapasitelidir.

//---Değişken sayıda parametre alan metotlar---//

using System;

 class Metotlar
 
 {
 
    static int Toplam(params int[] sayilar)
    
    {
    
       if(sayilar.Length==0)
       
          return 0;
          
       int toplam=0;
       
       foreach(int i in sayilar)
       
          toplam+=i;
          
       return toplam;
       
    }
    
    static void Main()
    
    {
       Console.WriteLine(Toplam()); //0
        
       Console.WriteLine(Toplam(5)); //5
       
       Console.WriteLine(Toplam(5,10)); //15 
       
       Console.WriteLine(Toplam(2,9,12)); //23
       
       Console.WriteLine(Toplam(7,12,45));   //64
       
       Console.WriteLine(Toplam(123,12,5,7,9,4,12)); //172
    }
    
 }

-----------------------------
using System;

 class Metotlar
 {
 
    static int Islem(string a,params int[] sayilar)
    
    {
       if(a=="carp")
       
       {
          if(sayilar.Length==0)
          
             return 1;
             
          int carpim=1;
          
          foreach(int i in sayilar)
          
             carpim*=i;
             
          return carpim;
          
       }
       
       else if(a=="topla")
       
       {
          if(sayilar.Length==0)
          
             return 0;  
             
          int toplam=0;
          
          foreach(int i in sayilar)
          
             toplam+=i;
             
          return toplam;
       }
       
       else
       
          return 0;    
    }
    
    static void Main()
    
    {
       Console.WriteLine(Islem("topla",3,4,7,8));  //22
       
       Console.WriteLine(Islem("carp",5,23,6));    //690
    }
    
 }

NOT: Değer döndüren metotlarımız mutlaka her durumda değer döndürmelidir. Örneğin metodumuzda sondaki else kullanılmazsa programımız derlenmez. Çünkü else'i kullanmasaydık birinci parametre yalnızca "carp" veya "topla" olduğunda metodumuz bir değer döndürecekti. Ve bu da C# kurallarına aykırı.

NOT: Değişken sayıda parametre alan metotlar aşırı yüklenmiş metotlar olduğunda değerlendirilmeye alınmaz.

//---Recursive (öz yinelemeli) metotlar---//

    Recursive metot en basit ve kısa tabiriyle, kendi kendini çağıran metotlara  denir.Recursive metot yazarken 4 anahtar adım vardır:
    
o	Koşulu kontrol et

o	İşlemleri yap

o	Kendini çağır

o	Sonucu dön

 using System;
 
 class Metotlar
 {
 
    static int Faktoriyel(int a)
    
    {
       if(a==0)
       
          return 1;
          
       return a*Faktoriyel(a-1);
       
    }
    
    static void Main()
    
    {
       Console.WriteLine(Faktoriyel(0));  1
       
       Console.WriteLine(Faktoriyel(1));  1
       
       Console.WriteLine(Faktoriyel(4));  24
       
       Console.WriteLine(Faktoriyel(6));  720
    }
    
 }

-------------------------

using System;

 class Metotlar
 {
 
    static float Fonksiyon(float x)
    
    {
       return 2*x+5;
    }
    
    static float TersFonksiyon(float x)
    
    {
       return (x-5)/2;
    }
    
    static void Main()
    
    {
       float x=10;
       
       Console.WriteLine(Fonksiyon(x)); //25
       
       Console.WriteLine(TersFonksiyon(x)); //2,5
       
       Console.WriteLine(Fonksiyon(TersFonksiyon(x))); //10
    }
    
 }
 
 //---Main metodu---//
 
   Çalışabilir her programda Main metodunun bulunması gerekiyor. Bütün programlarda önce Main metodu çalıştırılır. Diğer metotlar Main metodunun içinden çağrılmadıkça çalışmaz.

--->Main metodunun parametre alması

  Main metoduna parametreler işletim sisteminden verilir. Main metodu, komut satırından girilen argümanları string türünden bir diziye atayıp programımızda gönlümüzce kullanmamıza izin verir.

--->System.Math sınıfı ve metotları

namespace ConsoleApplication15
{
    class Program
    {
    
     static void Main()
     
        {
            double e = Math.E;
                                                  ÇIKTI: e->2,71828182845905 pi->3,14159265358979
            double pi = Math.PI;
            
            Console.Write("e->" + e + " pi->" + pi);
            
            Console.ReadLine();
        }
    }
}

-------------------------------
namespace ConsoleApplication16
{
    class Program
    
    {
        static void Main(string[] args)
        
        {
            int a = Math.Max(10, 34);
            
            int b = Math.Abs(-3);
            
            double c = Math.Ceiling(12.67);
            
            Console.Write("Max:" + a + " Abs:" + b + " Ceiling:" + c);
            
            Console.ReadLine();
        }
    }
}

ÇIKTI: Max:34 Abs:3 Ceiling:13
