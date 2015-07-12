#####Operatör aşırı yükleme

using System;

 class Zaman

 {

    public int Saat;

    public int Dakika;

    public int Saniye;

    public Zaman(int saat, int dakika, int saniye)

    {

        Dakika=dakika+saniye/60;

        Saniye=saniye%60;

        Saat=saat+Dakika/60;

        Dakika=Dakika%60;
    }

    public static Zaman operator+(Zaman a, Zaman b)

    {
        int ToplamSaniye=a.Saniye+b.Saniye;

        int ToplamDakika=a.Dakika+b.Dakika;

        int ToplamSaat=a.Saat+b.Saat;

        return new Zaman(ToplamSaat,ToplamDakika,ToplamSaniye);

    }
 }        

 class AnaProgram

 {

    static void Main()
    {

       Zaman zaman1=new Zaman(5,59,60);

       Zaman zaman2=new Zaman(1,0,120);

       Zaman zaman3=zaman1+zaman2;

       Console.WriteLine("{0}.{1}.{2}",zaman3.Saat,zaman3.Dakika,zaman3.Saniye);

    }
 }

  Zaman türünden bir nesneyle int türünden bir nesneyi toplamamız mümkün değildir. Eğer Zaman türünden bir nesneyle int türünden bir nesne toplanmak istenirse int türünden nesneyi saniye olarak hesaba katabiliriz. Bunun içinse Zaman sınıfına şu operatör metodunu ekleyebiliriz:


public static Zaman operator+(Zaman a, int b)
 {

   int ToplamSaniye=a.Saniye+b;

   return new Zaman(a.Saat,a.Dakika,ToplamSaniye);
 }

•	Operatör metotlarının geri dönüş tipinin illaki söz konusu sınıf tipinden olmasına gerek yoktur. Örneğin Zaman sınıfındaki ilk toplama operatör metodunu şöyle değiştirebiliriz.

public static string operator+(Zaman a, Zaman b)

 {

     int ToplamSaniye=a.Saniye+b.Saniye;

     int ToplamDakika=a.Dakika+b.Dakika;

     int ToplamSaat=a.Saat+b.Saat;

     Zaman nesne=new Zaman(ToplamSaat,ToplamDakika,ToplamSaniye);

     return nesne.Saat+"."+nesne.Dakika+"."+nesne.Saniye;

 }

•	Operatör metotları static ve public olmalıdır.

•	Dört işlem operatörleri (+, -, *, /) herhangi bir koşul olmaksızın aşırı yüklenebilirler.

######İlişkisel operatörlerin aşırı yüklenmesi

Şimdi Zaman sınıfına aşağıdaki operatör metotlarını ekleyelim.

 public static bool operator==(Zaman a, Zaman b)
 {

     if(a.Saniye==b.Saniye&&a.Dakika==b.Dakika&&a.Saat==b.Saat)

         return true;

     else

        return false;
 }

 public static bool operator!=(Zaman a, Zaman b)

 {
     return !(a==b);
 }

######true ve false operatörlerinin aşırı yüklenmesi

 public static bool operator true(Zaman a)
 
 {
 
     if(a.Saat>12)
 
         return true;
 
     else
 
        return false;
 }
 
 public static bool operator false(Zaman a)
 
 {
    if(a.Saat<=12)
 
        return true;
   
    else
   
        return false;
 }
 
Bu metotları asıl programımız içinde şöyle kullanabiliriz:

 Zaman zaman1=new Zaman(5,59,60);
 
 Zaman zaman2=new Zaman(2,35,40);
 
 if(zaman1)
 
    Console.WriteLine("Öğleden sonra");
 
 else
 
    Console.WriteLine("Öğleden önce");
 
 if(zaman2)
 
    Console.WriteLine("Öğleden sonra");

 else

    Console.WriteLine("Öğleden önce");

true ve false operatör metotlarının geri dönüş tipi mutlaka bool türünden olmalıdır.

######Mantıksal operatörlerin aşırı yüklenmesi

