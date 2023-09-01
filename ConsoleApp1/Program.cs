// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 3;
string s = "Martin";
decimal d = 3.5M;
float f = 3.5F;

Console.WriteLine(i);
Console.WriteLine(s);
Console.WriteLine(d);
Console.WriteLine(f);

string s2 = "3";
int  i2 = int.Parse(s2);

Console.WriteLine($"Hello {s}! Your decimal number is {d:C5}. Your parsed s2 to i2 is: {i2}");  

Console.WriteLine("Skriv in 3,67");

string tempstring = Console.ReadLine();
decimal decnr = decimal.Parse(tempstring);

Console.WriteLine(decnr * 10);