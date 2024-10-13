#region Geriye Değer Döndürmeyen Bir void metot
static void sarkısozu()
{
    Console.WriteLine("Fısılda ismimi rüzgarla,doldur yelkenlerimi");

}
sarkısozu();
Console.ReadKey(true);
#endregion
#region Geriye Tamsayı Döndüren Bir metot
static int Rastagelekalan()

{
    Random rnd = new Random();
    int sayi = rnd.Next();
    int sayidankalan = sayi % 2;
    return sayidankalan;


}
int rastgele = Rastagelekalan();

Console.WriteLine(rastgele);
Console.ReadKey(true);

#endregion
#region Parametre Alan ve Geriye Değer Döndüren Bir Metot

static int carp(int a, int b)
{
    return a * b;
}

int carpim = carp(3, 5);

Console.WriteLine("Cevap: " + carpim);
Console.ReadKey(true);


#endregion
#region Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

static void Selamlama(string ad, string soyad)
{
    Console.WriteLine($"Hoşgeldin " + ad + " " + soyad);

}
Selamlama("İzzet", "Çoşar");

Console.ReadKey(true);
#endregion

