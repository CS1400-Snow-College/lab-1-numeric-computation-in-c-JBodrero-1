//  Jonathan Bodrero  May 21, 2025
//  Lab 1

//Step 5: Decimal type
using System.Formats.Asn1;
using System.Net.NetworkInformation;

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");
double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
//  without the "m" in the declaratino/initialization, it throws an errror
// decimal p = 1.0;
// decimal q = 3.0;
//Console.WriteLine(p / q);

double pi = Math.PI;
Console.WriteLine(Math.PI);

Console.WriteLine($"Pi = {pi}");

//Challenge  Find the area of a circle of given radius.
double area = pi * (2.50*2.50);
Console.WriteLine($"The area of a circle of radius {2.50} is {area} square units.");

//Console.WriteLine("Enter the radius of your circle:");
//rad = Console.ReadLine();
