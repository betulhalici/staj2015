#####GÖSTERİCİLER

     Göstericiler (pointer) yapı nesnelerinin bellekteki adreslerini tutan bir veri tipidir. C# normal yollarla gösterici kullanılmasına izin vermez. Programımızın herhangi bir yerinde gösterici kullanabilmek için o yeri unsafe anahtar sözcüğüyle belirtmemiz gerekir.

• Bir sınıfı unsafe olarak belirtirsek o sınıf içinde gösterici kullanabiliriz.
 
 unsafe class Sinif
 
 {
    ...
 }

• Herhangi bir metodun içinde bir unsafe bloğu oluşturarak o bloğun içinde gösterici kullanabiliriz.
 
 int Metot()
 
 {
    unsafe
    
    {
       ...
    }
 }

• Normal bir metodu unsafe olarak belirterek o metot içinde gösterici kullanabiliriz.

 unsafe int Metot()
 
 {
    ...
 }

• İçinde gösterici kullandığımız bir kaynak kod dosyası normal yollarla derlenemez. "Unsafe code may only appear if compiling with /unsafe" hatasıyla karşılaşırız.Bu hatayı düzeltmek için Solution’daki projemize sağ tıklayıp Properties -> Build menüsünden "Allow unsafe code" seçeneğini aktif etmeliyiz.

######Gösterici bildirimi

- Gösterici bildirimi ,ilgili yapı adının sonuna * işareti koyularak yapılır.
 
 char* gosterici1;
 
 int* gosterici2;

     Bu göstericilerden birincisi bir char türünden nesnenin (değişkenin), ikincisi de bir int türünden nesnenin adresini tutabilir.
 
- Birden fazla aynı türde gösterici oluşturmak için normal veri türlerinde olduğu gibi virgül kullanılabilir.
 
    int* gosterici1, gosterici2;

- Göstericileri sabit ifadeler ile de bildirebiliriz. 
  
    double* gosterici=(double*)123456;

   Burada bellekteki 123456 adresi gosterici göstericisine atanıyor.

**& operatörü**

   & operatörü yapı nesnelerinin bellekteki adreslerini üretir. Operandı hangi türdeyse o türün gösterici tipinde bir değer döndürür.
 
 int a=5;
 
 int* gosterici;
 
 gosterici=&a;

######* operatörü

  * operatörü adreslerdeki veriyi görmek veya değiştirmek için kullanılır. * operatörü hangi tür göstericiyle kullanıldıysa o türde nesne geri döndürülür.
 
 double a=5;
 
 double* gosterici;
 
 gosterici=&a;
 
 *gosterici=10;

    Yani kısaca & ve * operatörleri gösterici ve nesne arasında dönüşüm yapmak için kullanılır.
    
NOTLAR:

1-) Henüz adresi olmayan bir göstericiye değer atanamaz. 

      int* gosterici;
 
      *gosterici=10;    //hatalı kullanım

2-) Ancak henüz bir değeri olmayan bir nesnenin adresi alınabilir. Yani şu kod hata vermez:
 
      int a;
 
      int* ptr=&a;

**Göstericiler arasında tür dönüşümü**

   Göstericiler arasında bilinçli tür dönüşümü yapılabilir. Büyük türün küçük türe dönüşümünde veri kaybı yaşanabilir. Küçük türün büyük türe dönüşümünde de küçük tür bellekte kendine ait olmayan alanlardan da alır.
 
 using System;
 
 class Gostericiler
 
 {
 
    unsafe static void Main()
 
    {
        char c='A';
        
        int i=80;
        
        char* cg=&c;
        
        int* ig=&i;
        
        cg=(char*)ig;
        
        Console.WriteLine(*cg);
   }
 }
 
ÇIKTI: 80 ,Çünkü P' nin ascii kodu 80'dir. 
   
   Göstericiler yapı nesnelerinin bellekteki adreslerini tutarlar. İşte bu adresi elde etmek için ilgili gösterici bir tam sayı türüne dönüştürülmelidir. 

