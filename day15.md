#####İstisnai durum yakalama mekanizması

Programlarımızdaki hatalar ikiye ayrılır:

1. Derleme zamanı hataları

2. Çalışma zamanı hataları

Programımızda bir derleme zamanı hatası oluşursa derleme işlemi olmaz. Genellikle derleme zamanı hataları yanlış söz diziminden (sintaks) kaynaklanır ve tespiti kolaydır. Çalışma zamanı hataları ise daha çok mantıksal yanlışlıklardan kaynaklanır ve tespiti daha zordur.

######Hatanın türünden bağımsız hata yakalama
 
 using System;
 
 class deneme
 
 {
 
    static void Main()
 
    {
       string a=Console.ReadLine();
 
       string b=Console.ReadLine();
 
       int toplam=Int32.Parse(a)+Int32.Parse(b);
 
       Console.WriteLine(toplam);
    }
 }

Eğer sayı yerine harf girersek program hata verip sonlanacaktır. Bunu önlemek için programı şöyle yazabiliriz:

using System;
 
 class deneme
 
 {
 
    static void Main()
 
    {
 
       try
 
       {
 
          string a=Console.ReadLine();
 
          string b=Console.ReadLine();
 
          int toplam=Int32.Parse(a)+Int32.Parse(b);
 
          Console.WriteLine(toplam);
 
       }
 
       catch
 
       {
          Console.WriteLine("Sayı girmelisiniz!");
       }
 
    }
 }
   
    try bloğuna normal kodlarımızı yazıyoruz,catch bloğu ise hata olunca çalışıyor. 

using System;

 class deneme

 {

    static void Main()

    {

       try
       {

          string a=Console.ReadLine();

          string b=Console.ReadLine();

          int toplam=Int32.Parse(a)+Int32.Parse(b);

          Console.WriteLine(toplam);
       }

       catch

       {
          Console.WriteLine("Sayı girmelisiniz!");
       }

       finally

       {
          Console.WriteLine("Program sonlandı!");
       }

    }
 }
Burada finally bloğunda hata oluşsa da oluşmasa da çalıştırılması istenen satırlar yazılır. finally bloğunu belirtmek zorunda değiliz. Ancak try ve catch blokları istisnai durum yakalama mekanizmasının çalışması için mutlaka gereklidir. 

######Hatanın türüne bağlı hata yakalama

using System;

 class deneme

 {

    static void Main()

    {

       try
       {

          string a=Console.ReadLine();

          string b=Console.ReadLine();

          int toplam=Int32.Parse(a)+Int32.Parse(b);

          Console.WriteLine(toplam);
       }

       catch(FormatException nesne)

       {
          Console.WriteLine("Sayı girmelisiniz!");
       }
    }
 }

System isim alanındaki FormatException metotlara yanlış formatta parametre verilmesiyle ilgilenir. Eğer rakam yerine harf girersek Parse() metodu gerekli dönüşümü yapamayacağı için catch bloğu çalışacaktır.

using System;

 class deneme

 {

    static void Main()

    {

       try

       {

          string a=Console.ReadLine();

          string b=Console.ReadLine();

          int toplam=Int32.Parse(a)+Int32.Parse(b);

          Console.WriteLine(toplam);
       }

       catch(FormatException nesne1)

       {
          Console.WriteLine("Sayı girmelisiniz!");
       }

       catch(IndexOutOfRangeException nesne2)

       {
          Console.WriteLine("Dizi sınırları aşıldı!");
       } 

    }
 }

IndexOutOfRangeException dizi sınırlarının aşımıyla ilgilenen bir sınıftır. 

----->Programın biraz gelişmiş hali

using System;

 class deneme

 {

    static void Main()

    {

       try

       {

          string a=Console.ReadLine();

          string b=Console.ReadLine();

          int toplam=Int32.Parse(a)+Int32.Parse(b);

          Console.WriteLine(toplam);

       }

       catch(FormatException nesne)

       {
          Console.WriteLine("Şu hata meydana geldi: "+nesne.Message);
       }

    }
 }

   Message özelliği hemen hemen bütün hata sınıflarında bulunur ve hatanın ne olduğunu belirten bir string döndürür. 

using System;

 class deneme

 {

    static void Main()

    {

       try

       {
          Metot();
       }

       catch(IndexOutOfRangeException nesne)

       {
          Console.WriteLine("Dizi sınırları aşıldı.");
       }
    }

    static void Metot()

    {
       int[] a=new int[2];

       Console.WriteLine(a[3]);
    }
 }

Bu program ekrana Dizi sınırları aşıldı. yazacaktır. Yani bir metot başka bir metodun içinde kullanıldığı zaman ,kullanılan metot yeni metodun içine kopyalanmış gibi işlem yapıldı.
 
 using System;
 
 class deneme
 
 {
 
    static void Main()
 
    {
 
       for(;;)
 
       {
 
          try
 
          {
 
             Console.Write("Lütfen çıkmak için 0 ya da 1 girin: ");
 
             int a=Int32.Parse(Console.ReadLine());
 
             int[] dizi=new int[2];
 
             Console.WriteLine(dizi[a]);
 
             break;
          }
 
          catch
 
          {
             continue;
          }
       }
 
    }
 }

Bu programda,çıkmak için 0 veya 1 girme şartı var.  0 ve 1 girene kadar sürekli sayı girmemiz isteniyor.

######throw anahtar sözcüğü

Hata nesnelerinin atılması hata gerçekleştiğinde otomatik olarak yapılıyordu. Şimdi throw anahtar sözcüğü sayesinde ,hata gerçekleşmemişse bile sistemin hata gerçekleşmiş gibi davranmasını sağlayacağız. throw anahtar sözcüğünü try bloğunun içinde kullanmalıyız.
 
 throw new IndexOutOfRangeException("Dizinin sınırları aşıldı");

using System;

 class deneme

 {

    static void Main()

    {

       for(;;)

       {

          try

          {

             Console.Write("Lütfen çıkmak için 0 ya da 1 girin: ");

             string a=Console.ReadLine();

             if(a=="0"||a=="1")

                break;

             else

                throw new IndexOutOfRangeException("Devam ediliyor");

          }

          catch(IndexOutOfRangeException nesne)

          {

             Console.WriteLine(nesne.Message);

             continue;
          }

       }
    }
 }
ÇIKTI:  Lütfen çıkmak için 0 ya da 1 girin: a
            
             Devam ediliyor
            
             Lütfen çıkmak için 0 ya da 1 girin: 3
            
             Devam ediliyor
            
            Lütfen çıkmak için 0 ya da 1 girin: 1
            
                Sistemden çıkar. (0 girseydik de çıkardı.)

######İstisnai durum sınıflarında türeme
     
     Bütün istisnai durum sınıfları Exception sınıfından türetilmiştir. 

•	SystemException sınıfı Exception sınıfından türemiştir.

•	IOException sınıfı SystemException sınıfından türemiştir.

•	FileNotFoundException sınıfı IOException sınıfından türemiştir.

Bir catch bloğu IOException hatalarını yakalıyorsa aynı zamanda FileNotFoundException hatalarını da yakalar.

**NOT:** Birden fazla catch bloğu oluşturduğumuz durumlarda catch blokları art arda gelmelidir. Yani araya herhangi başka kod giremez.

**NOT:** Bir C# programında aşağıdaki gibi iki catch bloğu varsa ikincisi (parametreli olan) çalışır.

 catch
 {
 }

 catch(Exception nesne)
 {
 }

**NOT:** Birden fazla art arda gelen catch bloğunun parametreleri aynıysa programımız derlenmez.






