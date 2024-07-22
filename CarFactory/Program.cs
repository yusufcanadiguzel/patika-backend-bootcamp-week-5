using CarFactory;

bool isFinished = false;

string userDecide;

List<Car> cars = new List<Car>();

do
{
    //kullanici karari alinir
    Console.Write("Araba uretmek ister misiniz? (e/h): ");
    userDecide = Console.ReadLine()!.ToLower();

    switch (userDecide)
    {
        case "e":
            //arac uretilir ve listeye eklenir
            Car car = CreateCar();
            cars.Add(car);
            break;
        case "h":
            //araclar listelenir ve dongu sonlandirilir
            GetAllCars(cars);
            isFinished = true;
            break;
        default:
            //hata kontrolu
            Console.WriteLine("Hatali giris yaptiniz. Tekrar deneyiniz.");
            break;
    }
} while (!isFinished);

Car CreateCar()
{
    string serialNumber, brand, model, color;
    int doorCount;

    //arac bilgileri alinir
    Console.Write("Seri numarasini giriniz: ");
    serialNumber = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Markayi giriniz: ");
    brand = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Modeli giriniz: ");
    model = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Rengi giriniz: ");
    color = Console.ReadLine()!;
    Console.WriteLine();

doorCount:
    Console.Write("Kapi sayisini giriniz: ");

    //hata kontrolu
    try
    {
        doorCount = int.Parse(Console.ReadLine()!);
    }
    catch (Exception)
    {
        // hata alinirsa mesaj yazdirilir ve onceki kisma geri atlanir
        Console.WriteLine("Lutfen gecerli bir sayi giriniz.");
        goto doorCount;
    }
    Console.WriteLine();

    Car car = new Car(serialNumber, brand, model, color, doorCount);

    return car;
}

void GetAllCars(List<Car> cars)
{
    //listeki her aracın bilgileri konsola yazdirilir
    foreach (var car in cars)
    {
        Console.WriteLine("---------------------------------");
        //Console.WriteLine($"Uretim tarihi: {car.ManufactorDate}");
        Console.WriteLine($"Seri numarasi: {car.SerialNumber}");
        Console.WriteLine($"Markasi: {car.Brand}");
        //Console.WriteLine($"Modeli: {car.Model}");
        //Console.WriteLine($"Rengi: {car.Color}");
        //Console.WriteLine($"Kapi sayisi: {car.DoorCount}");
        Console.WriteLine("---------------------------------");
    }
}