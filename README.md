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
  + **git pull:** Uzakta bağlı olduğumuz git reposundaki dosyaları bilgisayarınıza indirir ve bulunduğumuz branchla birleştirir.
  + **git push:** Yerelde yaptığımız commit'leri uzaktaki git reposuna aktarır.
  + **git remote:** Bağlı olduğumuz uzak git repo'larını gösterir.

## 3.gün
  
  Stajımın üçüncü günü markdown kullanımını araştırdım.
  
 #####Markdown işaretleme dili
  
    Kaynak: <http://markdowntutorial.com/lesson/1//> sitesinden yararlandım.
    
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
     
      (**)isim(**) şeklinde yazarsak isim kalınlaşıyor.
      
     ######Resim ekleme
     
       ![Alt text][id]
       [id] : url/to/image "Optional title attribute"

     






