Hafta-2 - Kapanış Soruları

Bu C# konsol uygulaması, dersin hafta-2 kapanış sorularını çözen 17 farklı örnek içermektedir. Her bir soru, metot kullanımı, döngüler, koşullar ve diziler gibi temel C# kavramlarını pekiştirmeyi amaçlar.

Gereksinimler

.NET SDK 6.0 veya üzeri (İndir)

Bir terminal/komut satırı aracı (örn. PowerShell, CMD, Terminal)

Projeyi Çalıştırma

Proje klasörüne gidin:

cd Hafta-2---Kapan-Sorular

Derleyip çalıştırın:

dotnet run

Ekrandaki sorulara sırasıyla yanıt vererek uygulamayı deneyin.

İçerik ve Soru Başlıkları

1-Temel Yazdırma: Ekrana sabit metinler yazdırma.

2-Kullanıcı Girişi: Sayı ve metin okuma, ekrana yazdırma.

3-Rastgele Sayı Üretme: 1–100 arası rastgele değer üretme.

4-Mod Alma: Rastgele sayının 3’e bölümünden kalanı kontrol etme.

5-Yaş Kontrolü: Kullanıcının yaşını alıp > 18 kontrolü.

6-For Döngüsü: Sabit bir metni 10 kez ekrana yazdırma.

7-İsim Değiş tokuşu: Değişkenleri geçici değişkene (temp) aktararak takas etme.

8-Void Metot: Geri dönüş değeri olmayan metot tanımlama ve çağırma.

9-Değer Dönüştüren Metot: İki sayının toplamını döndüren metot.

10-True/False Metot: Girilen sayıyı sabit bir değerle karşılaştırıp bool döndüren metot.

11-En Büyük Yaş: Kullanıcıdan birden çok yaş alarak en büyük değeri bulma.

12-En Büyük Sayı: Bir dizideki en büyük sayıyı bulma (kullanıcı girişiyle).

13-Ref ile Takas: ref anahtar kelimesiyle iki string parametresini takas eden metot.

14-Tek/Çift Kontrolü: Girilen sayının tek veya çift olduğuna karar veren metot.

15-Mesafe Hesaplama: Hız ve süre bilgileriyle gidilen mesafeyi hesaplayan metot.

16-Daire Alanı: Yarıçap ve π sabitini kullanarak daire alanı hesaplayan metot.

17-String İşlemleri: ToUpper(), ToLower(), Trim() metotlarının kullanımı.

Kod Yapısı

Program.Main içinde her soru başlığı altında ilgili metot çağrıları yapılıyor.

Yardımcı metotlar (BenDegerDondurmem, ToplamDeger, TrueFalse, ... ) sınıf içinde statik olarak tanımlı.

Array.Resize, Array.Sort, Array.Reverse gibi dizilerle çalışma örnekleri içermektedir.

Dikkat Edilmesi Gerekenler

Kullanıcı hatalı giriş yaptığında uygulama basitçe FormatException fırlatır. Geliştirme aşamasında TryParse ile hata denetimi eklenebilir.

Math.PI sabitini doğrudan kullanarak hassas sonuç elde edebilirsiniz.

Bu proje, temel C# kavramlarını pekiştirmeniz ve metot-döngü-koşul-dizi kullanımını öğrenmeniz için hazırlanmıştır. İyi çalışmalar!

