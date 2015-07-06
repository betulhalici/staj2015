# staj2015

## 1.gün
 
  Stajımın ilk günü ne yapmam gerektiği  hakkında plan yapıldı ve başlangıç olarak yapmam gerekenler aşağıdadır:
  
+ Source control system nedir?
+ Faydaları nelerdir?
+ Github hesabı açılması 
+ Makineye git client kurulması
+ Github tarafından örnek repository açılması
+ Örnek repository altında README.md dosyasının oluşturulması ve markdown kullanımıyla içine bilgilerin eklenmesi

   Daha önce bilgim olmadığı için araştırmaya başladım.
   
   #####Source kontrol sistem
    Yazılım geliştirirken takım olarak çalışılabilmesini sağlayan sistemdir.Aynı anda,aynı proje üzerinde birçok kişinin çalışmasını mümkün kılan sistemdir.Uygulamamızın kaynak kodunun yönetimini sağlayan uygulamalardır.Yazdığımız kodların güvenilir bir şekilde saklanması,versiyonların takip edilmesi,kodun gelişimine katkıda bulunanların ve kodun kontrol altında tutulması gibi ihtiyaçları gidermek için ortaya çıkmıştır.Kodumuzu takımlar halinde geliştiriyorsak,kod paylaşımını kolaylıkla yapabilir,revizyonları kontrol edebiliriz.Kodun geçmiş sürümleri de saklandığı için kodumuzun istediğimiz bir sürümüne geri dönebiliriz.
   
   ######Faydaları
 - Birden fazla kişi aynı proje hatta aynı kod üzerinde çalışabilir ve bu değişikler tek bir kod dosyasına entegre edilebilir.
 - Kodlar üzerindeki değişiklikleri geri almak istersek değişiklik yapılmadan önceki eski versiyonu bizim için saklar.
 - Yazılan kodlar kontrol sistemi sunucusuna gönderilip ,daha sonra istenen kısımlar indirilip üzerinde değişiklik yapılabilir.
 - Farklı gereksinimler için farklı dallar oluşturup aynı anda birden fazla geliştirme yapabilir ve bu geliştirmeleri sonradan tek bir projede toplayabiliriz.
 - Herhangi bir dosyanın eski sürümünü indirebilir,yeni sürümü ile arasındaki farkları görebiliriz.
 
## 2.gün  

  Stajımın ikinci günü github kurulumuyla uğraştım. <https://github.com/> adresinden kayıt oldum.Bilgisayarıma da <https://windows.github.com/> adresinden github'ı yükledim.Repository açmak için ise github hesabına giriş yapıp,**new repository**'i seçip ilerliyoruz.Çıkan ekranda repository name'i dolduruyoruz,description kısmı optional olduğu için doldurmaya gerek yok.Public ve initialize this repository with a README'yi işaretliyoruz.gitignore kısmından C'yi seçip,license kısmını boş geçerek ilerliyoruz.Ve create repository'e tıklıyoruz.Klasör isminin yanındaki + 'ya tıklayarak buraya kodlarımızı eklemeye başlayabiliriz.En son **commit new file** diyerek işlemimizi bitiririz.

   Uygulama yapmak için git komutlarını araştırmaya başladım.Sık kullanılan git komutları aşağıdadır: kaynak için <http://www.mertsimsek.net/git-sik-kullanilan-git-komutlari/>
   
  + **git config** Genel git yapılandırması için kullanılır.
   
     Örnek: git config --global user.email "email adresi"
            git config --global user.name "kullanıcı adı"

  + **git init:** Bulunduğumuz dizine git repository'si açar.
  
  + **git clone:** Uzak sunucudaki git repository'sini bilgisayarımıza kopyalamaya yarar.
  
  + **git add:** Belirttiğimiz dosyayı çalışma dizinine ekler.
  
  + **git rm:** Belirttiğimiz dosyayı çalışma dizininden siler.
  
  + **git commit:** Çalışma dizinine eklenen tüm dosyaları yerel git reposuna ekler.
  
  + **git status:** Ekrana dizindeki dosyaların durumunu özetleyen bir yazı bastırır.
  
  + **git branch:** Varolan branch'leri listeler.Eğer yanına branch ismi yazarsak, yazdığımız isimde bir branch oluşturur.
  
  + **git checkout:** Branch'ler arası geçiş yapmaya yarar.
  
  + **git merge:** Bir veya birden fazla branch’i şu an bulunduğunuz branch’e birleştirir.
  
  + **git reset:** Çalışma dizinimizi bir önceki commit'e sıfırlar.
  
  + **git pull:** Uzakta bağlı olduğumuz git reposundaki dosyaları bilgisayarınıza indirir ve bulunduğumuz branchla    birleştirir.
  
  + **git push:** Yerelde yaptığımız commit'leri uzaktaki git reposuna aktarır.
  
  + **git remote:** Bağlı olduğumuz uzak git repo'larını gösterir.

