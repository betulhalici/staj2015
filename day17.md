#####Fonksiyonlar

  C#'ta fonksiyonlar kendi içerisinde birer alt programcıktır.Birçok isimle adlandırılır.Fonksiyonlar,metotlar,alt programlar gibi.

Örneğin Console.WriteLine bir metoddur işlevi sadece konsola yazdırmaktır. Geri dönüşü yoktur.
 
Ancak Console.ReadLine ise bir geri dönüşlü metoddur. Yazılan satırdaki veriyi almak için kullanılır. Ve dışarıya veriyi aktarır. 
 
function topla(sayi1,sayi2)

sonuc = sayi1 + sayi2

return sonuc

end

C#'ta fonksiyonlar oluşturulurken :

1- Dönüşü olmayan (Sadece işlem yapan) fonksiyonlar

2- Return(dönüş) olan fonksiyonlar
 
olarak ikiye ayrılır.

**1-Dönüşü olmayan fonksiyonlar**
 
Bir veri içerisinde işlem yapıp sonucu döndürmez ,sadece ekrana yazar. Dönüşü olmayan fonksiyonlar void deyimi ile başlar.

void Topla()
{
    
    int sayi1 = 1;

    int sayi2 = 2;

    int sonuc = sayi1 + sayi2;
}

**2-Return(dönüşü olan fonksiyonlar)**
 
Geriye dönüşü int, string , bool, list ,array vs bir çok değer olabilir.

    Mesela programın çeşitli yerlerinde bir sayı alıp bu sayının tek veya çift olduğunu öğrenmemiz gerekiyor.Bunu yaparken normalde aşağıdaki kodu kullanmak istediğimiz yerde yazmamız gerecektir.

int sayi = Convert.ToInt16(Console.ReadLine());

if(sayi%2==1)
     
      Console.WriteLine("Sayı Tek");

else

      Console.WriteLine("Sayı Çift");

     Ama programı sürekli kullanmamız gerekiyorsa bu kodu sürekli yazmamız gerekmiyor.Bunun yerine:

void tekcift(int sayi)
{
    
      if(sayi%2==1)
    
         Console.WriteLine("Sayı Tek");
    
      else
    
         Console.WriteLine("Sayı Çift");
}

      şu kodu bir defaya mahsus yazmamız ve kullanmamız gereken yerde de

int x= Convert.ToInt16(Console.Readline());

tekcift(x);

      kodunu kullanmamız gerekecektir.

----> Bir fonksiyon içerisinde şunları bulundurur:

Public : Bir fonksiyonun başında public kelimesi varsa bu fonksiyon programın bütün sınıfları içerisinde kullanılabilir.Fakat yoksa sadece o sınıf içerisinde kullanılabilir.

Yapı : Bir fonksiyon iki çeşit yapıdan oluşur.Dinamik fonksiyonlar ve statik fonksiyonlar.

Tip : Programın geri dönderdiği değer tipi belirler.int,string,char,void,boolean gibi bir çok tip belirlenebilir.

Fonksiyon İsmi : Bir fonksiyonun mutlaka bir ismi de olmak zorundadır. Fonksiyonun ismini belirlerken tıpkı değişken ismi belirlediğimiz gibi belirlemeliyiz.Türkçe karakterler kullanılmaz,sayı ile başlamaz.

Parametreler : Fonksiyona dışardan girilecek değişkenlerin tamamı parametre olarak tanımlanır.Birden fazla parametre tanımlarken değişkenler arasına ,(virgül) koymamız gerekir ve her seferinde parametre olarak alınacak değişkenlerin tipleri de belirtilmelidir.

Yapılacak İşlemler : Yukarıdaki kısımlar uygulandıktan sonra { ve } blokları arasına fonksiyonun görevi yazılmalıdır.Import olarak alınan parametreler buradan kullanılır ve return yapısıysa fonksiyonun kendisine export edilir.

Geri Dönüş Değişkeni : Bir fonksiyon geriye herhangi bir değer döndürüyorsa return yapısıyla bu işlem yapılır. Fonksiyon işlemlerini yaptıktan sonra sonuç itibariyle bir değer üretiyorsa bu değeri fonksiyona aktarmamız gerekecektir.İşte bu değeri taşıyan değişken bizim geri döndürmemiz gereken değerdir.Bir değişken içindeki değeri fonkiyonun kendisine aktarmak istiyorsak return değişkenadi; yapmanız gerekir.Mesela void tipinde bir fonksiyonun geriye dönüş değişkeni olması gerekmez çünkü sadece ekrana yazı yazacaktır.Burada return kullanmamız gerekmez. Geri dönüş değişkeninin tipiyle fonksiyonun tipi aynı olmalıdır.Aksi halde program hata verir.

using System;

 class Metotlar
 {

    int Topla(int a,int b)

    {
       return a+b;                   ÇIKTI: 7
    }

    static void Main()
    {

       Metotlar nesne=new Metotlar();

       int a=nesne.Topla(2,5);

       Console.Write(a);
    }

 }

Static olmayan bir metodu başka bir sınıf içinde oluşturalım ve kullanalım:

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

-----------------------------------

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


using System;                               

 class Metotlar1                                   

  {                                                

    static void Yaz(int[] dizi)                    

    {                                              

          foreach(int i in dizi)

             Console.WriteLine(i);
    }

    static void Main()

    {

          int[] dizi={1,2,4,7,9};

          Yaz(dizi);
    }
 }

ÇIKTI: 1

       2
       
       4
       
       7
       
       9
       
---------------------------------

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

       Console.WriteLine(Islem("topla",3,4,7,8));  22

       Console.WriteLine(Islem("carp",5,23,6));    690
    }

 }

