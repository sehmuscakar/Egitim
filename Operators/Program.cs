var fullName = "Şehmus Çakar öztürk batman";
string[] dizi = fullName.Trim().Split(' ');
var data = dizi[0] + " " + dizi[1][0];
var data2 = dizi[0] + " " + dizi[2][0];
var data3 = dizi[0] + " " + dizi[3][0];


if (fullName == "Şehmus Çakar")
{
    Console.WriteLine(data); //şehmus ç
}
else if (fullName == "Şehmus  Çakar")
{
    Console.WriteLine(data2); //şehmus ç
}
else if (fullName == "Şehmus  Çakar öztürk")
{
    Console.WriteLine(data3);//şehmus ö
}
else
{
    Console.WriteLine("Lütfen geçerli bi ad ve soyad giriniz");
}



//---------------------
/*
int stock = 10; // Stoktaki ürün sayısı
int requestedQuantity = 5; // Müşterinin istediği ürün miktarı

if (requestedQuantity <= stock)
{
    Console.WriteLine("Sipariş onaylandı. Yeterli stok var.");
}
else
{
    Console.WriteLine("Stokta yeterli ürün yok.");
}
*/

//--------------------------------------
/*
int stock = 10; // Stok miktarı
int requestedQuantity = 5; // İstenen ürün miktarı
int userBalance = 500; // Kullanıcının bakiyesi
int productPrice = 100; // Ürün fiyatı
int totalPrice = productPrice * requestedQuantity; // Toplam fiyat

if (requestedQuantity <= stock && userBalance >= totalPrice)
{
    Console.WriteLine("Sipariş onaylandı. Hem yeterli stok var hem de bakiyeniz yeterli.");
}
else
{
    Console.WriteLine("Sipariş gerçekleştirilemiyor.");
}
*/

//-------------------------------

/*
int points = 50; // Kullanıcının mevcut puanı
int earnedPoints = 20; // Alışveriş sonrası kazanılan puan

points += earnedPoints; // Kazanılan puanları mevcut puana ekle
Console.WriteLine("Toplam puanınız: " + points); // Çıktı: Toplam puanınız: 70
*/
//-----------------------
/*
int cartItems = 3; // Sepetteki ürün sayısı
cartItems++; // Bir ürün daha eklendi
Console.WriteLine("Sepetinizdeki toplam ürün sayısı: " + cartItems); // Çıktı: Sepetinizdeki toplam ürün sayısı: 4
*/

//------------------
/*
int productQuantity = 7; // Toplam ürün sayısı
if (productQuantity % 5 == 0)
{
    Console.WriteLine("İndirim kazandınız! Her 5 üründe bir indirim uygulanır.");
}
else
{
    Console.WriteLine("İndirim uygulanmadı.");
}
*/


//Kullanıcıdan iki sayı alarak aritmetik, karşılaştırma, mantıksal ve birleştirme operatörlerini kullanarak işlemler gerçekleştirmek.------------------------ operatörler

//Kullanıcıdan iki sayı al
Console.WriteLine("Birinci sayıyı girin:");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("İkinci sayıyı girin:");
double sayi2 = Convert.ToDouble(Console.ReadLine());

// Aritmetik Operatörler
double toplam = sayi1 + sayi2; // Toplama
double fark = sayi1 - sayi2;   // Çıkarma
double carpim = sayi1 * sayi2; // Çarpma
double bolum = sayi2 != 0 ? sayi1 / sayi2 : 0; // Bölme (sıfıra bölme kontrolü)

// Sonuçları yazdır
Console.WriteLine($"Toplam: {toplam}");
Console.WriteLine($"Fark: {fark}");
Console.WriteLine($"Çarpım: {carpim}");
Console.WriteLine($"Bölüm: {(sayi2 != 0 ? bolum.ToString() : "Tanımsız")}");

// Karşılaştırma Operatörleri
Console.WriteLine($"Birinci sayı, ikinci sayıdan büyük mü? {(sayi1 > sayi2)}");
Console.WriteLine($"Birinci sayı, ikinci sayıdan küçük mü? {(sayi1 < sayi2)}");
Console.WriteLine($"Birinci sayı, ikinci sayıya eşit mi? {(sayi1 == sayi2)}");

// Mantıksal Operatörler
bool isEqual = (sayi1 == sayi2);
bool isGreater = (sayi1 > sayi2);
Console.WriteLine($"Birinci sayı eşit mi ve büyük mü? {isEqual && isGreater}");

// Birleştirme Operatörleri
string mesaj = "Birinci sayı: " + sayi1 + ", İkinci sayı: " + sayi2;
Console.WriteLine(mesaj);

// Programın bitmesini bekle
Console.WriteLine("Çıkmak için bir tuşa basın...");
Console.ReadKey();