﻿/*  Задача 2: Напишите программу, которая на вход принимает 
два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


Console.WriteLine ("Введите первое число:");
int a = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите второе число:");
int b = Convert.ToInt32 (Console.ReadLine());

if(a > b)
System.Console.WriteLine("MAX:" + a + ",MIN:" + b);
else System.Console.WriteLine("MAX:" + b + ",MIN:" + a);


/* Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22  */


Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("Максимальное число: " + a);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + c);
    }
}

else if (b > c)
{
    Console.WriteLine("Максимальное число: " + b);
}
else
{
    Console.WriteLine("Максимальное число: " + c);
}
 

/*  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). 
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число которое хотите проверить на чётность: ");
int a = Convert.ToInt32(Console.ReadLine());
int delenie = a % 2;
if (delenie == 0)
{
    Console.WriteLine("Число " + a + " - ЧЁТНОЕ!");
}
else
{
    Console.WriteLine("Число " + a + " - НЕЧЁТНОЕ!");
} 

/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
} 
