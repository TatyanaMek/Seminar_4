// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Проверить на 5 и 8.

Console.WriteLine("Все чётные числа от 1 до N");
Console.Write("Введите максимальное число");
double n = Convert.ToInt32(Console.ReadLine());

for (double result = 1; result <= n; result++)
{
    if (result %2 ==0)
    {
        Console.Write (result + " ");
        }
}
