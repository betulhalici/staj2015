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
