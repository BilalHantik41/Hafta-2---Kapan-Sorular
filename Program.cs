using System;
using System.Reflection.Metadata.Ecma335;

namespace HaftaKapaniş
{
    class Program
    {
        public static void Main(string[] args)
        {   


            


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 1. Soru -------");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Merhaba");
            Console.WriteLine("Nasilsin");
            Console.WriteLine("İyiyim");
            Console.WriteLine("Sen Nasilsin?");

            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 2. Soru -------");
            Console.WriteLine("-----------------------");

            int a;
            string b;
            Console.WriteLine("Bir Sayi Giriniz: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir Metin Giriniz: ");
            b = Console.ReadLine();

            Console.WriteLine("Girilen Sayi: " + a);
            Console.WriteLine("Girilen Metin: " + b);

            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 3. Soru -------");
            Console.WriteLine("-----------------------");

            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);

            Console.WriteLine($"1–100 arasında üretilen rastgele sayı: {randomNumber}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 4. Soru -------");
            Console.WriteLine("-----------------------");

            Random number = new Random();
            randomNumber = number.Next(1, 101);
            if (randomNumber % 3 == 0)
            {
                Console.WriteLine("Random sayinin 3'e bölümünden kalan 0'dir. ");
                Console.WriteLine("Random sayi : " + randomNumber);
            }
            else
            {
                Console.WriteLine("Random sayinin 3'e bölümünden kalan 0 değildir.");
            }



            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 5. Soru -------");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Yaşinizi Giriniz: ");
            int age = int.Parse(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("+");

            }
            else
            {
                Console.WriteLine("-");
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 6. Soru -------");
            Console.WriteLine("-----------------------");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 7. Soru -------");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Lütfen Bir Metin giriniz: ");
            string z = Console.ReadLine();
            Console.WriteLine("Lütfen Bir Metin giriniz: ");
            string d = Console.ReadLine();

            Console.WriteLine($"Önce: z = {z}, d = {d}");
            string temp = z;
            // 2. adım: z’ya d’nin değerini atıyoruz
            z = d;
            // 3. adım: d’ye temp’in (yani orijinal a’nın) değerini atıyoruz
            d = temp;

            Console.WriteLine($"Sonra: z = {z}, d = {d}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 8. Soru -------");
            Console.WriteLine("-----------------------");
            BenDegerDondurmem();


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 9. Soru -------");
            Console.WriteLine("-----------------------");

            int result = ToplamDeger(25, 35);
            Console.WriteLine("Toplam: " + result);


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 10. Soru -------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Sayiyi Tahmin et");
            int tahmin = int.Parse(Console.ReadLine());
            TrueFalse(tahmin);

            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 11. Soru -------");
            Console.WriteLine("-----------------------");
           
            int enBuyukYas = yasSiralamasi();
            Console.WriteLine($"Girilen yaşlar arasında en büyük değer: {enBuyukYas}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 12. Soru -------");
            Console.WriteLine("-----------------------");
            
            
            int enBüyükDeger = enBüyükSayi();
            Console.WriteLine($"Girilen sayilar arasında en büyük değer: {enBüyükDeger}");


            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 13. Soru -------");
            Console.WriteLine("-----------------------");
            
            Console.Write("Birinci ismi girin: ");
            string isim1 = Console.ReadLine();
            
            Console.Write("İkinci ismi girin: ");
            string isim2 = Console.ReadLine();

            Console.WriteLine("Girilen isimler sirasiyla : " + isim1 +" "+isim2);

            // 2. Metot çağrısı ile isimlerin yerlerini değiştir
            changeName(ref isim1, ref isim2);

            // 3. Sonucu ekrana yazdır
            Console.WriteLine("Yerleri Değişmiş Halde: " + isim1 + " " + isim2);

            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 14. Soru -------");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Bir Sayi Giriniz: ");
            int number1= int.Parse(Console.ReadLine());
            tekCift(number1);

            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 15. Soru -------");
            Console.WriteLine("-----------------------");
                

            Console.WriteLine("Lütfen Kaç Km Hizla gittiğinizi belirtiniz: ");
            double speed = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Araç Kullandığınız süreyi belirtiniz: ");
            double time = double.Parse(Console.ReadLine());
            double distance = hizZaman(speed, time);
            Console.WriteLine($"Gidilen mesafe: {distance} km");
            
            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 16. Soru -------");
            Console.WriteLine("-----------------------");
            double Pi = Math.PI;
            Console.WriteLine("Lütfen Daire'nin Yariçapini Giriniz: ");
            double number3= double.Parse(Console.ReadLine());
            double circleArea=daireAlani(number3, Pi);
            Console.WriteLine("Daire'nin Alani: "+ circleArea);
        
            Console.WriteLine("-----------------------");
            Console.WriteLine("------- 17. Soru -------");
            Console.WriteLine("-----------------------");
            
            string text = "Zaman bir GeRi SayIm";
            string upperCaseText = text.ToUpper();
            string lowerCaseText = text.ToLower();
            Console.WriteLine(upperCaseText);
            Console.WriteLine(lowerCaseText);

            string text1 = "    Selamlar   ";
            string trimmedText = text1.Trim();

            Console.WriteLine(trimmedText); // "Merhaba"

        }

        public static void BenDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
        }

        public static int ToplamDeger(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static bool TrueFalse(int tahmin)
        {
            if (tahmin == 14)
            {
                Console.WriteLine("Tahmin Başarili");
                return true;
            }
            else
            {
                Console.WriteLine("Tahmin Başarisiz.");
                return false;
            }
        }
        public static int yasSiralamasi()
        {
            int[] ages = new int[0];


            while (true)
            {
                Console.WriteLine("Yaşlarinizi Giriniz: ");
                int age = int.Parse(Console.ReadLine());
                Array.Resize(ref ages, ages.Length + 1);
                ages[ages.Length - 1] = age;
                Console.WriteLine("Döngüden Çikmak için h basiniz. Yaş eklemeye devam etmek için yaş giriniz: ");
                string check = Console.ReadLine();
                if (check == "h")
                    break;

            }


            Array.Sort(ages);
            Array.Reverse(ages);
            Console.WriteLine(ages);
            return ages[0];
        }

        public static int enBüyükSayi()
        {
            int[] numberHigh = new int[0];


            while (true)
            {
                Console.WriteLine("Sayi Giriniz: ");
                int num = int.Parse(Console.ReadLine());
                Array.Resize(ref numberHigh, numberHigh.Length + 1);
                numberHigh[numberHigh.Length - 1] = num;
                Console.WriteLine("Döngüden Çikmak için h basiniz. Sayi eklemeye devam etmek için sayi giriniz: ");
                string check = Console.ReadLine();
                if (check == "h")
                    break;

            }


            Array.Sort(numberHigh);
            Array.Reverse(numberHigh);
            Console.WriteLine(numberHigh);
            return numberHigh[0];


        }
        public static void changeName(ref string a, ref string b)
        {


            string name = a;
            a = b;
            b = name;


        }
        public static bool tekCift(int number1)
        {
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Tahmin Başarili");
                return true;
            }
            else
            {
                Console.WriteLine("Tahmin Başarisiz.");
                return false;
            }
        }

        public static double hizZaman(double speed, double time)
        {

            return (speed * time);
        }

        public static double daireAlani(double number3, double Pi)
        { 
            
            return Math.Pow(number3, 2)* double.Pi;

        }
        
        

    }
}