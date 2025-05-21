//  Jonathan Bodrero  May 21, 2025
//  Lab 1

//Step 4: Work with Double type

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

double third = 1.0 / 3.0;
Console.WriteLine(third);
double third_int = 1 / 3;
Console.WriteLine($"1/3 entered as integers gives { third_int}");

// Challenge
double num1 = 123456789;
double num2 = 987654321;
double prod1 = num1 * num2;
Console.WriteLine($"{num1} * {num2} = {prod1}");
double num3 = 0.000000000013579;
double quot1 = num2 / num3;
Console.WriteLine($"{num2} / {num3} = {quot1}");
// Can I enter in sci not?
double num4 = 2.59E-8;
Console.WriteLine(num4);
double sum1 = num3 + num4;
Console.WriteLine($"{num3} + {num4} = {sum1}");
double prod2 = num3 * num4;
Console.WriteLine($"{num3} * {num4} = {prod2}");