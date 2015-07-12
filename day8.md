**C# SINIFLAR**

Sınıf nedir?
     Sınıf, birbiri ile alakalı özellikleri ve metotları bir arada tutan bir şablondur diyebiliriz. Sınıflar nesne yönelimli programlamanın en önemli ögesidir. Sınıflar sayesinde programlarımızı parçalara bölüp karmaşıklığını azaltırız.
     
     Sınıfları tanımlayan anahtar kelimemiz class’tır. Metotlar bir veya daha fazla komutun bir araya getirilmiş halidir; parametre alabilirler, geriye değer döndürebilirler. Özellikler ise bellek gözeneklerinin programlamadaki karşılıklarıdır. Bu bakımdan özellikler değişkenlere benzerler. Aradaki en temel fark değişkenlerin bir metot içinde tanımlanıp yalnızca tanımlandığı metot içinde etkinlik gösterebilmesine rağmen özelliklerin tıpkı metotlar gibi bir üye eleman olmasıdır. Bu bakımdan özelliklerin tuttuğu değerlere daha fazla yerden erişilebilir.
Bir metot ya da özelliğe bulunduğu sınıfın dışından da erişilebilmesini istiyorsak public sözcüğü kullanılır. private sözcüğü kullanmakla hiçbir şey yazmamak aynı etkiye sahiptir ve iki durumda da metot ya da özelliğe yalnızca bulunduğu sınıfın içinden erişilebilir. 

using System;

class SinifIsmi
 
 {
    
    public int ozellik1=55;
    
    public string ozellik2="deneme";
    
    public float ozellik3=123.78f;
    
    public int metot1(int a,int b)
    {
       return a+b;
    }
    
    public void metot2(string a)
    {
       Console.WriteLine(a);
    }
    
 }
 
 class EsasSinif
 {
 
    static void Main()
    {
       
       SinifIsmi nesne=new SinifIsmi();
       
       Console.WriteLine(nesne.ozellik1);  // 55
       
       Console.WriteLine(nesne.ozellik2);  //deneme
       
       Console.WriteLine(nesne.ozellik3);  //123,78
       
       Console.WriteLine(nesne.metot1(2,5)); //7
       
       nesne.metot2("Vikikitap");    //Vikikitap   
    }
 }
----------------------------------
Aynı sınıf türünden birden fazla nesne oluşturma

using System;

 class KrediHesabi
 {
    public ulong HesapNo;
 }
 
 class AnaSinif
 {
    static void Main()
    {
      
       KrediHesabi hesap1=new KrediHesabi();
      
       KrediHesabi hesap2=new KrediHesabi();
      
       hesap1.HesapNo=3456;
      
       hesap2.HesapNo=1111;
      
       Console.WriteLine(hesap1.HesapNo); //3456
      
       Console.WriteLine(hesap2.HesapNo); //1111
    }
 }
 
 Farklı nesnelerle bir sınıfın özelliğine erişip özelliğin değerini değiştirdiğimizde aslında birbirinden farklı değişkenlerin değerini değiştirmiş oluruz. 

using System;

 class KrediHesabi
 {
    public ulong HesapNo;
 }
 
 class AnaSinif
 {
 
    static void Main()
    {
       KrediHesabi hesap1=new KrediHesabi();
       
       KrediHesabi hesap2=hesap1;
       
       hesap1.HesapNo=3456;
       
       hesap2.HesapNo=1111;
       
       Console.WriteLine(hesap1.HesapNo);
       
       Console.WriteLine(hesap2.HesapNo);
    }
 }
 
  Bu durumda alt alta 1111 ve 1111 yazılacaktır. Çünkü KrediHesabi hesap2=hesap1; satırıyla KrediHesabi sınıfı türünden yeni bir nesne oluşturduk ancak bu nesne için bellekte ayrı bir alan tahsisatı yapmadık. Nesneyi hesap1 nesnesinin bellekteki adresine yönlendirdik. Dolayısıyla hesap1'in özelliğinde yapılan bir değişiklik hesap2'yi,hesap2'nin özelliğinde yapılan bir değişiklik de hesap1'i etkileyecektir.

  Özellik ve metot tanımlamaları için ayrı bir sınıf oluşturmak zorunda değiliz. Main() metodunun olduğu sınıfa istediğimiz üye elemanları ekleyebiliriz.
  
  using System;
  
 class EsasSinif
 {
    int a;
    
    static void Main()
    
    {
       EsasSinif nesne=new EsasSinif();
       
       Console.WriteLine(nesne.a);      
    }
    
 }
 
