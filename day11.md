#####İSİM ALANLARI

İsim alanları en temel anlamıyla sınıfları organize etmeye (gruplandırmaya) yarayan bir yapıdır.

######.Net Framework kütüphanesindeki hazır isim alanlarına erişme

•	using anahtar sözcüğüyle bir isim alanını varsayılan isim alanımız hâline getiririz. Yani o isim alanındaki sınıflara, yapılara, vb. direkt erişebiliriz.

•	.Net Framework kütüphanesinin en tepesinde System isim alanı ve bunun altında çeşitli görevler için özelleşmiş farklı isim alanları bulunur.

•	using anahtar sözcüğüyle bir isim alanına erişim hakkı elde etmemiz onun altındaki veya üstündeki isim alanlarına da erişim hakkı elde ettiğimiz anlamına gelmez. Her bir isim alanını ayrı ayrı bildirmeliyiz.

•	Temel veri türleri (int, double, vs.) aslında .Net Framework kütüphanesindeki birer yapıdan başka bir şey değildir. Bu yapılar System isim alanının altında bulunur.

class Sinif
 {
    static void Main()
    
    {
       int a=5; //geçerli tanımlama
    
       Int32 a=5; //geçersiz tanımlama
    }
 }
 
C# ikisinde de aynı yapıyı (System.Int32) kullanmamıza rağmen ikincisine izin vermedi. Programın başına using System; satırını ekleseydik ikincisine de izin verecekti. Yani değişkenleri C#'a özgü şekilde oluşturmuşsak System isim alanını eklememiz zorunlu değildir. Yapıların gerçek hâlleriyle değişken oluşturmak ise System isim alanının eklenmesini gerektirir.

**Kendi isim alanımızı oluşturma**

Biz bir isim alanı oluşturmamışsak bile C# hayalî bir isim alanı oluşturur ve bize bu isim alanına direkt erişim hakkı verir. Ancak istersek türlerimizi bir isim alanı içine koyabiliriz. 

Örnek bir isim alanı bildirimi

namespace IsimAlani
 {
    ...
 }
 
Bir isim alanının içinde yalnızca sınıflar, temsilciler, enum sabitleri, arayüzler ve yapılar direkt olarak bulunabilir.

using System;

 namespace BirinciIsimAlani
 {

    class Deneme

    {
    }
}

 class AnaSinif

 {
    static void Main()

    {
       BirinciIsimAlani.Deneme d=new BirinciIsimAlani.Deneme();
    }
 }

+ Bulunduğumuz isim alanından farklı bir isim alanındaki türle ilgili işlemleri ilgili isim alanını da belirterek yapıyoruz.

+ Aynı using deyiminin birden fazla kez yazılması durumunda program hata vermez, ancak gereksizdir.

using System;

 using System;

 class Sinif
 {
    
    static void Main()
    
    {
       Console.WriteLine("Deneme");
    }
 }
 
 + using anahtar sözcüğünün bir başka kullanımı da istediğimiz bir bloğun sonunda nesnelerin Dispose() metodunu çağırmaktır.
 
 using System;
 
 class Deneme:IDisposable 
 {
   
    public void Dispose()
    
    {
       Console.WriteLine("Dispose() metodu çağrıldı.");
    }
 }
 
 class AnaSinif
 
 {
 
    static void Main()
 
    {
       Deneme d=new Deneme();
 
       using(d)
       {
 
          Console.WriteLine("using bloğu");
       }
       
       Console.WriteLine("using bloğu dışı");
    }
 }
 
ÇIKTI: 

using bloğu

Dispose() metodu çağrıldı.

using bloğu dışı

+ using ile takma isim (alias) verme

using System;

 using IsimAlani1;

 using IsimAlani2;

 //Eğer aşağıdaki iki satırı yazmasaydık programımız hata verirdi.

 using Sinif1=IsimAlani1.Sinif;

 using Sinif2=IsimAlani2.Sinif;

 //Bu iki satırla derleyicinin IsimAlani1.Sinif sınıfını Sinif1, IsimAlani2.Sinif sınıfını Sinif2 olarak tanımasını sağladık. 

 namespace IsimAlani1
{
   class Sinif

    {

       public Sinif()

