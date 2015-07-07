 **döngü yapıları**
 <https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Ak%C4%B1%C5%9F_kontrol_mekanizmalar%C4%B1/>
 
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
ÇIKTI:
 
 1.sayı giriniz:6
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
