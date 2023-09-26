/*
Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Введите первое число (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (b): ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Наибольшее число -> {a}");
}
else
{
    if (b > a)
    {
        Console.Write($"Наибольшее число -> {b}");
    }
    else
    {
        Console.Write($"Числа {a} и {b} равны");
    }
}
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Введите первое число (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (b): ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write($"Наибольшее число -> {a}");
}
else
{
    if (b > a)
    {
        Console.Write($"Наибольшее число -> {b}");
    }
    else
    {
        Console.Write($"Числа {a} и {b} равны");
    }
}
*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} чётное");
}
else
{
    Console.WriteLine($"Число {a} нечётное");
}
*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N = 0;
do
{
Console.Write("Введите целое положительное число: ");
N = Convert.ToInt32(Console.ReadLine());
}
while (N <= 0);
int count = 1;
Console.Write($"{N} -> ");
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}  ");
    }
count ++;
}


