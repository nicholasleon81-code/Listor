//enkelt sätt att skapa en array med 10 platser. specifikt en string i detta fall kan vara Int , double, bool etc.
string[] listas = new string[10];
//specifierar att index 2 ska ha värdet "Kul"
listas[2] = "Kul";

//for loop som går igenom alla index i arrayen och skriver ut värdet på indexet om det inte är null, tomt eller whitespace.
for (int i = 0; i < listas.Length; i++)
{
    var currentItem = listas[i];
    // IsNullOrWhiteSpace kollar om det är null, tomt eller whitespace(alltså inget värde).
    if (!string.IsNullOrWhiteSpace(currentItem))
    {
        Console.WriteLine(listas[i]);
    }
}

//enkelt sätt att skapa en lista med okänd längd. Listor är dynamiska och kan växa och krympa i storlek så länge man vill.
List<string> unknownlenght =
[
    "enhet1", "enhet2", "enhet3"
];

//while loop som frågar användaren om den vill lägga till en ny produkt i listan. Ifall användaren skriver 5 så avslutas loopen och programmet.
while (true)
{
    Console.WriteLine("Vill du lägga till en ny produkt?");
    Console.WriteLine("Ifall du vill gå ut ur programmet skriv: 5");
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.Clear();
        Console.WriteLine("Skriv något giltigt");
    }
    if (input == "5")
    {
        break;
    }
    else
    {
        Console.Clear();
        unknownlenght.Add(input);
    }
}

foreach (string saker in unknownlenght)
{
    Console.WriteLine($"{saker}");

}



//try catch medod som tar hand on ifall du sätter in ett index som inte finns i arrayen.
try
{
    listas[11] = "Yippe!";

}
catch (Exception e)
{
    Console.WriteLine($"Wrong!!! : {e.Message}");
}