using System;

 class Gostericiler

 {

    unsafe static void Main()

    {
        int i=80;

        int* ig=&i;

        uint adres=(uint)ig;

        Console.WriteLine("{0:X}",adres); //5A7EA8C
   }
 }

 Göstericilerin adreslerini elde ederken uint türüne dönüşüm yapmak zorunlu değildir. İstediğimiz tam sayı türüne dönüşüm yapabiliriz.
 
 **void göstericiler**
 
   void tipinden göstericilere her türden adres atanabilir. void türü nesnelerdeki object türüne benzer. 
 
 int* gosterici1;
 
 void* gosterici2;
 
 gosterici2=gosterici1;

**sizeof operatörü**

   sizeof operatörü yapıların bellekte ne kadar yer kapladıklarını bayt türünden verir. Geri dönüş tipi inttir.
 
  Console.WriteLine(sizeof(int)); //4

 using System;
 
 class Gostericiler
 
 {
    struct yapi
 
    {
       public int Ozellik1;
       
       public int Ozellik2;
    }
	
    unsafe static void Main()
    
    {
       Console.WriteLine(sizeof(yapi));  //8
    }
 }
 
 **Gösterici aritmetiği**
 
using System;
 
 class Gosterici
 
 {
    unsafe static void Main()
 
    {
       int* g1=(int*)500;
 
       char* g2=(char*)500;
 
       double* g3=(double*)500;
 
       byte* g4=(byte*)500;
 
       g1+=2;
 
       g2+=5;
 
       g3+=1;
 
       g4+=6;
 
       Console.WriteLine("{0} {1} {2} {3}",(uint)g1,(uint)g2,(uint)g3,(uint)g4);
    }
 }
 
ÇIKTI: 508 510 508 506 

**fixed anahtar sözcüğü**

  Bir sınıf nesnesi üzerinden erişilen bir yapı nesnesinin bir blok boyunca değişmemesini istersek fixed anahtar sözcüğünü kullanırız.