Örnek (sınıfımıza eklenecek):

 public static bool operator|(Zaman a,Zaman b)
 {

    if(a.Saat>12||b.Saat>12)

       return true;

    else

       return false;
       
}

& ve |, ! operatörlerinin aşırı yüklenebilmesi için herhangi bir şart yoktur.  Ancak && ve || operatörlerinin aşırı yüklenebilmesi için söz konusu sınıf için şu şartların sağlanması gerekir:

•	& ve | operatörleri aşırı yüklenmiş olmalıdır.

•	true ve false operatörleri aşırı yüklenmiş olmalıdır.

•	operator& ve operator| operatörlerinin parametreleri ilgili sınıf türünden olmalıdır.

•	operator& ve operator| operatörlerinin geri dönüş tipi ilgili sınıf türünden olmalıdır.

Yukarıdaki şartlar sağlandığı takdirde sanki && ve || operatörleri aşırı yüklenmiş gibi kodumuzu yazabiliriz. Örnek:

using System;

   class Sinif
   {
       public int Sayi;
       
       public Sinif(int sayi)
       
       {
           Sayi = sayi;
       }
       
       public static bool operator true(Sinif a)
       
       {
           return true;
       }
       
       public static bool operator false(Sinif a)
       
       {
           return false;
       }
       
       public static Sinif operator & (Sinif a,Sinif b)
       
       {
           return new Sinif(20);
       }
       
       public static Sinif operator | (Sinif a,Sinif b)
       
       {
           return new Sinif(30);
       }
   }
    
    class AnaProgram
    
    {
    
        static void Main()
    
        {
            Sinif a = new Sinif(50);
    
            Sinif b = new Sinif(10);
    
            Console.WriteLine((a || b).Sayi); //50
    
            Console.WriteLine((a && b).Sayi); //20
    
            Console.ReadLine();
        }
    }

######Tür dönüşüm operatörünün aşırı yüklenmesi

public static implicit operator HedefTur(KaynakTurdekiNesne)
 
 {
    return HedefTurdenVeri;
 }

Bu bilinçsiz tür dönüşümü içindi.Bilinçli tür dönüşümü metodu:

 public static explicit operator HedefTur(KaynakTurdekiNesne)

 {
    return HedefTurdenVeri;
 }

using System;

  class Sinif
  {
      public int Sayi;
      
      public Sinif(int sayi)
      
      {
          Sayi = sayi;
      }
      
      public static implicit operator int(Sinif a)
      
      {
          return a.Sayi;
      }
  }
  
    class AnaProgram
   
    {
   
        static void Main()
   
        {
   
            Sinif a=new Sinif(50);
   
            int b=a;
   
            Console.WriteLine(b); //50
   
            Console.ReadLine();
        }
    }

----->Bilinçli tür dönüşümü örneği:

using System;

  class Sinif
  {
      public int Sayi;
      
      public Sinif(int sayi)
      
      {
          Sayi = sayi;
      }
      
      public static explicit operator int(Sinif a)
      
      {
          return a.Sayi;
      }
  }
    
    class AnaProgram
    
    {
        static void Main()
    
        {
            Sinif a=new Sinif(50);
    
            int b=(int)a;
    
            Console.WriteLine(b);
    
            Console.ReadLine();
        }
    }

 Bilinçli ve bilinçsiz tür dönüşümü operatör metotlarını yazarken tek değişen implicit ve explicit anahtar sözcükleri. Bir sınıf içinde parametre ve geri dönüş tipi aynı olan explicit ve implicit metotlar aynı anda bildirilemez. Eğer implicit metodu bildirmişsek explicit (bilinçli) tür dönüşümüne de izin vermiş oluruz.

**NOT:** İmplicit metot sayesinde Sinif türünden bir nesneyi new anahtar sözcüğünü kullanmadan direkt Sinif a=23; gibi bir şey yazarak oluşturabiliriz..

