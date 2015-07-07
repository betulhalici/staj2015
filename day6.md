 **döngü yapıları**
 <https://tr.wikibooks.org/wiki/C_Sharp_Programlama_Dili/Ak%C4%B1%C5%9F_kontrol_mekanizmalar%C4%B1/>
 <http://www.kodlamamerkezi.com/c-net/c-for-dongusu-ornekler-ile-detayli-anlatim/>
 <http://www.kemalkefeli.com/csharp-dersleri-icerik.html/>
 
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
    
ÇIKTI: 1.sayı giriniz:6

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
 -------------------------------
 
    class Program
    
    {
        static void Main(string[] args)
        
        {
               for(int a=0;a<7;a++)
               
               {
                   if (a % 2 == 1)
                   
                       continue;
                       
                   Console.WriteLine(a);

                   Console.Read();
               }
         }
     }
ÇIKTI: 0

       2
       
       4
       
       6
       
       continue: döngünün o anki iterasyonu sonlanır.
       
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

Örnekler:

- 1'den 100'e kadar olan sayılar içerisinde 5'e tam bölünen, ancak 7'ye tam bölünemeyen sayıları alt alta listeleyen, bu sayıların kaç tane olduğunu ve toplamını yazan bir program.

namespace ConsoleApplication13

{
    class Program
    
    {
        static void Main(string[] args)
        
        {
            int toplam = 0, sayi = 0, i = 5;
            
            for(;i<55;i+=5)
            
            {
                if (i % 35 == 0)
                
                    continue;
                    
                sayi++;
                
                toplam += i;
                
                Console.WriteLine(i);
                
            }
            Console.WriteLine("Sayısı: " + sayi);
            
            Console.WriteLine("Toplam: " + toplam);
            
            Console.ReadLine();
            
         }
     }
}

ÇIKTI: 5

       10
       
       15
       
       20
       
       25
       
       30
       
       35
       
       40
       
       45
       
       Sayısı:9
       
       Toplam:240
       
- Girilen pozitif herhangi bir tamsayıyı ikilik düzene çeviren program.

static void Main(string[] args)

 {
      string mod = " ";
            
      Console.Write("sayıyı giriniz:");
      
      float a = Convert.ToSingle(Console.ReadLine());
      
      int b = (int)a;
      
      if (a <= 0 || a != b)
                
          mod = "pozitif tamsayı girmediğiniz için sayı ikilik sisteme dönüştürülemedi";
          
      else
      
          for (; b > 0; b /= 2)
          
                    mod = b % 2 + mod;
                    
       Console.Write(mod);
       
       Console.ReadLine();
       
  }
  
ÇIKTI: sayıyı giriniz:5
      
       101
       
- Konsol ekranına girilen 0 ile 100 arasındaki 3 notun en büyüğünü, en küçüğünü ve ortalamasını yazan program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 static void Main(string[] args)
 
 {
    int eb = 0, toplam = 0, ek = 0;
    
    for(int a=0,b;a<3;a++)
    
    {
       
        Console.Write(a + 1 + ".notu giriniz:");
                
        b = Convert.ToInt32(Console.ReadLine());
                
        if(b>100 || b<0)
               
         {
                    
             Console.Write("yanlış not girdiniz.Tekrar giriniz:");
                    
             a--;
                    
             continue;
             
         }
         
         if(a==0)
         
         {
                    
             eb = b;
                    
             ek = b;
                
          }
          
          else
          
          {
                    
             if (b >eb)
                        
             eb = b;
                    
             if (b < ek)
                        
             ek = b;
                
           }
           
            toplam += b;
            
        }
        
      Console.Write("En büyük: {0}\nEn küçük: {1}\nOrtalama: " + toplam / 10, eb, ek);
                    
      Console.ReadLine();
         
 }
 
 ÇIKTI: 1.notu giriniz:34
  
        2.notu giriniz:56
        
        3.notu giriniz:88
        
        En büyük:88
        
        En küçük:34
        
        Ortalama:17
