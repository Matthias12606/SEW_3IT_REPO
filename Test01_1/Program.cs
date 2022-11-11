// See https://aka.ms/new-console-template for more information
using Test01_1;
 
Meeting SEWTest = new Meeting("SEW Test mit Herr Riegler", 2 , "Test");
Meeting ETETest = new Meeting("ETE Test mit Herr Triendl", 2, "Test");
Meeting AISTest = new Meeting("AIS Test mit Herr Zahler", 1, "Test");

Console.WriteLine(SEWTest);
Console.WriteLine(ETETest);
Console.WriteLine(AISTest);

public enum MeetingType { Private, Business}



