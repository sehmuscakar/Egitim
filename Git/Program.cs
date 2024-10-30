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


string fullName1 = "şehmus  ali akif yılmaz";
string[] dizi2= fullName1.Trim().Split(' ');

Console.WriteLine(dizi2[2]);
foreach (string dizi in dizi2)
{
    //boşlukları sil ve öğe biri yazdır
   // dizi.Replace(" ", " admin").
    Console.WriteLine(dizi.Replace(" ",""));

}

//for (int i = 0; i < dizi2.Length; i++)
//{
//    Console.WriteLine(dizi2[i] + "" + dizi2[i][0]);
//}
