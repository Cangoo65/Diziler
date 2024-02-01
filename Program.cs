int[] sayilar = new int[3];
sayilar[0]= 100;
sayilar[1] = 50;
sayilar[2] = 15;

foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs" };

foreach (var ay in aylar)
{
    Console.WriteLine(ay);
}
Console.Read();
