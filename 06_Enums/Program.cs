
DayOfWeek startOfWeek = DayOfWeek.Monday;
Classes bestClassATFJ = Classes.IT20;

Console.WriteLine("Beste Klasse des FJ: " + bestClassATFJ);
Console.WriteLine("Beste Klasse des FJ: " + (int)bestClassATFJ);


printSTimes(bestClassATFJ);
printSTimes(Classes.IT19);

void printSTimes(Classes c)
{
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(c);
    }
}

public enum Classes { IT19, IT20, IT21, IT22 }      //entsprechen den Zahlen 0,1,2,3

//RGB: 255  0   0   || #FF0000  ||  16711680
public enum Color { Red = 16711680, Green = 65280, Blue = 255 }     //nur sinvoll, wenn dan irgendwann auf int gecastet wird  

