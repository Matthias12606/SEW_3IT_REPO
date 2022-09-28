// See https://aka.ms/new-console-template for more information

using _02_NullabelDatatypes;

student tobias = null;      //reference type can be null

//Console.WriteLine(tobias.Name);   --> NullReferenceException, weil Tobias null ist

if(tobias != null)
{
    Console.WriteLine(tobias.Name);
}

int? i = null;          //nullable Datentyp int --> durch ?
i = 5;                  //Zuweisung zu einem nullable Datatype

int j = i.Value * 4;        //Zugriff auf i.Value nur wenn nicht null

i = null;
if (i.HasValue)              //Zugriff auf i.Value nur wenn nicht null
{
    j = i.Value * 4;
}
else
{
    j = 0;
}

//entweder

i = 6;
if (i.HasValue)         //Abfrage darf man auch weglassen, wenn ich sicher bin, dass i einen Wert hat
{
    j = i.Value * 5;
}


//oder

j = i.GetValueOrDefault() * 5;          //leifert den Wert wenn nicht NULL, sonst Default-Wert (0)
