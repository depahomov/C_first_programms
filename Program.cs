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