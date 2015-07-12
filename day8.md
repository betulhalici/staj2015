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



 



