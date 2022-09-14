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
j = i.Value * 4; 