NOT: static anahtar sözcüğüyle belirttiğimiz metot ya da özellikleri direkt olarak söz konusu metot ya da özelliğin adını yazarak kullanabilriz. 

NOT: Diziler tıpkı değişkenler gibi birbirine atanabilirler. 

Örnek: int[] a={1,6,7,12};

       int[] b=a;
       
 Burada b dizisine a dizisi adres gösterme yoluyla aktarılmıştır, dolayısıyla da a dizisinin bir elemanında yapılan bir değişiklik b dizisini, b dizisinin bir elemanında yapılan bir değişiklik a dizisini etkileyecektir.Aşağıdaki gibi bir kullanım da doğrudur:

       int[] a={1,6,7,12};
       
       int[] b={1,5};
       
       b=a;
       
 Burada b dizisi sahip olduğu elemanları kaybedip a dizisinin adresine yönlendi.Yani aynı adrese yönlendirilebilirler.
 
---> Örnekler

- Bir metoda girilen iki parametreyi ve bunların çarpımını ekrana yazar. Eğer bir dikdörtgen söz konusu olduğunu düşünürsek dikdörtgenin enini, boyunu ve alanını ekrana yazar.

using System;

class Dortgen
 
 {
    public int En;
    
    public int Boy;
    
    public int Alan()
    
    {
       int Alan=En*Boy;
       
       return Alan;
    }
    
    public void EnBoyBelirle(int en,int boy)
    
    {
       En=en;
       
       Boy=boy;
    }
    
    public void Yaz()
    
    {
       Console.WriteLine("***************");
       
       Console.WriteLine("En:{0,5}",En);
       
       Console.WriteLine("Boy:{0,5}",Boy);
       
       Console.WriteLine("Alan:{0,5}",Alan());
       
       Console.WriteLine("***************");
    }
 }
 
 class AnaSinif
 
 {
    static void Main()
    
    {
    
       Dortgen d1=new Dortgen();
       
       d1.EnBoyBelirle(20,50);
       
       d1.Yaz();
       
       Dortgen d2=new Dortgen();
       
       d2.EnBoyBelirle(25,12);
       
       d2.Yaz();
    }
 }
 
ÇIKTI:   **************

             En:20
             
             Boy:50
             
             Alan:1000
          
          ****************
         
         *****************
             
             En:25
             
             Boy:12
             
             Alan:300
             
-  Ev üyelerinin (annemizin, babamızın vs.) özelliklerini gireceğimiz, yaşlarını hesaplayacağımız program.

using System;

    class EvHalki
    {
        public int DogumYili;                               ÇIKTI:  --------------------
        
        public string Meslek;                                       Adı: Hatice
        
        public string Ad;                                           Yaşı: 51
        
        public string GozRengi;                                     Mesleği: Ev hanımı
        
        public int Yas()                                            Göz rengi: Mavi
        
        {                                                           ---------------------
            return 2015 - DogumYili;
        }                                                           ---------------------

        public void OzellikleriYaz()                                 Adı: Kenan
        
        {                                                            Yaşı: 65
            Console.WriteLine("-----------");
                                                                     Mesleği: Emekli
            Console.WriteLine("Adı: " + Ad);                        
                                                                     Göz rengi: Kahverengi
            Console.WriteLine("Yaşı: " + Yas());                
                                                                     ------------------
            Console.WriteLine("Mesleği: " + Meslek);
                                                                     ------------------ 
            Console.WriteLine("Göz rengi: " + GozRengi);
                                                                     Adı: Uğur
            Console.WriteLine("------------");
        }                                                            Yaşı: 28
    }
                                                                     Mesleği: ogrenci
    class AnaProgram
                                                                     Göz rengi: Yeşil
    {
        static void Main()                                           -------------------
        
        {
            
            EvHalki annem = new EvHalki();
            
            annem.DogumYili = 1964;
            
            annem.Meslek = "Ev hanımı";
            
            annem.Ad = "Hatice";
            
            annem.GozRengi = "Mavi";
            
            EvHalki babam = new EvHalki();
            
            babam.DogumYili = 1950;
            
            babam.Meslek = "Emekli";
            
            babam.Ad = "Kenan";
            
            babam.GozRengi = "Kahverengi";
            
            EvHalki kardesim = new EvHalki();
            
            kardesim.DogumYili = 1987;
            
            kardesim.Meslek = "ogrenci";
            
            kardesim.Ad = "Ugur";
            
            kardesim.GozRengi = "Yesil";
            
            annem.OzellikleriYaz();
            
            babam.OzellikleriYaz();
            
            kardesim.OzellikleriYaz();
            
            Console.ReadLine();
        }
    }
}

