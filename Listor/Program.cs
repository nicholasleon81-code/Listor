string[] listas = new string[10];
listas[2] = "Bajs";

for (int i = 0; i < listas.Length; i++)
{
    var currentItem = listas[i];
    if (!string.IsNullOrWhiteSpace(currentItem))
    {
        Console.WriteLine(listas[i]);
    }
}

List<string> unknownlenght =
[
    "enhet1", "enhet2", "enhet3"
];

// var myNewArray = unknownlenght.ToArray();
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




try
{
    listas[11] = "Yippe!";

}
catch (Exception e)
{
    Console.WriteLine($"Wrong!!! : {e.Message}");
}