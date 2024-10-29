

var adSoyad = "   Şehmus Çakar   ";

string[] diziAdSoyad = adSoyad.Trim().Split(' '); // burda baştan ve sonda boşlukları aldıktan sonra bölme yap boşluğa göre 

Console.WriteLine(diziAdSoyad[0]);
Console.WriteLine(diziAdSoyad[1][0]);


//Kullanıcıdan pozitif sayılar alarak toplamını hesaplamak ve sonucu ekrana yazdırmak.-------------------- döngüler for ve foreach dizilerde anlatılacak
//double toplam = 0; // Toplamı tutacak değişken
//double sayi; // Kullanıcıdan alınacak sayı

//Console.WriteLine("Pozitif sayılar girin. Toplamak için 0 girin:");

//// Sonsuz döngü (while)
//while (true)
//{
//    // Kullanıcıdan sayı al
//    Console.Write("Bir sayı girin: ");
//    while (!double.TryParse(Console.ReadLine(), out sayi))
//    {
//        Console.WriteLine("Lütfen geçerli bir sayı girin.");
//    }

//    // Eğer kullanıcı 0 girerse döngüden çık
//    if (sayi == 0)
//    {
//        break;
//    }

//    // Pozitif sayıları toplama ekle
//    if (sayi > 0)
//    {
//        toplam += sayi;
//    }
//    else
//    {
//        Console.WriteLine("Lütfen pozitif bir sayı girin.");
//    }
//}

//// Toplam sonucu ekrana yazdır
//Console.WriteLine($"Girdiğiniz pozitif sayıların toplamı: {toplam}");

//// Programın bitmesini bekle
//Console.WriteLine("Çıkmak için bir tuşa basın...");
//Console.ReadKey();

//Kullanıcıdan sayılar alarak bunları hem bir diziye hem de bir listeye eklemek ve bazı temel işlemler gerçekleştirmek.------------ diziler ve listeler burda öncesinde diziler ve listeleri anlat mutlaka bu zor bir örnek
// Kullanıcıdan kaç sayı gireceğini al
//Console.WriteLine("Kaç sayı gireceksiniz?");
//int n;
//while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
//{
//    Console.WriteLine("Lütfen geçerli bir pozitif sayı girin:");
//}

//// Dizi ve liste tanımla
//int[] sayiDizisi = new int[n];
//List<int> sayiListesi = new List<int>();

//// Kullanıcıdan sayıları al
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{i + 1}. sayıyı girin: ");
//    while (!int.TryParse(Console.ReadLine(), out sayiDizisi[i]))
//    {
//        Console.WriteLine("Lütfen geçerli bir sayı girin:");
//    }

//    // Listeye de ekle
//    sayiListesi.Add(sayiDizisi[i]);
//}

//// Toplam ve ortalama hesapla
//int toplam = 0;
//foreach (int sayi in sayiDizisi)
//{
//    toplam += sayi;
//}
//double ortalama = toplam / (double)n;

//// En büyük ve en küçük sayıyı bul
//int enBuyuk = sayiDizisi[0];
//int enKucuk = sayiDizisi[0];

//foreach (int sayi in sayiDizisi)
//{
//    if (sayi > enBuyuk)
//    {
//        enBuyuk = sayi;
//    }
//    if (sayi < enKucuk)
//    {
//        enKucuk = sayi;
//    }
//}


//// Sonuçları yazdır
//Console.WriteLine($"Toplam: {toplam}");
//Console.WriteLine($"Ortalama: {ortalama:F2}");
//Console.WriteLine($"En Büyük: {enBuyuk}");
//Console.WriteLine($"En Küçük: {enKucuk}");

//// Programın bitmesini bekle
//Console.WriteLine("Çıkmak için bir tuşa basın...");
//Console.ReadKey();

//Asal sayı bulma örneği *********************************************************************************************

//if (IsPrimeNumber(7))
//{
//    Console.WriteLine("bu bir asal değildir saydır.");
//}
//else
//{
//    Console.WriteLine("bu bir asal sayıdır.");
//}

//bool IsPrimeNumber(int number)
//{
//    bool result = true;
//    for (int i = 2; i < number - 1; i++)
//    {
//        if (number % i==0)
//        {
//            result = false; // bu demeki asal sayı değil 
//            //break;//ya bu 
//            i = number; // ya bu yoksa döngüden çıkmayız
//        }
//    }
//    return true; //buraya gelirse zaten if içine düşmemiştir.
//}
////-----------------------------------------------------------------------------------

//// string :metinsel verileri tutar ve char array tabanlı dizilerdir

//string name = "Şehmus";

//Console.WriteLine(name[0]); //gürüldüğü gibi stringler bir veri türü olsa bile char tabanlı arraylerdir.

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}

//char kareter = 'k'; //tek tırnak içinde alır
//Console.WriteLine(kareter);

//// değişken tanımlamak ve field (alan) tanımlamak ayın şey 