######this anahtar sözcüğü

using System;

 class Dortgen
 
 {
    public int En;
    
    public int Boy;
    
    void EnBoyBelirle(int en,int boy)
    
    {
       
       En=en;
       
       Boy=boy;
    }
    
    static void Main()
    
    {
       
       Dortgen d1=new Dortgen();
       
       d1.EnBoyBelirle(20,50);
       
       Console.WriteLine(d1.En+"\n"+d1.Boy);
    }
 }
 
   Bu programda önce d1 nesnesinin En ve Boy özelliğini sırasıyla 20 ve 50 olarak ayarlıyoruz, sonra da bu d1 nesnesinin özelliklerini ekrana yazdırıyoruz. Bu program şöyle de yazılabilir:

using System;

 class Dortgen
 
 {
    
    public int En;
    
    public int Boy;
    
    void EnBoyBelirle(int en,int boy)
    
    {
       
       this.En=en;
       
       this.Boy=boy;
    }
    
    static void Main()
    
    {
       
       Dortgen d1=new Dortgen();
       
       d1.EnBoyBelirle(20,50);
       
       Console.WriteLine(d1.En+"\n"+d1.Boy);
    }
 }

----------------------------
using System;

 class Dortgen

 {
    
    public int En;
    
    public int Boy;
    
    void EnBoyBelirle(int En,int Boy)
    {
       
       En=En;
       
       Boy=Boy;
    }
    
    static void Main()              ÇIKTI: 0
    
    {                                      0
       
       Dortgen d1=new Dortgen();
       
       d1.EnBoyBelirle(20,50);
       
       Console.WriteLine(d1.En+"\n"+d1.Boy);
    }
 }
 
Main bloğunda EnBoyBelirle metodunu çalıştırdığımızda sadece EnBoyBelirle metodu çalışır, dolayısıyla da derleyici bu metottan önce tanımlanmış olan En ve Boy özelliklerini görmez.Alınan parametreleri d1 nesnesinin En ve Boy özelliklerine aktarmak için this kullanılır.

using System;

 class Dortgen
 {
    
    public int En;
    
    public int Boy;
    
    void EnBoyBelirle(int En,int Boy)
    
    {
       this.En=En;
      
       this.Boy=Boy;
       
    }
                                      ÇIKTI:20
    static void Main()                    
    {                                       50
       
       Dortgen d1=new Dortgen();
       
       d1.EnBoyBelirle(20,50);
       
       Console.WriteLine(d1.En+"\n"+d1.Boy);
    }
 }
 
 Artık EnBoyBelirle metodunun aldığı parametreler d1 nesnesinin özelliklerine atanacaktır.
 
 ---------------------------------
 
 using System;
 
 class Dortgen
 {
    
    static int En=8;
    
    static int Boy=3;
    
    static void Main()
    
    {
       
       int En=50;
       
       int Boy=100;
       
       Console.WriteLine(En+"\n"+Boy);
    }
 }
 
Burada ekrana sırasıyla 50 ve 100 yazılacaktır. Ancak;

using System;

 class Dortgen
 
 {
    
    static int En=8;
    
    static int Boy=3;
    
    static void Main()
    
    {
       
       int Boy=100;
       
       Console.WriteLine(En+"\n"+Boy);
    }
 }
 
Bu sefer de ekrana sırasıyla 8 ve 100 yazıldı.En ve Boy özellikleri static olarak tanımlandığı için bu özelliklere nesne oluşturmaya gerek kalmadan direkt erişebildik.

######get ve set anahtar sözcükleri

using System;

