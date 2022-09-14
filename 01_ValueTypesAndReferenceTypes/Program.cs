// See https://aka.ms/new-console-template for more information

using _01_ValueTypesAndReferenceTypes;

void ChangeValue(int x)
{
    x = 200;            //lokale Variable eine value types --> Änderungen bleiben lokal
    Console.WriteLine(x);
}

void ChangeValueReferenceType(Student s)
{
    s.Name = "Julian";
}

int i = 100;
Console.WriteLine(i);
ChangeValue(i);
Console.WriteLine(i);

Student tobias = new Student();
tobias.Name = "Tobias";
Console.WriteLine(tobias);
ChangeValueReferenceType(tobias);
Console.WriteLine(tobias); 

