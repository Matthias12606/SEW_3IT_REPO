int i = int.Parse("523");
//int j = int.Parse("Hello World");         //Laufzeitfehler
int n;

Console.Write("Bitte eine Zahl eingeben: ");
string input = Console.ReadLine();  

bool parsed = int.TryParse("HelloWorld", out n);
if (parsed == false)
{
    Console.WriteLine("Konnte Eingabe nicht in Zahl umwandeln");
}else
{
    Console.WriteLine(n);
}
