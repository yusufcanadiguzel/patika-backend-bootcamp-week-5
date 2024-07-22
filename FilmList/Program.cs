using MovieList;

bool isFinished = false;

string name, userDecide;

double rating;

List<Movie> movies = new List<Movie>();

//kullanici kontrolunde veri girisi
do
{
    //kullanicidan film ismini alir
    Console.Write("Lutfen filmin ismini giriniz: ");
    name = Console.ReadLine()!;

    //kullanicidan film puanini alir
    Console.Write("Lutfen filmin puanini giriniz: ");
    rating = double.Parse(Console.ReadLine()!);

    //film listesine ekleme yapar
    movies.Add(new Movie(name: name, rating: rating));

    //kullaniciya ekleme islemine devam etmek istedigini sorar
    Console.Write("Yeni bir film eklemek ister misiniz? (e/h): ");
    userDecide = Console.ReadLine()!;
    Console.WriteLine();

    //cevaba gore donguyu sonlandirir
    isFinished = (userDecide == "e") ? false : true;
}
while (!isFinished);

//tum filmleri listeler
Console.WriteLine("Tum Filmler");
movies.ForEach(movie => Console.WriteLine($"Film ismi: {movie.Name} Puanı: {movie.Rating}"));
Console.WriteLine();

//puani 4 ile 9 arasinda olan filmleri listeler
Console.WriteLine("Puani 4 ile 9 Arasinda Olan Filmler: ");
var tempMovieList = movies.Where(movie => (movie.Rating >= 4.0) && (movie.Rating <= 9.0));
foreach (var movie in tempMovieList)
{
    Console.WriteLine($"Film ismi: {movie.Name} Puanı: {movie.Rating}");
}
Console.WriteLine();

//A harfi ile baslayan filmleri listeler
Console.WriteLine("Ismi 'A' ile Baslayan Filmler");
tempMovieList = movies.Where(movie => movie.Name.StartsWith('A'));
foreach (var movie in tempMovieList)
{
    Console.WriteLine($"Film ismi: {movie.Name} Puanı: {movie.Rating}");
}
Console.WriteLine();