       {
          Console.WriteLine("Burası IsimAlani1");
       }
    }
 }

 namespace IsimAlani2

 {

    class Sinif

    {
       public Sinif()

       {
          Console.WriteLine("Burası IsimAlani2");
       }
    }
 }

 class AnaSinif

 {

    static void Main()

    {

       Sinif1 a=new Sinif1();

       Sinif2 b=new Sinif2();

    }
 }
 
 Örnek:
 
 using K=System.Console;
 
 class AnaSinif
 {
 
    static void Main()
 
    {
       K.WriteLine("Deneme");
    }
 }

using System;

 using S=Sinif;

 class Sinif

 {

    public Sinif()

    {
       Console.WriteLine("Deneme");
    }
 }

 class Ana

 {
    static void Main()

    {
       S a=new S();
    }
 }

-------------------------

 using System;

 using K=Console;

 class Ana

 {

    static void Main()

    {
       K.WriteLine("Deneme");
    }
 }
 
Burada System isim alanı varsayılan isim alanımız olmasına rağmen varsayılan hayalî isim alanımız olmadığı için program hata verir.

**İç içe geçmiş isim alanları**

İsim alanları iç içe geçebilir.İki türlü iç içe geçmiş isim alanları oluşturabiliriz.

namespace UstIsimAlani.AltIsimAlani
 {      
    ...türler...
 }
 
Burada UstIsımAlani isim alanına bağlı AltIsimAlani adında bir isim alanı oluşturduk.

**:: operatörü**

:: operatörü ile takma isim verilmiş DLL kütüphanElerindeki tür ve isim alanlarına erişiriz.

**global haricî takma ismi**

.Net Framework kütüphanesi, kendi oluşturduğumuz kütüphaneler ve takma ad verilmemiş DLL kütüphanelerimiz otomatik olarak global takma adını alır.

using System;

 namespace ia

 {

    class Yardimci
    {

       public Yardimci()

       {
          Console.WriteLine("Yardımcı");
       }
    }
 }

 namespace ana

 {

    class Sinif

    {

       static void Main()

       {
          global::ia.Yardimci a=new global::ia.Yardimci();
       }
    }
 }

ÇIKTI: yardımcı

#####System isim alanı

**Temel tür yapıları**

MaxValue = İlgili veri türünün tutabileceği maksimum değeri ilgili veri türünden tutar. string, object ve bool türü haricindekilerle kullanılabilir.

        Console.WriteLine(UInt64.MaxValue);

MinValue = İlgili veri türünün tutabileceği minimum değeri ilgili veri türünden tutar. string, object ve bool türü haricindekilerle kullanılabilir.
        
        Console.WriteLine(UInt64.MinValue);

Epsilon = Yalnızca Single ve Double ile kullanılabilir. En küçük pozitif değeri ilgili veri türünden tutar. 
        
        Console.WriteLine(Single.Epsilon);

NaN = Herhangi bir sayıyı temsil etmeyen değer (ilgili türde). Yalnızca Single ve Double ile kullanılabilir.
        
        Console.WriteLine(Single.NaN);

NegativeInfinity = Negatif sonsuz (ilgili türde). Yalnızca Single ve Double ile kullanılabilir. 
        
        Console.WriteLine(Single.NegativeInfinity);

PositiveInfinity = Pozitif sonsuz (ilgili türde). Yalnızca Single ve Double ile kullanılabilir. 
        
        Console.WriteLine(Single.PositiveInfinity);

Parse() = String türünden veriyi ilgili türe çevirir. String ve object hariç bütün türlerle kullanılabilir. Aslında Parse() metodunun yaptığı iş stringin tırnaklarını kaldırmaktır. Stringin tırnakları kaldırılmış hâli hedef türle uyumluysa dönüşüm gerçekleşir.
        
        int a=Int32.Parse("12");

CompareTo() = Bu metotla, metodu çağıran veriyle parametre kıyaslanır. Metodu çağıran büyükse pozitif, parametre büyükse negatif, eşitlerse 0 değeri döndürür. Geri dönüş tipi inttir. Bool türüyle bool türü kıyaslanabilir. true 1, false 0'mış gibi ele alınır. String türündeyse iki string aynıysa 0, diğer durumlarda 1 değeri geri döndürür. 

        Console.WriteLine(12.CompareTo(100)); //-1

