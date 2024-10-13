static int Carpim(int x, int y) // Parametre olarak alınan x ve y'nin çarpımını geri döndürüyoruz
{
    return x * y;
}

int sonuc = Carpim(3, 5); // Carpim metodunu çağırıyoruz ve 3 ile 5'in çarpımını hesaplıyoruz
Console.WriteLine("Çarpım: " + sonuc); //Çarpım sonucunu ekrana yazdırıyoruz
