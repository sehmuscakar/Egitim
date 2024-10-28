int stock = 10; // Stoktaki ürün sayısı
int requestedQuantity = 5; // Müşterinin istediği ürün adedi

if (requestedQuantity <= stock)
{
    Console.WriteLine("Sipariş onaylandı. Yeterli stok var.");
}

//Bu örnekte, müşterinin istediği ürün adedi stokta varsa (koşul doğruysa), sipariş onaylanır ve bir mesaj gösterilir.

if (requestedQuantity <= stock)
{
    Console.WriteLine("Sipariş onaylandı. Yeterli stok var.");
}
else
{
    Console.WriteLine("Stokta yeterli ürün yok. Sipariş iptal edildi.");
}

//Bu örnekte, eğer stokta yeterli ürün yoksa (koşul yanlışsa), sipariş iptal edilir ve farklı bir mesaj gösterilir.

/*
int stock = 10; // Stok miktarı
int requestedQuantity = 12; // Müşterinin istediği ürün adedi

if (requestedQuantity <= stock)
{
    Console.WriteLine("Sipariş onaylandı.");
}
else if (requestedQuantity > stock && stock > 0)
{
    Console.WriteLine("Yeterli stok yok, ancak elimizde olan miktar kadar gönderim yapabiliriz.");
}
else
{
    Console.WriteLine("Stokta hiç ürün yok.");
}

//Bu örnekte, müşterinin istediği ürün adedi stoktan fazlaysa ama stokta bir miktar varsa (ikinci koşul doğruysa), stoktaki ürün kadar gönderim yapılabileceği mesajı gösterilir.
//Stokta hiç ürün yoksa (her iki koşul da yanlışsa), ürün gönderilemeyeceği belirtilir.

*/



/*
int stock = 10; // Stok miktarı
int requestedQuantity = 5; // İstenen ürün adedi
int userBalance = 300; // Kullanıcının bakiyesi
int productPrice = 50; // Ürün fiyatı
int totalPrice = productPrice * requestedQuantity; // Toplam fiyat

if (requestedQuantity <= stock && userBalance >= totalPrice)
{
    Console.WriteLine("Sipariş onaylandı. Yeterli stok var ve bakiyeniz yeterli.");
}
else
{
    Console.WriteLine("Sipariş gerçekleştirilemedi.");
}
//Bu örnekte, siparişin onaylanması için hem yeterli stok olması hem de kullanıcının bakiyesinin yeterli olması gerekiyor. İki koşul da doğruysa sipariş onaylanır.


*/


/*
//Örnek (Veya operatörü ||):
bool isPromoActive = true; // Promosyon durumu
bool isUserPremium = false; // Kullanıcı premium üye mi?

if (isPromoActive || isUserPremium)
{
    Console.WriteLine("Kampanya indiriminden faydalanabilirsiniz.");
}
else
{
    Console.WriteLine("Kampanya indiriminden faydalanamazsınız.");
}

//Bu örnekte, kullanıcının kampanya indiriminden faydalanabilmesi için ya promosyonun aktif olması ya da kullanıcının premium üye olması gerekiyor. Koşullardan biri doğruysa indirim uygulanır.
*/

/*
string paymentMethod = "creditcard"; // Ödeme yöntemi

switch (paymentMethod)
{
    case "creditcard":
        Console.WriteLine("Kredi kartıyla ödeme yapıldı.");
        break;
    case "paypal":
        Console.WriteLine("PayPal ile ödeme yapıldı.");
        break;
    case "cash":
        Console.WriteLine("Nakit ödeme yapıldı.");
        break;
    default:
        Console.WriteLine("Geçersiz ödeme yöntemi.");
        break;
}

//Bu örnekte, ödeme yöntemi creditcard, paypal veya cash olabilir. paymentMethod değişkenine göre farklı ödeme mesajları gösterilir.
*/


