int number;
bool isFinished = false;

do
{
    Console.Write("Lutfen bir sayi giriniz: ");

    //hata kontrolu
    try
    {
        //kullanicidan giris alma
        number = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Girilen sayinin karesi: {Math.Pow(number, 2)}");

        isFinished = true;
    }
    catch (Exception exception)
    {
        // hata mesaji
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        Console.WriteLine($"Hata mesajı: {exception.Message}");
    }

    
} while (!isFinished);