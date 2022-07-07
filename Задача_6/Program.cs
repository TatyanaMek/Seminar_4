// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).


Console.WriteLine("Чётное или нет");
    Console.Write("Введите число ");
    double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a % 2 == 0 ? "Чётное" : "Не чётное");