class YardimciSinif
    
    {
        
        int Sayi;
        
        public int SahteOzellik
        
        {
            set
            {
                if (value < 0)
                
                    Sayi=0;
                else
                
                    Sayi = value;
            }
            
            get
            
            {
                if (Sayi > 100)
               
                    return Sayi / 100;
               
                else
               
                    return Sayi;
            }
        }
   
    class AnaSinif
   
    {
        static void Main()
       
        {
            YardimciSinif nesne = new YardimciSinif();
           
            nesne.SahteOzellik = 100;
           
            Console.WriteLine(nesne.SahteOzellik);
           
            Console.ReadLine();
        }
    }


Özelliğe bir değer atanmaya çalışıldığında set bloğundaki, özellik kullanılmaya çalışıldığında da get bloğundaki komutlar çalıştırılır. value sözcüğü özelliğe girilen değeri tutar. Özelliğe girilen değer hangi türdeyse o türde tutar.

NOT: Aslında tanımladığımız her dizi Array sınıfı türünden bir nesnedir. İşte bu yüzden tanımladığımız dizilerle Array sınıfının metot ve özelliklerine erişebiliriz. Örneğin LengthArray sınıfı türünden bir özelliktir ve dizinin eleman sayısını verir. DiziAdi.Length yazılarak bu özelliğe erişilebilir.

NOT: Metot ve özelliklerin geri dönüş tipi bir dizi olabilir. 

using System;

class YardimciSinif
    
    {
        public int[] Dizi = { 7, 4, 3 };
       
        public int[] Metot()
       
        {
            int[] a = { 23, 45, 67 };
           
            return a;
        }
    }
    
    class AnaSinif
    
    {
    
        static void Main()
       
        {
            YardimciSinif nesne = new YardimciSinif();
          
            Console.WriteLine(nesne.Dizi[0]);
          
            Console.WriteLine(nesne.Metot()[2]);
          
            Console.ReadLine();
        }
    }

Örnek: sınıftaki metotlar dizinin bütün elemanlarını istenilen türe dönüştürüp bu oluşturulan yeni diziyi tutacak.

using System;

class Donustur
    {
    
        public static int[] Inte(Array dizi)
        {
    
            int[] gecici = new int[dizi.Length];
    
            for (int i = 0; i < dizi.Length; i++)
     
                gecici[i] = Convert.ToInt32(dizi.GetValue(i));
     
            return gecici;
        }
     
        public static string[] Stringe(Array dizi)
     
        {
            string[] gecici = new string[dizi.Length];
     
            for (int i = 0; i < dizi.Length; i++)
     
                gecici[i] = dizi.GetValue(i).ToString();
     
            return gecici;
        }
   }
   
    class AnaProgram
   
    {
     
        static void Main()
        {
     
            string[] a = { "2", "5", "7", "9" };
     
            int[] b = Donustur.Inte(a);   
     
            Console.WriteLine(b[1] + b[3]); //14
     
            int[] c = { 2, 7, 9, 4 };
     
            string[] d = Donustur.Stringe(c);
     
            Console.WriteLine(d[0] + d[3]); //24
     
            Console.ReadLine();
        }
    }
    
    string türündeki bir sabit ya da değişken dizilerin bazı özelliklerini sağlarken bazı özelliklerini sağlamaz:
    
•Tıpkı dizilerdeki gibi stringlerde de foreach deyimi kullanılabilir.

•Dizilerdeki Length özelliği stringlerle de kullanılabilir. Bunun dışındaki Array sınıfına ait hiçbir metot ve özellik stringlerle kullanılamaz.

NOT: get ve set anahtar sözcükleriyle erişim belirleyiciler kullanırken uymamız gereken bazı özellikler vardır:

1. Daima özellik bildiriminde kullanılan erişim belirleyicisi get veya set satırında kullanılan erişim belirleyicisinden daha yüksek seviyeli olmalıdır. Örneğin özellik bildiriminde kullanılan erişim belirleyici private ise get veya set satırında kullanılan erişim belirleyici public olamaz.

2. get veya set satırında kullanılan erişim belirleyici özellik bildiriminde kullanılan erişim belirleyiciyle aynı olmamalıdır. (Zaten gereksizdir.)

3. set ve get satırlarındaki erişim belirleyicileri yalnızca, özelliği public olarak belirtmiş ancak özelliğin set veya get bloklarının herhangi birisini private yapmak istediğimizde kullanılabilir.

4. get veya set için erişim belirleyicisi kullanacaksak sahte özelliğin bloğu içinde hem get hem de set bloğunun olması gerekir.

######Yapıcı metotlar

Yapıcı metotların adı sınıfın adıyla aynı olmalıdır.Yapıcı metotlar bir değer tutamaz. Ancak normal metotlardan farklı olarak void anahtar sözcüğü de kullanılmaz. 

Örnek program:

using System;

class Deneme

{
    public Deneme(int a,int b,int c)
  
    {
        Console.WriteLine(a + b + c);
    }
}

    class AnaProgram
  
    {
        static void Main()
  
        {
  
            Deneme a = new Deneme(2, 5, 6); //13
  
            Console.ReadLine();
        }
    }


NOT: Yapıcı metotların erişim belirleyicilerini private yaparak sınıfın dışından o sınıf türünden nesne oluşturulmasını engellemiş oluruz.

######Varsayılan yapıcı metot

Biz herhangi bir yapıcı metot oluşturmamışsak C# otomatik olarak bir yapıcı metot oluşturur. Bu metodun içi boştur, yani bir şey yapmaz. Bu metoda varsayılan yapıcı metot denir. Bu varsayılan yapıcı metodun aldığı herhangi bir parametre yoktur.

•Eğer bir sınıfta herhangi bir yapıcı metot oluşturmuşsak varsayılan yapıcı metot oluşturulmaz.

•Yapıcı metotlar da aşırı yüklenebilir. Örneğin public Deneme();, public Deneme(int a);, public Deneme(int a, int b); ve public Deneme(int a,int b,int c); şeklinde üç satır oluşturabilir ve nesnenin oluşturulma şekline göre bu metotlardan yalnızca birinin çalıştırılmasını sağlayabiliriz. 

using System;

   class Deneme
   {
 
       Deneme()
 
       {
           Console.WriteLine(0);
       }
 
       Deneme(int a)
 
       {
           Console.WriteLine(a);
       }
 
       Deneme(int a,int b)
 
       {
           Console.WriteLine(a + b);
       }
 
       Deneme(int a,int b,int c)
 
       {
           Console.WriteLine(a + b + c);
       }
 
       static void Main()
 
       {
 
           Deneme a = new Deneme(5, 6);
 
           Console.ReadLine();
       }
   }


3.metot çalışacaktır,sonuç:11

######Yıkıcı metotlar

Değişkenlerdeki faaliyet alanı kuralları aynen nesnelerde de geçerlidir. Yani Deneme a=new Deneme(); satırıyla tanımladığımız a nesnesi üzerinden Deneme sınıfının üye elemanlarına, yalnızca Deneme a=new Deneme(); satırının içinde bulunduğu en iç bloktan erişilebilir.C# Garbage Collection (çöp toplama) mekanizması sayesinde gereksiz nesneleri bellekten siliyor.

using System;

  class Deneme
  
  {
  
      ~Deneme()
  
      {
          Console.WriteLine("yıkıcı metot şimdi çalıştırıldı");
  
      }
  
      static void Main()
  
      {
          {
  
              Deneme a = new Deneme();
          }
  
          Console.WriteLine("vikikitap");
  
          Console.ReadLine();
      }
  }


  Yıkıcı metotlar sınıf adının başına ~ işareti getirilerek oluşturuluyor. Yıkıcı metotlar herhangi bir değer tutamazlar (void de almazlar) ve herhangi bir parametre almazlar. Bu program a nesnesi bellekten silindiği anda yani yıkıcı metot çalıştırıldığı anda ekrana Yıkıcı metot şimdi çalıştırıldı. yazacaktır.

######Static üye elemanları

- Bir nesneye bağlı olarak çalışmayacak üye elemanları static olarak belirtiriz. Örneğin Console sınıfındaki WriteLine() metodu veya Math sınıfındaki PI özelliği static üye elemanlardır.

- Static üye elemanlara nesne oluşturarak ulaşmaya çalışmak hatalıdır.

- Static üye elemanları oluştururken static sözcüğünün erişim belirleyici sözcükle sırası önemli değildir. 

- Şimdiye kadar fark ettiğiniz gibi Main metodunu hep static olarak oluşturduk. Eğer static olarak oluşturmasaydık bu metodun çalışabilmesi için içinde bulunduğu sınıf türünden bir nesne oluşturmamız gerekecekti. Bu durumda da Main metodu işlevi ile çelişecekti. Çünkü Main metodu programımızın çalışmaya başladığı yerdir.

- static olarak tanımlanan üye elemanlara çağrı yapıldığı an bu üye elemanlar için dinamik olarak bellekte yer ayrılır. Bu sayede static olarak tanımlanan ama değer atanmayan özelliklerin çağrı yapıldığı an varsayılan değeri tutması sağlanır.

- Bir sınıf nesnesi oluşturulduğunda static üye elemanlar için bellekte ayrı bir yer ayrılmaz.

- Normal metotlar gibi yapıcı metotlar da static olabilirler. örnek:

Static yapıcı metotlar parametre veya erişim belirleyicisi almazlar.Örnek:

using System;

 class Oyuncu

 {

    static int Toplam;

    Oyuncu()

    {
       Toplam++;

       Console.WriteLine("Toplam oyuncu: "+Toplam);

    }

    static Oyuncu()

    {
       Console.WriteLine("Oyun başladı");
    }

    ~Oyuncu()

    {
       Console.WriteLine("Bir oyuncu ayrıldı...");

       Toplam--;
    }

    static void Main()

    {
       { 

          Oyuncu ahmet=new Oyuncu();

          Oyuncu osman=new Oyuncu();
       }

       Oyuncu ayse=new Oyuncu();

       Oyuncu mehmet=new Oyuncu();
    }
 }

ÇIKTI: Oyun başladı

       Toplam oyuncu: 1

       Toplam oyuncu: 2

       Toplam oyuncu: 3

       Toplam oyuncu: 4

       Bir oyuncu ayrıldı...

       Bir oyuncu ayrıldı...

       Bir oyuncu ayrıldı...

       Bir oyuncu ayrıldı...

######Static sınıflar

Eğer bir sınıf sadece static elemanlar içeriyorsa o sınıfı static olarak tanımlayabiliriz. Böylelikle derleyici bize o sınıf türünden bir nesne oluşturmamıza izin vermeyecektir.Çünkü static olarak tanımladığımız sınıfların üye elemanlarını da ayrıca static olarak tanımlamak zorundayız. Static sınıfların yapıcı metotları olmaz. Dolayısıyla yapıcı metot tanımlamaya çalışırsak derleyici hata verir. Klasik bir static sınıf bildirimi şöyle yapılır:

 static class SinifAdi
 {
 ...
 }

NOT: Değişkenler konusunda gördüğümüz const anahtar sözcüğü özelliklerle de kullanılabilir. const olarak tanımlanan özellikler aynı zamanda static'tir.const özellikler static özelliklerin taşıdığı tüm özellikleri taşır.

NOT: const anahtar sözcüğü yalnızca object dışındaki özelliklerle (ve değişkenlerle) kullanılabilir. Dizilerle vs. kullanılamaz. const özellikler tanımlanır tanımlanmaz bir ilk değer verilmelidir.

UYARI: Bir sınıfın içinde (bir metodun içinde olmadan) metot ve özellik oluşturulmasından başka bir şey yapılamaz. Yapılacak diğer bütün şeyler bir metot bloğunun içinde olmalıdır.

######readonly anahtar sözcüğü

readonly anahtar sözcüğü const anahtar sözcüğünün yaptığı işi object türü, diziler, nesneler vs. için yapar. Yani bu ögeleri salt okunur hâle getirir. Örnek:
 
 using System;
 
 class Sinif
 
 {
 
    readonly int[] a={1,5,8};
 
    readonly object b=5;
 
    static void Main()
 
    {
       Sinif n=new Sinif();
 
       Console.WriteLine(n.a[0]);
 
       Console.WriteLine(n.b);
    }
 }
Şimdi bir de salt okunur nesne oluşturalım:

 using System;

 class Sinif
 {

    int a=5;

    static readonly Sinif nesne=new Sinif();

    static void Main()

    {
       Console.WriteLine(nesne.a);
    }
 }

•	readonly anahtar sözcüğü bir metot bloğunun içinde kullanılamaz.

•	readonly anahtar sözcüğü bir nesne için kullanılacaksa static sözcüğü de kullanılmalıdır.

•	readonly ve static sözcüklerinin sırası önemli değildir.

•	readonly bir dizi ya da object türü ayrıca static olarak belirtilebilir.

•	readonly anahtar sözcüğü constun kullanılabildiği int gibi türlerle de kullanılabilir.

•	readonly'nin constun aksine özellikleri staticleştirme özelliği yoktur.

•	static sözcüğü de readonly gibi bir metot içinde kullanılamaz.
NOT: Aslında int a; satırı int türünden bir nesne bildirimidir ve int a=new int(); satırı mümkündür. Bu durumda a'ya int türünün varsayılan değeri atanır.