## 3.gün
  
  Stajımın üçüncü günü markdown kullanımını araştırdım.
  
 **Markdown işaretleme dili**
  
    Kaynak: <http://1zinnur9.github.io/documents/markdown/index.html#slide1/> sitesinden yararlandım.
    
  + Bizim yerimize html dosyası üretir.
  
  + Düz yazı yazarken bu yazıyı formatlı bir şekilde yazmayı sağlar.
  
    ######Paragraflar
      Öncesinde bir satır boşluk olan yazı bloğu paragraf olarak algılanır.

    ######Satır sonları
      Satır sonunda 2 space bırakılmalıdır.
      
    ######Başlıklar
         #this is an H1(ana başlık)
         ###### this is an H6(en alt başlık)
         
    ######Alıntılama
      Alıntılama için eposta stili > karakterini kullanır.
      İç içe alıntılar ilk bağlantı bloğunun altında >> yazılarak yapılabilir.
      
    ######Listeler
      - Sıralı ve sırasız listeleme yapar.
      - Numaralandırılmış listeler için + , - , * yapısı
      
            +red
            *green
            -blue
            
      - Numaralandırılmışlar için 1.2.3. yapısı kullanılır.
      
             1.bird
             2.cat
             3.dog
             
     ######Kod blokları
     
      - Bir satır 4 space ya da 1 tab içeriden başladığında kod bloğu olur.
      - Satır içi kod bloğu için ters tırnak (`) kullanılır.
      
     ######Yatay Çizgiler
     
       Html de kullanılan <hr></hr> tagını markdown da belli bir hat üzerinde:
      üç veya daha fazla _ veya üç veya daha fazla * çizerek yapıyoruz.
      
          * * *
          ***
          ***** 
          - - -
          
     ######Link
     
    - Bağlantı eklerken satır içi veya referans stilini destekler.
    - Her iki stilde de bağlantının metinde gözükeceği şekli [] tarafından sınırlandırılır.
    - Satır içi link verirken
    
       [This link](http://example.net/)
       
    - Otomatik link için < /> arasında link verilerek otomatik link verilebilir.
     <http://example.com/>
     
     ######Vurgulama
     
      (2 tane *)isim(2 tane *) şeklinde yazarsak isim kalınlaşıyor.
      
     ######Resim ekleme
     
       ![Alt text][id]
       [id] : url/to/image "Optional title attribute"
       
       ## 4.gün
        
        Git komutlarıyla komut satırında uygulama yaptım.Daha önceden denemee adlı klasör oluşturmuştum.Bu klasörle ilgili bazı değişikler yaptım.
        
        Komut satırından şu komutları girdim.
        
       - pwd          (pwd ve cd o anda hangi dizin altında olduğumuzu açıkça belirtiyor.)
       
       - cd..
       
       - pwd
       
       - cd Dekstop/   (masaüstüne geçer.)
       
       - mkdir sources
       
       - cd sources/
       
       - pwd
       
       - git clone https://github.com/betulhalici/denemee.git
       
       - ls        (ls o anda altında bulunduğumuz dizinin içeriğini listeliyor.)
       
       - cd denemee/
       
       - ls
       
       - explorer .
       
       - git status
           
           modified README.md (yapılan değişikliği söylüyor)
           no changes added to commit
        
       - git diff
         
           -(silineni gösteriyor)
           +(ekleneni gösteriyor)
           yapılan değişikliği gösteriyor.
           
       - git status
           
           no changes added to commit
           
       - git diff
       
       - git add.
       
       - git status
       
           modified README.md
           
       - git commit -m "konsol denemesi"
       
           burada email ve ismimi girmemi istedi.
           
       - git config --global user.email "email adresini giriniz"
       
       - git config --global user.name "ad soyad"
       
       - git commit -m "konsol denemesi"
       
          1 file changed,2 insertions(+),2 deletions(-)
          
       - git status
       
         nothing to commit,working directory clean
         (commit edilecek bir şey kalmadı,siteyi refresh yaptığımız zaman değişiklik gözüküyor.)
         
       - git push
       
       - git status
       
          deleted:README.md     
          kalıcı olarak README.md dosyası silindi.
          
       - git checkout README.md
       
          bu komutu kullanınca dosyam geri geldi.
          
   ## 5.gün
   
   Stajımın 5.günü C# çalışmaya başladım,çeşitli örnekleri inceledim.
        
      Kaynak: <http://www.kemalkefeli.com/csharp-dersleri-icerik.html/>
  
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
            Console.WriteLine("Aritmetik İşlemler");
 
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






   
       
      
          
          
       
       
           
           


            
        

     