**NOT:** Atama operatörünü (=) aşırı yükleyemeyiz. İşlemli atama operatörlerinde ise şöyle bir kural vardır: Örneğin + operatörünü aşırı yüklemişsek += operatörünü de kullanabiliriz. Bu durum bütün işlemli atama operatörlerinde geçerlidir. Hiçbir operatörün öncelik sırasını değiştiremeyeceğimiz gibi temel veri türleri (string, int, vb.) arasındaki operatörlere de müdahale edemeyiz. Örneğin dizilerin elemanlarına erişmek için kullanılan [] operatörünü, yeni bir nesneye bellekte yer açmak için kullanılan new operatörünü, ?:operatörünü, vb. aşırı yükleyemeyiz.

#####İndeksleyiciler

İndeksleyiciler tıpkı diziler gibi tek boyutlu indeksleyiciler ve çok boyutlu indeksleyiciler olmak üzere ikiye ayrılır.

using System;

    class Sinif
   
    {
        public int Sayi;
   
        public int this[int indeks]
   
        {
            get
   
            {
                return Sayi;
            }
   
            set
   
            {
                Sayi = value;
            }
        }
    }
   
    class AnaProgram
   
    {
        static void Main()
   
        {
            Sinif a = new Sinif();
   
            a[5] = 30;
   
            Console.WriteLine(a[5]); //30
   
            Console.ReadLine();
        }
    }

İndeksleyici tanımlarken parametre normal parantez yerine köşeli parantezler arasına yazılıyor. Esas programda [ ve ] arasına girilen veri indeksleyiciye parametre olarak gönderiliyor. İndeksleyicilere özel bir ad verilmiyor, bunun yerine this anahtar sözcüğü kullanılıyor. a[5]=30; satırıyla a[5]'in değil a'nın Sayi özelliği değiştiriliyor.

 class AnaProgram

 {
   
    static void Main()
   
    {
       Sinif a=new Sinif();
   
       a[5]=30;
   
       a[1]=2;
   
       Console.WriteLine(a[5]); //2
   
       Console.WriteLine(a[1]); //2
    }
 }
 
 Programı şöyle değiştirsek:
 
 using System;
 
 class Sinif
 
 {
    public int Sayi;
 
    public int this[int indeks]
 
    {
 
       get
 
       {
          return Sayi;
       }
 
       set
 
       {
          if(indeks>0)
 
             Sayi+=value;
 
          else if(indeks<0)
 
             Sayi-=value;
 
          else
 
             Sayi=Sayi;   
       }
    }
 }

 class AnaProgram

 {
    static void Main()

    {
       Sinif a=new Sinif();

       a[5]=45;

       a[-10]=23;

       a[100]=87;

       a[-80]=100;

       Console.WriteLine(a[0]);
    }
 }

Bu program ekrana 9 yazar. İndeksleyicinin set bloğunda indeksleyiciye hangi indeksle ulaşıldığı kontrol ediliyor. Eğer indeksleyici 0'dan büyükse esas programda o indeksleyiciye atanan değer a nesnesinin Sayi özelliğine ekleniyor. Eğer indeksleyici 0'dan küçükse esas programda o indeksleyiciye atanan değer a nesnesinin Sayi özelliğinden çıkarılıyor. Eğer indeksleyici 0'sa Sayi'nin değeri değiştirilmiyor.

######Çok boyutlu indeksleyiciler

Çok boyutlu indeksleyicilerin tek boyutlu indeksleyicilerden tek farkı indeksleyicinin aldığı parametre sayısıdır.

using System;

class Sinif
   
    {
        private int Sayi;
   
        public int this[int indeks1,int indeks2]
   
        {
            get
   
            {
                return indeks1 + indeks2+Sayi;
            }
   
            set
   
            {
                Sayi = indeks1 * indeks2 + value;
            }
        }
    }
   
    class AnaProgram
   
    {
        static void Main()
   
        {
            Sinif a = new Sinif();
   
            a[5, 4] = 45;
   
            Console.WriteLine(a[-6, 12]);
   
            Console.ReadLine();
        }
    }

Bu programda a[5,4]=45; satırında 5*4+45 işlemi yapılır ve sonuç Sayi özelliğine atanır. Console.WriteLine(a[-6,12]); satırında ise -6+12+65 işlemi yapılır ve sonuç ekrana yazılır. (sonuç: 71)




