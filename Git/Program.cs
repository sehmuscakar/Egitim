string fullName = "Şehmus Çakar"; //bu aslında karekter dizisi, veri tabanından gelen kullaniciAdi simile edelim

string[] dizi = fullName.Trim().Split(' ');

var degiskenim=dizi[0]+" " + dizi[1][0];
var degiskenim2 = dizi[0]+" "+dizi[2][0];
Console.WriteLine(degiskenim);

if (fullName=="Şehmus Çakar") 
{

}
else if (fullName=="Şehmus  Çakar")
{
    Console.WriteLine(degiskenim2);
}
else
{
    Console.Write("lütfen kullanıcı adı alnını şu stantlarda dadoldurun Murat Kara");
}