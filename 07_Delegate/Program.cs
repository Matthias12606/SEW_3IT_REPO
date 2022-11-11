Calcutation operation = new Calcutation(Addition);         //Mittels Koonstructor der Variable operation eine Methode zugewiesen

//lange Scghreibweise
int result = operation(4, 5);
Console.WriteLine(result);
operation = new Calcutation(subthraction);
result = operation(4, 5);
Console.WriteLine(result);

//kurze Schreibweise
operation = Addition;

Print printer = PrintWithLeadingSpaces;
printer(4);
printer += PrintWithLeading0;           //Zusätzlich zur bestehenden Methode auch diese noch hinzufügen
Console.WriteLine("-------------------------------------------");
printer(4);                             // 2 Methoden registriert

printer = null;                        //keine Methode mehr registiert
if(printer != null)
{
    printer(4);                         //sicherstellen das delegate Datentyp nicht null ist
}


int Addition(int x, int y)
{
    return x + y;
}

int subthraction(int x, int y)
{
    return x - y;
}
void PrintWithLeadingSpaces(int x)
{
    Console.WriteLine("       " + x);
}

void PrintWithLeading0 (int x)
{
    Console.WriteLine("0000000" + x);
}

public delegate int Calcutation(int x, int y);      //Delegate --> Datentyp
public delegate void Print(int x);


