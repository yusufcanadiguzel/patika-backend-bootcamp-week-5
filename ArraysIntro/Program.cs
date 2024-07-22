//1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
int[] tempNumbers = new int[10];

Random random = new Random();

for (int i = 0; i < tempNumbers.Length; i++)
    tempNumbers[i] = random.Next(1, 101);

//2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.
foreach (int tempNumber in tempNumbers)
    Console.WriteLine(tempNumber);

//3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
Console.Write("Lutfen bir tam sayi giriniz: ");
var userNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine();

//yeni bir eleman ekleneceği için yeni bir array oluşturup eski arraydeki datayı yenisine kopyalayıp üstüne kullanıcıdan aldığımız datayı ekledik
int[] numbers = new int[11];
tempNumbers.CopyTo(numbers, 0);
numbers[10] = userNumber;

//4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
Array.Sort(numbers);
foreach (int number in numbers)
    Console.WriteLine(number);