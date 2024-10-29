// Mağaza için ürün bilgileri
/*
string urunAdi = "Laptop"; // Ürün adı, string türünde
double urunFiyati = 8999.99; // Ürün fiyatı, double türünde
int stokMiktari = 25; // Stoktaki ürün sayısı, int türünde
bool stoktaVarMi = true; // Ürün stokta mı, bool türünde
char kategoriKodu = 'E'; // Ürünün kategorisi, char türünde (Elektronik kategorisi)

Console.WriteLine($"Ürün Adı: {urunAdi}");
Console.WriteLine($"Fiyat: {urunFiyati} TL");
Console.WriteLine($"Stok Miktarı: {stokMiktari}");
Console.WriteLine($"Stok Durumu: {(stoktaVarMi ? "Stokta var" : "Stokta yok")}");
Console.WriteLine($"Kategori: {kategoriKodu}");
*/
//---------------------------------------------------------------
//Kullanıcıdan kişisel bilgileri alarak bunları farklı veri türlerinde saklayıp ekrana yazdırmak.----------------------------------------------- veri türleri ve değişkenler

// Değişkenler (farklı veri türleri)

//type safety -tip güvenliği
string isim;
int yas;
bool cinsiyet; // true: Erkek, false: Kadın
double boy;
double kilo;

//Kullanıcıdan bilgi al
Console.WriteLine("Lütfen isminizi girin:");
isim = Console.ReadLine();

Console.WriteLine("Lütfen yaşınızı girin:");
while (!int.TryParse(Console.ReadLine(), out yas) || yas <= 0)
{
    Console.WriteLine("Lütfen geçerli bir yaş girin:");
}

Console.WriteLine("Cinsiyetinizi belirtin (E/K):");
string cinsiyetGirdisi = Console.ReadLine().ToUpper();
cinsiyet = (cinsiyetGirdisi == "E");

Console.WriteLine("Lütfen boyunuzu (metre cinsinden) girin:");
while (!double.TryParse(Console.ReadLine(), out boy) || boy <= 0)
{
    Console.WriteLine("Lütfen geçerli bir boy girin:");
}

Console.WriteLine("Lütfen kilonuzu (kg cinsinden) girin:");
while (!double.TryParse(Console.ReadLine(), out kilo) || kilo <= 0)
{
    Console.WriteLine("Lütfen geçerli bir kilo girin:");
}

// Bilgileri ekrana yazdır
Console.WriteLine("\n--- Kişisel Bilgi ---");
Console.WriteLine($"İsim: {isim}");
Console.WriteLine($"Yaş: {yas}");
Console.WriteLine($"Cinsiyet: {(cinsiyet ? "Erkek" : "Kadın")}");
Console.WriteLine($"Boy: {boy:F2} m");
Console.WriteLine($"Kilo: {kilo:F2} kg");

// Programın bitmesini bekle
Console.WriteLine("Çıkmak için bir tuşa basın...");
Console.ReadKey();


//do not repeat yourself - kendini tekrarlama 
var isim1 = "şehmus";
Console.WriteLine("şehmus");
Console.WriteLine("şehmus");
Console.WriteLine("şehmus");
Console.WriteLine(isim);
Console.WriteLine(isim);
Console.WriteLine(isim);// bu şekilde kullanman daha iyi