Equals() = Bu metotla, metodu çağıran veriyle parametre kıyaslanır. Eşitlerse true, eşit değillerse false değeri geri döndürür.

        Console.WriteLine(12.Equals(100)); //False

ToString() = Verilerin stringe dönüşmüş hâllerini tutar. Parse'ın tersidir diyebiliriz. Bütün türlerle kullanılabilir.

        string a=12.ToString();

IsInfinity() = Parametredeki Single ya da Double türündeki veri sonsuz ise true, değilse false değeri üretir. 
      
       Console.WriteLine(Single.IsInfinity(12)); //false
       
IsNaN() = Parametredeki Single ya da Double türündeki veri NaN (sayı olmayan) ise true, değilse false değeri üretir. 

       Console.WriteLine(Single.IsNaN(12)); //false

GetNumericValue() = Yalnızca Char yapısında bulunur. Char tipindeki parametre numerikse o sayıyı döndürür, numerik değilse negatif sayı döndürür.
       
       Console.WriteLine(Char.GetNumericValue('5')); //5

       eğer 5 yerine bir harf girseydim sonuç -1 olacaktı.

IsControl,IsDigit,IsLetter,IsLetterOrDigit,IsLower,IsNumber,IsPunctuation,IsSeperator,IsSurroGate,IsSymbol,IsUpper,IsWhiteSpace metotlarının tamamının geri dönüş tipi bool'dur. Belirtilen koşul sağlanmışsa true, sağlanmamışsa false değeri döndürür.

Console.WriteLine(Char.IsUpper('f')); //False

Console.WriteLine(Char.IsUpper("deneme",3)); //False

**Decimal türü**

Decimal türü System isim alanındaki Decimal yapısıyla temsil edilir.

ToByte(), ToSbyte, ToInt16, ToUInt16, ToInt32, ToUInt32, ToInt64, ToUInt64, ToSingle() ve ToDouble() metotlarının tamamı statictir, parametre olarak decimal türünden veri alırlar ve ilgili türdeki veriyi üretirler. Yani tür dönüşümü yaparlar.

d1 ve d2 decimal türünden iki veri olmak üzere=

- Decimal.Add(d1,d2); //d1 ve d2'nin toplamını decimal türünden tutar.

- Decimal.Divide(d1,d2); //d1'in d2'ye bölümünü decimal türünden tutar.

- Decimal.Multiply(d1,d2); //d1 ile d2'nin çarpımını decimal türünden tutar.

- Decimal.Subtract(d1,d2); //d1-d2'nin sonucunu decimal türünden tutar. (çıkarma işlemi)

- Decimal.Remainder(d1,d2); //d1'in d2'ye bölümünden kalanı decimal türünden tutar. (mod alma işlemi)

- Decimal.Floor(d1); //d1'den büyük olmayan en büyük tam sayıyı decimal türünden tutar. (aşağı yuvarlama)

- Decimal.GetBits(d1); //d1 için decimal sayı tanımlarken kullandığımız yapıcı işlevdeki beş parametreyi int türündeki bir dizi olarak tutar.

- Decimal.Negate(d1); //d1'in negatifini tutar.

- Decimal.Round(d1,sayi); //sayi int türünde olmalıdır. Bu metot ile d1'in ondalık kısmındaki hane sayısı sayi kadar kalır. Yani d1 12.53666 ve sayi
3 ise 12.537 tutulur. Son kaybedilen hane 5 ya da 5'ten büyükse son kalan hane 1 artılır. sayi 0 olursa d1 tam sayıya
yuvarlanmış olur.

- Decimal.Truncate(d1); //d1'in tam sayı kısmını tutar. Herhangi bir yuvarlama yapılmaz.

-------->Decimal sayıların normal sayılardan en önemli farklarından biri de şudur:

double a=2.00d;

decimal b=2.00m;

Console.WriteLine(a);

Console.WriteLine(b);

     Bu program ekrana alt alta 2 ve 2,00 yazar. Normal sayılarda ondalık kısımdaki etkisiz sıfırlar sonuca yansımazken, decimal sayılarda yansır.

**System.Array sınıfı**

Özellikler

- IsFixedSize= Dizinin eleman sayısı sabitse true, değilse false değeri verir.

    Console.WriteLine(dizi.IsFixedSize);

