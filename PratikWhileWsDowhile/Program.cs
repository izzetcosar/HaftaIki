#region while
Console.Write("Bir limit değeri giriniz: ");
int limit = int.Parse(Console.ReadLine()); // Kullanıcıdan limit değeri alıyoruz
int sayac = 0; // Sayaç başlangıcı 0

while (sayac <= limit) // Sayaç, limit değerine ulaşana kadar döngü devam eder
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++; // Sayaç 1er 1 er arttırılıyor
}

Console.ReadKey();
#endregion

#region dowhile
Console.Write("Bir limit değeri giriniz: ");
int limit2 = int.Parse(Console.ReadLine()); // Kullanıcıdan limit değeri al
int sayac2 = 0; // Sayaç başlangıcı 0

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++; // Sayaç artırılır
}
while (sayac2 <= limit2); // Sayaç, limit değerine ulaşana kadar döngü devam eder
Console.ReadKey();
#endregion



//while ile programı yaptığımızda - değer atadıgımızda programi sonlandırıyor
//do while ile yaptıgımızda ekrana do kısmındaki çıktıyı yazdırıp sonrasında programı sonlandırıyor.
