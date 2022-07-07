// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Большее число из двух");
            Console.Write("Введите первое число ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число ");
            double b = Convert.ToInt32(Console.ReadLine());
           double max;
           if (a > b)
           {
               max = a;
               
           }
           else
           {
               max = b;
           }
           Console.WriteLine(max);