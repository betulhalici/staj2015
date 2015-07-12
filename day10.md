#####Yapılar

Temel veri türleri (int, double, vb.) birer yapıdır. int türünden tanımladığımız bir a değişkeni/özelliği de bir yapı nesnesidir.

int a=5;

 Sinif b=23;

 int c=a;

 Sinif d=b;

 a=10;

 b=100;

 Console.WriteLine("{0}-{1}-{2}-{3}",a,b.Sayi,c,d.Sayi);

Bu kodda int c=a; satırında a'nın tuttuğu değer c'ye atanır. Sinif d=b; satırında ise d nesnesi b nesnesinin bellekteki adresini bulur ve o adresteki değeri tutar.Bu kodda b nesnesinde yapılan bir değişiklik d nesnesini, d nesnesinde yapılan bir değişiklik de b nesnesini etkileyecektir. Ancak c nesnesinde yapılan bir değişiklik a nesnesini, a nesnesinde yapılan bir değişiklik de c nesnesini etkilemeyecektir.

Yapılarda struct anahtar sözcüğü kullanılır.

struct YapiAdi

 {
    public int Ozellik1;

    public string Ozellik2;
 }

•	Tıpkı sınıflar gibi yapılarda da new operatörüyle nesne yaratılabilir. new anahtar sözcüğünü kullandığımızda yapının varsayılan yapıcı metodu veya varsa kendi tanımladığımız yapıcı metot çalıştırılır.

•	Tıpkı sınıflardaki gibi YapiAdi nesne; yazarak bir yapı nesnesini kullanılabilir hâle getiremeyiz. Ya değer atamamız ya da new anahtar sözcüğünü kullanmamız gerekir.

•	Bir yapı türündeki nesne bir metoda parametre olarak gönderildiğinde metodun içinde nesnenin değiştirilmesi esas nesneyi değiştirmez. Ancak sınıf nesnelerinde değiştirir.

•	Tıpkı sınıflardaki gibi yapılarda da birden fazla yapıcı metot yaratabiliriz. Ancak yapılarda parametre almayan bir yapıcı metot bildiremeyiz.

•	Bir yapının yapıcı metodu bildirildiğinde yapıcı metodun içinde yapının bütün özelliklerine ilk değer verilmesi gerekir.

•	Yapı nesnelerinin faaliyet alanı sonlandığında otomatik olarak bellekten silinirler.

•	Yapılarda yıkıcı metot yaratılması yasaklanmıştır.

•	Sınıflarda olduğu gibi yapılarda da sahte özellik (get ve set bloklu özellik) ve indeksleyici kullanabiliriz.

•	Yapı nesneleriyle ilgili işlemler, sınıf nesneleriyle ilgili işlemlerden daha hızlı gerçekleşir.

•	Tıpkı sınıflardaki gibi normal metotlar da bir yapı içerisinde bildirilebilir. Ayrıca üye elemanlar static olabilir.

•	Tıpkı sınıflardaki gibi bir yapı içerisindeki özellikler const ya da readonly olabilir.

•	Yapılardaki özelliklere ilk değer verilemez.

#####Enum sabitleri

Enum sabitleri sayesinde bazı özel sözcüklerin bazı tam sayıları temsil etmesini sağlayabiliriz. En genel enum bildirimi şu şekilde yapılır:

 enum AD : tur{SOZCUK1,SOZCUK2}

Bu bildirimde enum sabitinin adı ADdır. tur ise sözcüklerin hangi türden sabitleri temsil edeceğini belirtir. Parantez içindeki sözcükler ise herhangi bir sabiti temsil etmesini istediğimiz sözcüklerdir. Parantez içine en fazla türün kapasitesi kadar sözcük girilebilir. Örneğin tur yerine byte yazmışsak en fazla 255 tane sözcük girebiliriz.

 enum AD{SOZCUK1,SOZCUK2}

Burada bir tür belirtmediğimiz için otomatik olarak tür int olur. Enum sabitlerinin türünü byte, sbyte, short, ushort, int, uint, long ve ulong türlerinden biri yapabiliriz.

using System;

 enum not:byte{basarisiz,gecmez,gecer,orta,iyi,pekiyi}

 class Program
 {

    static void Main()

    {
       Console.Write("Lütfen notunuzu giriniz: ");

       not a=(not)Convert.ToByte(Console.ReadLine());

       Console.WriteLine(a);
    }

 }

0 girerseK basarisiz, 1 girerseK gecmez, 2 girersek gecer, 3 girersek orta, 4 girersek iyi ve 5 girersek  pekiyi yazmaktadır.

enum sınıfı ile string ve object dışındaki temel veri türleri arasında dönüşüm yapabiliriz.

using System;

 enum not:byte{basarisiz,basarili}

 class Program
 {

    static void Main()

    {
       not a=not.basarili;

       if(a==(not)1)

          Console.Write("Başarılısınız");

       else

          Console.Write("Başarısızsınız");
    }
 }

Burada da int türü not türüne bilinçli olarak dönüştürüldü

ÇIKTI: Başarılısınız

using System;

 enum not:byte{basarisiz,basarili}

 class Program

 {
    static void Main()

    {
       Console.Write(not.basarisiz);
    }
 }

Bu programda ekrana basarisiz yazılır. Yani enum sözcükleri direkt kullanılmak istendiğinde yalnızca sözcük kullanılıyor.

######Enum sıra numaralarını değiştirme

enum not:byte{basarisiz,basarili} satırında sözcükler 0'dan başlayarak birer birer artarak bir tam sayıyı temsil eder. Ancak hangi sözcüğün hangi tam sayıyı temsil ettiğini kendimiz belirtebiliriz. 

Örnekler:

- enum not:byte{basarisiz=6,basarili=10}

Bu örnekte basarisiz 6'yı, basarili 10'u temsil eder. Bir tam sayı birden fazla sözcüğe verilebilir.

- enum not:byte{basarisiz=6,basarili}

Bu örnekte basarisiz 6'yı, basarili 7'yi temsil eder.

- enum not:byte{basarisiz,gecmez=5,gecer,orta,iyi=2,pekiyi}

basarisiz 4,gecer 6,orta 7,pekiyi 3 olur.

- enum not:byte{basarisiz=-21,basarili}

Bu örnekte basarisiz -21'i basarili -20'yi temsil eder.

######System.Enum sınıfı

System.Enum sınıfı enum sabitleriyle kullanılabilecek çeşitli üye elemanlara sahiptir. Burada yalnızca GetNames() metodu tanıtılacaktır. GetNames() metodu bir enum sabitinin tüm sözcüklerini string türündeki bir dizi olarak tutar. 

 using System;

 enum Gunler:byte

 {
    PAZARTESI,

    SALI,

    CARSAMBA,

    PERSEMBE,

    CUMA,

    CUMARTESI,

    PAZAR
 }

 class Sinif
 {

    static void Main()

    {
       string[] a=Gunler.GetNames(typeof(Gunler));
    
       Console.WriteLine(a[0]);
    
       //veya
    
       Console.WriteLine(Gunler.GetNames(typeof(Gunler))[3]);
    }
 }
 
Bu örnek ekrana alt alta PAZARTESI ve PERSEMBE yazar.


