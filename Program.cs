/*
Урок 1. Знакомство с языком программирования С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Задача № 2");
Console.Write("Введите первое число (a): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (b): ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"a = {a}; b = {b} -> Наибольшее число -> {a}");
}
else
{
    if (b > a)
    {
        Console.WriteLine($"a = {a}; b = {b} -> Наибольшее число -> {b}");
    }
    else
    {
        Console.WriteLine($"a = {a}; b = {b} -> Числа {a} и {b} равны");
    }
}
Console.WriteLine();

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Задача № 4");
Console.Write("Введите первое число (num1): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (num2): ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число (num3): ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"Наибольшее число -> {num1}");
    }
    else
    {
         Console.WriteLine($"Наибольшее число -> {num3}");
    }
   
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine($"Наибольшее число -> {num2}");
    }
    else
    {
         Console.WriteLine($"Наибольшее число -> {num3}");
    }
}
Console.WriteLine();

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Задача № 6");
Console.Write("Введите целое число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo % 2 == 0)
{
    Console.WriteLine($"Число {chislo} чётное");
}
else
{
    Console.WriteLine($"Число {chislo} нечётное");
}
Console.WriteLine();

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Задача № 6");
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
Console.WriteLine();

