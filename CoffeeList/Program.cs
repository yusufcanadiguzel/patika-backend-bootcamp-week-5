List<string> coffeeNames = new List<string>();

//kullanicidan kahve isimlerini alir
Console.Write("Lutfen sevdiginiz kahveleri aralarina virgul koyarak yaziniz: ");
var names = Console.ReadLine()!;
Console.WriteLine();

//girilen degeri parcalayarak listeye ekler
var nameList = names.Split(',');
coffeeNames.AddRange(nameList);

Console.WriteLine("Girilen Kahve Isimleri");

//listedeki degerleri yazdirir
coffeeNames.ForEach(coffeeName => Console.WriteLine($"Kahve {coffeeNames.IndexOf(coffeeName) + 1}: {coffeeName}"));