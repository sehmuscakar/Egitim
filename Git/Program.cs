//string fullName = "Şehmus Çakar"; //bu aslında karekter dizisi, veri tabanından gelen kullaniciAdi simile edelim

//string[] dizi = fullName.Trim().Split(' ');

//var degiskenim=dizi[0]+" " + dizi[1][0];
//var degiskenim2 = dizi[0]+" "+dizi[2][0];

//foreach(var deg in degiskenim)
//{

//}

//Console.WriteLine(degiskenim);

//if (fullName=="Şehmus Çakar") 
//{

//}
//else if (fullName=="Şehmus  Çakar")
//{
//    Console.WriteLine(degiskenim2);
//}
//else
//{
//    Console.Write("lütfen kullanıcı adı alnını şu stantlarda dadoldurun Murat Kara");
//}


using Git;

string adSoyad = "şehmus                     ali        akif         ";
string[] adSoyadDizi = adSoyad.Trim().Split(' ');
string duzenlenmisKelime = "";
foreach (string kelime in adSoyadDizi)
{
    if (!string.IsNullOrEmpty(kelime))
    {
        duzenlenmisKelime += kelime.Trim() + " ";
    }
}


for (int i = 0; i < adSoyadDizi.Length; i++)
{
    if (i == adSoyadDizi.Length-1)
    {
        Console.WriteLine(duzenlenmisKelime + adSoyadDizi[i][0]);
    }
    else
    {

    }
}


var ınstance = new Teacher();
ınstance.Name = "Şehmus";
ınstance.Surname = "Çakar";
ınstance.Id = 1;
Console.WriteLine(ınstance);

var ınstance2 = new Student();
ınstance2.Name =ınstance.Name;
ınstance2.Surname =ınstance.Surname;
ınstance2.Id =ınstance.Id;
Console.WriteLine(ınstance2.Name +" "+ınstance2.Surname+" "+ınstance2.Id);

var durumLisans = 5;

if (durumLisans < 0)
{
    Console.WriteLine("lisans süreniz geçmiştir");
}
else if (durumLisans == 5)
{
    Console.WriteLine("lisans süreniz bugün bitecektir");
}
else
{
    Console.WriteLine("lisans süreniz geçmiştir");
}