- IsReadOnly= Dizideki elemanlar salt-okunur ise true, değilse false değeri verir.

    Console.WriteLine(dizi.IsReadOnly);

- Length= Dizideki eleman sayısını verir (int). 

    Console.WriteLine(dizi.Length);

- Rank Dizinin kaç boyutlu olduğunu verir (int). 

    Console.WriteLine(dizi.Rank);

- IndexOf metodu bir elemanın bir dizi içinde ilk görüldüğü indeksi verir. 

    int[] dizi={1,6,9,23,5};

    Console.WriteLine(Array.IndexOf(dizi,5));

**Tarih ve zaman işlemleri**

   DateTime yapısı belirli bir zamanı tutmaya yararken, TimeSpan ise zamanın miktarıyla ilgilenir.

Console.WriteLine("En küçük: "+DateTime.MinValue);

Console.WriteLine("En büyük: "+DateTime.MaxValue);

ÇIKTI:  En küçük: 01.01.0001 00:00:00
             
         En büyük: 31.12.9999 23:59:59

    Now şimdiki saati, Today bugünü DateTime türünden verir.

Console.WriteLine(DateTime.Now); // 13.7.2015 16:50:30

Console.WriteLine(DateTime.Today); //13.7.2015 00:00:00

    Aynı işlemler DateTime yapısı türünden nesne oluşturularak da yapılabilir. 

DateTime Tarih=new DateTime();

DateTime Zaman=new DateTime();

Tarih=DateTime.Today;

Zaman=DateTime.Now;

Console.WriteLine(Tarih);

Console.WriteLine(Zaman);
    
     Şimdi de DateTime yapısına ait diğer güzel özellikleri inceleyelim, bunlar static değildir, yani DateTime türündeki nesnelerle erişilir.

- Date = DateTime nesnesine ilişkin saat dışındaki bilgiyi verir. (DateTime)

- Month = DateTime nesnesinin ay bilgisini verir. (int)

- Day= DateTime nesnesinin gün bilgisini verir. (int)

- Year= DateTime nesnesinin yıl bilgisini verir. (int)

- DayOfWeek= DateTime nesnesinin haftanın kaçıncı günü olduğunu verir. (DayOfWeek enum sabiti)

- DayOfYear= DateTime nesnesinin yılın kaçıncı gününe denk geldiğini verir. (int)

- TimeOfDay= Geçerli gün için 00:00:00'dan itibaren ne kadar zaman geçtiğini TimeSpan nesnesi olarak verir. (TimeSpan)

- Hour =DateTime nesnesinin saat bilgisini verir. (int)

- Minute = DateTime nesnesinin dakika bilgisini verir. (int)

- Second = DateTime nesnesinin saniye bilgisini verir. (int)

- Milisecond = DateTime nesnesinin milisaniye bilgisini verir. (1 saniye=1000 milisaniye)(int)

            DateTime a = new DateTime(2015, 7, 13);
            Console.WriteLine(a.Day);  //13
            
- TimeSpan yapısı belirli bir tarih tutmaktan ziyade zamanın miktarı ile ilgilenen bir yapıdır. İki DateTime nesnesini birbirinden çıkarırsak sonuçta bir TimeSpan nesnesi oluşur. 

            DateTime gun1 = new DateTime(2015, 7, 13);
                                                                   
            DateTime gun2 = new DateTime(2015, 6, 23);
            
            TimeSpan fark = gun2 - gun1;
            
            Console.WriteLine(fark.Days);   // -20

-------->Cinsler arasında dönüşüm yapılır. Bunların geri dönüş tipi ise double'dır.

TimeSpan GunSayisi=new TimeSpan(45,0,0,0);

DateTime nesne=DateTime.Today+GunSayisi;   //bugünden 45 gün sonrasını ekrana yazar

Console.WriteLine(nesne);  // 27.8.2015  00:00:00

-----------------------

TimeSpan DakikaSayisi=new TimeSpan(0,0,23,0);

DateTime nesne=DateTime.Now+DakikaSayisi;   //şimdiden 23 dk sonrasını ekrana yazar

Console.WriteLine(nesne);  // 13.7.2015 17:44:34

----------------------

DateTime yapısına ait olan AddDays() metodu DateTime türünden bir nesneye gün ekletip tutmak için kullanılır.
     
     DateTime a=new DateTime(2008,1,1);

     Console.WriteLine(a.AddDays(65));  //16.9.2015 00:00:00

