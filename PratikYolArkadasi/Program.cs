bool devamEt = true; // Programın devam edip etmeyeceğini kontrol eden değişken

while (devamEt)
{
    // Lokasyon bilgileri
    string[] lokasyonlar = { "Bodrum", "Marmaris", "Çeşme" };
    int[] fiyatlar = { 4000, 3000, 5000 }; // Lokasyon paket başlangıç fiyatları

    string lokasyon = ""; // Kullanıcının seçtiği lokasyon
    int kisiSayisi = 0;   // Tatil planlanan kişi sayısı
    int lokasyonFiyati = 0;

    // Kullanıcıdan lokasyon seçimi al
    bool lokasyonGecerli = false;
    while (!lokasyonGecerli)
    {
        Console.Write("Lütfen gitmek istediğiniz lokasyonu seçiniz (Bodrum, Marmaris, Çeşme): ");
        lokasyon = Console.ReadLine().ToLower(); // Girdiği değeri küçük harfe çevir

        switch (lokasyon)
        {
            case "bodrum":
                lokasyonFiyati = fiyatlar[0];
                lokasyonGecerli = true;
                break;
            case "marmaris":
                lokasyonFiyati = fiyatlar[1];
                lokasyonGecerli = true;
                break;
            case "çeşme":
                lokasyonFiyati = fiyatlar[2];
                lokasyonGecerli = true;
                break;
            default:
                Console.WriteLine("Hatalı lokasyon girdiniz. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
                break;
        }
    }

    // Kullanıcıdan kişi sayısı al
    Console.Write("Kaç kişi için tatil planlamak istiyorsunuz?: ");
    kisiSayisi = int.Parse(Console.ReadLine());

    // Seçilen lokasyon ve kişi sayısı ile ilgili bilgi yazdır
    Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon.ToUpper()}");
    Console.WriteLine($"Kişi sayısı: {kisiSayisi}");

    // Ulaşım seçenekleri
    int ulasimTutari = 0;
    bool ulasimGecerli = false;
    while (!ulasimGecerli)
    {
        Console.WriteLine("Tatilinize nasıl gitmek istersiniz?");
        Console.WriteLine("1 - Kara yolu (Kişi başı gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı gidiş-dönüş 4000 TL)");
        Console.Write("Lütfen 1 veya 2 olarak seçiminizi yapınız: ");
        string ulasimSecimi = Console.ReadLine();

        switch (ulasimSecimi)
        {
            case "1":
                ulasimTutari = 1500;
                ulasimGecerli = true;
                break;
            case "2":
                ulasimTutari = 4000;
                ulasimGecerli = true;
                break;
            default:
                Console.WriteLine("Hatalı bir seçim yaptınız. Lütfen 1 ya da 2 seçiniz.");
                break;
        }
    }

    // Toplam maliyet hesaplama
    int toplamFiyat = (lokasyonFiyati * kisiSayisi) + (ulasimTutari * kisiSayisi);

    // Sonuçları ekrana yazdır
    Console.WriteLine("Tatil Planınız:");
    Console.WriteLine($"Lokasyon: {lokasyon.ToUpper()}");
    Console.WriteLine($"Kişi Sayısı: {kisiSayisi}");
    Console.WriteLine($"Ulaşım: {(ulasimTutari == 1500 ? "Kara yolu" : "Hava yolu")}");
    Console.WriteLine($"Toplam Tutar: {toplamFiyat} TL");

    // Başka bir tatil planlamak isteyip istemediğini sor
    Console.Write("Başka bir tatil planlamak ister misiniz? (Evet/Hayır): ");
    string devamCevap = Console.ReadLine().ToLower();

    if (devamCevap != "evet")
    {
        devamEt = false;
        Console.WriteLine("İyi günler dileriz!");
    }
    Console.ReadKey();
}