using PolymorphismPratik;

// Kare nesnesi oluşturma ve alan hesaplama
Kare kare = new Kare() { Genislik = 5, Yukseklik = 5 };
Console.WriteLine("Karenin Alanı: " + kare.AlanHesapla());

// Dikdörtgen nesnesi oluşturma ve alan hesaplama
Dikdortgen dikdortgen = new Dikdortgen() { Genislik = 5, Yukseklik = 10 };
Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla());

// Dik üçgen nesnesi oluşturma ve alan hesaplama
DikUcgen dikUcgen = new DikUcgen() { Genislik = 5, Yukseklik = 10 };
Console.WriteLine("Dik Üçgenin Alanı: " + dikUcgen.AlanHesapla());