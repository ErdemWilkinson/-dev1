<img width="793" height="472" alt="image" src="https://github.com/user-attachments/assets/2a3a1ea9-f979-471a-8f66-aed85fb4e265" />  <br>

Bu proje, C# Windows Forms kullanarak yapılmış bir sayı tahmin oyunudur. Bilgisayarın tuttuğu 4 basamaklı sayıyı 10 deneme hakkı içinde bulmaya çalışıyoruz.  <br>


Oyun başladığında bilgisayar 0-9 arası rakamlardan oluşan 4 basamaklı bir sayı tutar. Bu sayıdaki rakamlar birbirinden farklıdır. Kullanıcı 10 deneme hakkına sahiptir ve her tahminden sonra ipuçları alır.<br>

Her tahminden sonra üç farklı renk ile geri bildirim verilir: <br>

Yeşil: Doğru rakam doğru yerde <br>
Mavi: Doğru rakam ama yanlış yerde <br>
Kırmızı: Bu rakam sayıda yok <br>

Kodun Açıklaması
<br>
Program başladığında Random sınıfı ile rastgele sayı üretilir. Üretilen sayının basamakları a, b, c, d değişkenlerinde tutulur. Her tahminde kullanıcının girdiği sayı basamaklarına ayrılır ve tutulan sayı ile karşılaştırılır.
Karşılaştırma sonucunda her basamak için kontrol yapılır. Eğer rakam hem değer hem pozisyon olarak doğruysa yeşil sayacı artırılır. Rakam doğru ama yanlış pozisyondaysa mavi sayacı artırılır. Rakam hiç yoksa kırmızı sayacı artırılır.
Yeşil sayacı 4 olduğunda kullanıcı kazanmış olur. Deneme hakkı 0 olduğunda ise kullanıcı kaybetmiş olur.

