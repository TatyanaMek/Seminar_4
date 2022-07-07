// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Максимальное из трех");
    Console.Write("Введите первое число ");
    double a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число ");
    double b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число ");
    double c = Convert.ToInt32(Console.ReadLine());

double max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