(fixed'sız):
 
 using System;
 
 class ManagedType
 
 {
    public int x;
    
    public ManagedType(int x)
    
    {
       this.x=x;
    }
 }
 
 class Gosterici
 
 {
    unsafe static void Main()
 
    {
       ManagedType mt=new ManagedType(5);
 
       int* g=&(mt.x)
    }
 }

Bu programın derlenmesine C# izin vermeyecektir. Çünkü x bir sınıf nesnesidir ve sınıf nesnelerinin adresleri program boyunca değişebilir. Örneği şöyle düzenlersek:

using System;

 class ManagedType

 {
    public int x;

    public ManagedType(int x)

    {
       this.x=x;
    }
 }

 class Gosterici

 {

    unsafe static void Main()

    {
       ManagedType mt=new ManagedType(5);

       fixed(int* g=&(mt.x))

       {
          //Bu blok boyunca x özelliğinin adresi değiştirilmeyecektir.
       }
    }
 }
 program çalışır.
 
 **Göstericiler ile dizi işlemleri**
 
Diziler bir System.Array sınıfı türünden nesnedir. Dolayısıyla diziler bir managed type'dır. Yani dizi elemanlarının adreslerini fixed anahtar sözcüğünü kullanmadan elde edemeyiz. Çok boyutlu diziler de dâhil olmak üzere tüm dizilerin elemanları bellekte ardışıl sıralanır.
 
 using System;
 
 class Gosterici
 {
 
    unsafe static void Main()
 
    {
       int[] a={1,2,3,4};
 
       fixed(int* g=&a[0])
 
       {
          for(int i=0;i<a.Length;i++)
 
             Console.WriteLine(*(g+i));
       }
    }
 }

   Bu program dizinin elemanlarını alt alta yazacaktır. 

NOT: Göstericiler ile indeksleyici kullanılabilir. Göstericilerde şu eşitlikler vardır:

• *(g+0) == g[0]

• *(g+1) == g[1]

• *(g+2) == g[2]

• *(g+3) == g[3]

   g[1] bir nesne belirtirken g+1 bir gösterici belirtir.

------> Bir diziyle aynı dizinin ilk elemanının adresi birbiriyle aynıdır.

using System;

 class Gosterici

 {

    unsafe static void Main()

    {
       int[] a={1,2,3,4};

       fixed(int* g1=a, g2=&a[0])

       {
          Console.WriteLine((uint)g1);

          Console.WriteLine((uint)g2);
       }
    }
 }

ÇIKTI:  44112348

        44112348
        
  **Yönetilmeyen diziler**
  
Sınıflar yönetilen bir türdür. Yapılar, enum sabitleri, vs. ise yönetilmeyen türlerdir. Yönetilmeyen türlerle ilgili işlem yapmak daha hızlıdır. Çünkü yönetilmeyen türlerde C# bellek sorumluluğunu bize verir.Yönetilmeyen diziler stackalloc anahtar sözcüğüyle belirtilir. stackalloc bize bellekte istediğimiz kadar alan tahsis eder ve bu alanın başlangıç adresini bir gösterici olarak döndürür. 

int* dizi=stackalloc int[10];

    stackalloc komutu ile bellekte 10*sizeof(int)=40 baytlık alan ayrılır.
    
using System;
 
 class Gosterici
 {
 
    unsafe static void Main()
 
    {
       int* dizi=stackalloc int[10];
 
       for(int i=0;i<5;i++)
 
          Console.WriteLine("*(dizi+{0})={1}",i,dizi[i]);
    }
 }
 
ÇIKTI: *(dizi+0)=0
           
       *(dizi+1)=0
           
       *(dizi+2)=0
            
       *(dizi+3)=0
            
       *(dizi+4)=0
       
 Örnek:
 
 using System;
 
 class Gosterici
 {
 
    unsafe static void Main()
 
    {
       int* dizi=stackalloc int[10];
 
       for(int i=0;i<50;i++)
 
          Console.WriteLine("*(dizi+{0})={1}",i,dizi[i]);
    }
 }

Bu programda dizinin sınırları aşılmış olmasına rağmen program çalışmaya devam eder. Ancak başka programların bellekteki verilerine de müdahale etmiş oluruz.
     
######Yapı türünden göstericiler

 Bütün yapılardan gösterici oluşturulabilir. Ancak bir şart vardır: İlgili yapının içinde geri dönüş tipi bir sınıf olan özellik olmamalıdır. Geri dönüş tipi bir sınıf olan metot ya da sahte özellik olabilir. 

**-> operatörü**

-> operatörü bir gösterici üzerinden ilgili yapının üye elemanlarına erişmek için kullanılır. 

using System;

 struct Yapi

 {
    //string k; ---> Bu kod eklenseydi program derlenemezdi.

    public int x;

    int s;

    public Yapi(int x, int s)

    {
       this.x=x;

       this.s=s;
    }

    public string Metot()

    {
       return "Deneme";
    }

    public string Ozellik
    
    {
       set{}
    
       get{return "Deneme";}
    }
 }
 
 class Prg
 
 {
    unsafe static void Main()
 
    {
       Yapi a=new Yapi(2,5);
 
       Yapi* b=&a;
 
       Console.WriteLine(b->Metot()); //Gördüğünüz gibi göstericiler üzerinden ilgili yapının üye elemanlarına erişebiliyoruz.
 
       Console.WriteLine(b->Ozellik);
 
       Console.WriteLine(b->x);
    }
 }

**Göstericiler ve string türü**

Stringlerin göstericiler için özel bir anlamı vardır. Stringlerin karakterleri tıpkı diziler gibi bellekte ardışıl sıralanır. Dolayısıyla ilk karakterinin adresini bildiğimiz bir stringin tüm karakterlerini elde edebiliriz. 
 
 using System;
 
 class Stringler
 
 {
 
    unsafe static void Main()
 
    {
       fixed(char* g="btl")
 
       {
          for(int i=0;g[i]!='\0';i++)
 
             Console.WriteLine(g[i]);
       }
    }
}

ÇIKTI: b

       t
       
       l




