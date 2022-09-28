using _03_CallByValueCallByReference;

void SwapD(double a, double b)
{
    double temp = a;
    a = b;
    b = temp;
}

void SwapDRef(ref double a, ref double b)
{
    double temp = a;
    a = b;
    b = temp;
}

void SwapS( Student a, Student b)
{
    Student temp = a;
    a = b;
    b = temp;
}

void SwapSRef(ref Student a, ref Student b)
{
    Student temp = a;
    a = b;
    b = temp;
}

void SwapNameS(Student a, Student b)
{
    string temp = a.Name;
    a.Name = b.Name;
    b.Name = temp;
}

double a = 5.0;
double b = 4.0;

SwapD(a, b);                // a und b werden nicht vertauscht, weil Argumente als Parameter übergeben und nach außen sichtbar sind
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

Student matthias = new Student() { Name = "Matthias" };
Student florian = new Student() { Name = "Florian" };
SwapS(matthias, florian);           // a und b werden nicht vertauscht, weil Argumente als Parameter übergeben und nach außen sichtbar sind
Console.WriteLine("matthias = " + matthias);
Console.WriteLine("florian = " + florian);

SwapNameS(matthias, florian);       //a und b werden vertauscht, weil die "Änderung" auf Datenkomponenten des Objekts stattfinden
Console.WriteLine("Matthias = " + matthias);
Console.WriteLine("Florian = " + florian);

SwapDRef(ref a, ref b);            // a und b werden vertauscht, weil Argumente als Referenc (ref) übergeben werden
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);

SwapSRef(ref matthias, ref florian);         // matthias und florian werden vertauscht, weil Argumente als Referenc (ref) übergeben werden
Console.WriteLine("matthias = " + matthias);
Console.WriteLine("florian = " + florian);
