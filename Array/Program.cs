// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] loans = { "kredi1", "kresi2" };
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


string[] ogrenci = new string[3];
ogrenci[0] = "şehhmus";
ogrenci[1] = "ahmet";
ogrenci[2] = "yusuf";

foreach (string s in ogrenci)
{
    Console.WriteLine(s);
}


string[] student = { "merve", "yeliz", "esra" };

for (int i = 0; i < student.Length; i++)
{
    Console.WriteLine(student[i]);
}



Console.WriteLine("-------------------------");

List<string> yeniliste = new List<string> { "ayşe", "murat", "ali", "yavuz" };
//yeniliste.Add(item: "Merve");
foreach (var s in yeniliste)
{
    Console.WriteLine(s);
}
