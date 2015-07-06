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
