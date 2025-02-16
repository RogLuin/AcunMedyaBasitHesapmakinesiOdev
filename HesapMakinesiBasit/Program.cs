Console.WriteLine("Bir İslem Giriniz (1- Toplama, 2- Cıkarma, 3- Çarpma, 4- Bölme :");
int islem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("birinci Sayıyı Giriniz : ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
switch (islem)
{
    case 1:
        Console.WriteLine(sayi1 + sayi2);
        break;
    case 2:
        Console.WriteLine(sayi1 - sayi2);
        break;
    case 3:
        Console.WriteLine(sayi1 * sayi2);
        break;
    case 4:
        Console.WriteLine(sayi1 / sayi2);
        break;
    default:
        Console.WriteLine("Yanlış Değer Giriniz");
        break;
}
