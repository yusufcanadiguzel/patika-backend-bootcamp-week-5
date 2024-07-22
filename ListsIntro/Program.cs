//Bu Pratik'te sizden ziyaretçilerin isimlerini eklediğimiz bir liste oluşturmanızı ve bu liste içerisinde for ya da foreach döngüsü ile dönerek isimlerini tek tek ekrana yazdırmanız isteniyor.

List<string> guests = new List<string>()
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın",
};

foreach (var guest in guests)
    Console.WriteLine($"{guests.IndexOf(guest) + 1} - {guest}");