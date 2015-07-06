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
