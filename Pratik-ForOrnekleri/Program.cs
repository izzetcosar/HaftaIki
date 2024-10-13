

#region OnKereYazdırma

Console.WriteLine(" OnKereYazdırma");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Kendime inanıyorum,ben bu yazılım işini hallederim!");
}

Console.ReadKey();
Console.WriteLine();



#endregion

#region BirIleYirmiArasıSayılar
Console.WriteLine("Bir Ile Yirmi Arası Sayılar");

for (int a = 1;a < 20;a++)
{
    Console.WriteLine(a);
}
Console.WriteLine();
Console.ReadKey();
#endregion

#region CiftSayilar
Console.WriteLine("Cift Sayilar");
for (int b = 1; b < 20;b++)
{
    if (b%2 == 0)
    {
        Console.WriteLine(b);
    }

}
Console.WriteLine("---------------------------------------------");
Console.ReadKey();
#endregion

#region ElliIleYuzElli
Console.WriteLine("Elli Ile Yuz Elli arasındaki sayıların toplamı");

int toplam = 0;

for (int c = 50; c <=150 ; c++)
{

    toplam += c;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı ="  +  toplam);

Console.WriteLine();
Console.ReadKey();


#endregion

#region CiftTek
Console.WriteLine("1 ile 120 arasındaki tek ve çift sayıların toplamı");
int tek =0;
int cift =0;

for (int d = 1; d < 120; d++)

{
    tek += (d % 2 != 0) ? d : 0;
    cift += (d % 2 == 0) ? d : 0;

}
Console.WriteLine("Tek sayı toplamı: " + tek);
Console.WriteLine("Çift sayı toplamı: " + cift);
Console.ReadKey();


#endregion