**BitConverter sınıfı**

BitConverter sınıfı verilerin baytlarıyla ilgili işlemleri yaparken işimize yarayacak üye elemanları içerir. BitConverter sınıfında bir tane özellik vardır. Bu özellik IsLittleEndian özelliğidir. Sistemimizin verileri hangi mimariye göre sakladığını kontrol eder. Bilgisayarlar verileri iki çeşit mimariye göre saklarlar.

1.	Düşük anlamlı byte ilk sırada

2.	Yüksek anlamlı byte ilk sırada

Eğer düşük anlamlı byte ilk sıradaysa bu mimariye "Little Endian", yüksek anlamlı byte ilk sıradaysa bu mimariye de "Big Endian" denir. 

Little Endian sistemlerde verilerin belleğe önce düşük anlamlı baytları, sonra yüksek anlamlı baytları yazılır. Big Endian sistemlerde ise bu durumun tam tersi söz konusudur. 

 Aşağıdaki kodla sisteminizin hangi mimariyle çalıştığını öğrenebilirsiniz.

if(BitConverter.IsLittleEndian)
   
   Console.WriteLine("Little Endian");
                                                            ÇIKTI: Little Endian
else
   
   Console.WriteLine("Big Endian");
   
-------------------------

int a=258; //00000000 00000000 00000001 00000010          ÇIKTI: 2

byte[] dizi=BitConverter.GetBytes(a);                            1

foreach(byte b in dizi)                                          0

{                                                                0
   Console.WriteLine(b);
}

------------------------------

byte[] dizi={2,1,0,0};

Console.WriteLine(BitConverter.ToInt32(dizi,0));
                                
                                (.ToString olursa ekrana 02-01-00-00 yazar.)
                                
--------------------------

byte[] dizi={2,1};

Console.WriteLine(BitConverter.ToInt16(dizi,0));

       Bu kod hata vermez. Çünkü Int16 türünün kapasitesi 16 bittir (2 bayt). Dolayısıyla da Int16 türüne iki elemanlı bir byte dizisi verilmesi yeterlidir.

**Buffer sınıfı**

  Buffer sınıfıyla tür bilgisinden bağımsız işlemler yaparız. Buffer sınıfı verilerin değerlerine değil baytlarına bakar.

byte[] kaynak={1,2,3,1}; //00000001 , 00000010 , 00000011 , 00000001

short[] hedef=new short[4]; //0000000000000000 , 0000000000000000 , 0000000000000000 , 0000000000000000

Buffer.BlockCopy(kaynak,0,hedef,0,4);

/*hedef dizisinin yeni hâli: 0000001000000001 , 0000000100000011 , 0000000000000000 , 0000000000000000*/

foreach(short a in hedef)

  Console.WriteLine(a);

ÇIKTI: alt alta 513, 259, 0 ve 0 yazar.

**ByteLength() metodu**

Kendisine parametre olarak verilen bir dizideki toplam bayt sayısını bulur. 

short[] dizi=new short[4];

Console.WriteLine(Buffer.ByteLength(dizi)); //8

**GetByte() metodu**

byte[] dizi={0,3,2,1,4};

Console.WriteLine(Buffer.GetByte(dizi,3));   // 1

----------------------

short[] dizi={0,3,2,1,4}; 

// 0000000000000000 0000000000000011 0000000000000010 0000000000000001 0000000000000100

Console.WriteLine(Buffer.GetByte(dizi,4));  //2

**SetByte() metodu**

a. baytı deger olarak değiştirir.

byte[] dizi={2,1,4};

Buffer.SetByte(dizi,1,5);

Console.WriteLine(dizi[1]); //Ekrana 5 yazılır.

**GC (Garbage Collection) sınıfı**

GC.Collect();

bu metot Garbage Collection mekanizmasının devreye girmesini, dolayısıyla da eğer bellekte gereksiz nesne varsa silinmesini sağlar.Eğer parametre true olarak girilirse bellek miktarı hesaplanmadan önce GC mekanizması başlatılarak bellekteki gereksiz nesneler silinir. Eğer parametre false olarak girilirse direkt bellek miktarı hesaplanır.

    Console.WriteLine(GC.GetTotalMemory(true)); //94628