/*
int stock = 5; // Stok miktarı
string message = (stock > 0) ? "Ürün stokta var." : "Ürün stokta yok.";
Console.WriteLine(message);

//Bu örnekte, stok miktarına göre tek satırlık bir if-else yapısıyla mesaj belirlenir.
 */

//Kullanıcıdan bir sayı alarak bu sayının pozitif, negatif veya sıfır olup olmadığını kontrol etmek ve 1-10 arası bir sayı girdiğinde gün ismini yazdırmak.---------------------- Mantık / Kontrol yapıları
// Kullanıcıdan bir sayı al
//Console.WriteLine("Bir sayı girin:");
//double sayi;

//while (!double.TryParse(Console.ReadLine(), out sayi))
//{
//    Console.WriteLine("Lütfen geçerli bir sayı girin:");
//}

//// Sayının pozitif, negatif veya sıfır olduğunu kontrol et
//if (sayi > 0)
//{
//    Console.WriteLine("Girdiğiniz sayı pozitif.");
//}
//else if (sayi < 0)
//{
//    Console.WriteLine("Girdiğiniz sayı negatif.");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz sayı sıfır.");
//}

//// Kullanıcıdan bir gün numarası al
//Console.WriteLine("1 ile 10 arasında bir sayı girin (1: Pazartesi, 2: Salı, ... 7: Pazar, 8-10: Geçersiz):");
//int gunNumarasi;

//while (!int.TryParse(Console.ReadLine(), out gunNumarasi) || gunNumarasi < 1 || gunNumarasi > 10)
//{
//    Console.WriteLine("Lütfen 1 ile 10 arasında geçerli bir sayı girin:");
//}

//// Gün numarasına göre gün ismini belirle
//string gun;

//switch (gunNumarasi)
//{
//    case 1:
//        gun = "Pazartesi";
//        break;
//    case 2:
//        gun = "Salı";
//        break;
//    case 3:
//        gun = "Çarşamba";
//        break;
//    case 4:
//        gun = "Perşembe";
//        break;
//    case 5:
//        gun = "Cuma";
//        break;
//    case 6:
//        gun = "Cumartesi";
//        break;
//    case 7:
//        gun = "Pazar";
//        break;
//    default:
//        gun = "Geçersiz gün numarası.";
//        break;
//}

//// Gün ismini ekrana yazdır
//Console.WriteLine($"Gün: {gun}");

//// Programın bitmesini bekle
//Console.WriteLine("Çıkmak için bir tuşa basın...");
//Console.ReadKey();

//------------------------------------------------------------------------------------------------------------------------------------------------
//Piyasa altınin meselsi simule dedilmiştir
int piyasaDun = 15;
int piyasaBugun = 16;

var durum = piyasaDun > piyasaBugun; //burda bir hesaplama olur ya ture yada false ataması olur aslında

string artışOku = "Artış Oku";// birden fazla yerde kullanmak için 
string azalışOKu = "Azalış Oku";
string sabitOku = "Sabit";

if (piyasaDun > piyasaBugun)
{
    Console.WriteLine(artışOku);
}


if (durum==true)
{
    Console.WriteLine("Artış Oku");
}

if (durum == false)
{
    Console.WriteLine("Azalış Oku");

}
//yada

if (durum == true)
{
    Console.WriteLine("Artış Oku");
}
else
{
    Console.WriteLine("Azalış Oku");

}
// yada

if (durum != true)// en çok bu kullanılr piyasada burda iki durum var ama daha fazla olasasıklarda bu kullanlır
{
    Console.WriteLine("Artış Oku");
}
else
{
    Console.WriteLine("Azalız Oku");

}
//--------

if (piyasaBugun>piyasaDun)
{
    Console.WriteLine(artışOku);

}
else if (piyasaBugun == piyasaDun)
{
    Console.WriteLine("Bugun piyasa eşitir.");
}
else
{
    Console.WriteLine("Azalış Oku");

}

