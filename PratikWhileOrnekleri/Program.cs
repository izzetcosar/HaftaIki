
#region 10 kere yazma
int i = 0;

while (i<10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;

}
Console.WriteLine();
Console.ReadKey();


#endregion

#region 1-20 arası sayılar

int a = 1;
while(a<20)
{
    Console.WriteLine(a);
    a++;
}
Console.WriteLine();
Console.ReadKey();

#endregion

#region 1-20 arası çift sayılar

int b = 1;
while(b<20)
{
    if(b%2==0)
    {
        Console.WriteLine(b);
    }
    b++;

}
Console.WriteLine();
Console.ReadKey();

#endregion

#region 50-150 arası sayıların toplamı

int sonuc = 0;
int c = 50;
while(c<150)
{
    sonuc += c;
    c++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + sonuc );
Console.WriteLine();
Console.ReadKey();



#endregion

#region  1 ile 120 arasındaki tek ve çift sayılar

int tektoplam = 0;
int cifttoplam = 0;
int d = 1;
while (d <= 120)
{

    if (d % 2 == 0)
    {
        cifttoplam += d;
    }

    else
    {
        tektoplam += d;
    }
    d++;


}
Console.WriteLine("Tek sayıların toplamı: " + tektoplam);
Console.WriteLine("Çift sayıların toplamı: " + cifttoplam);
Console.WriteLine();
Console.ReadKey();


#endregion