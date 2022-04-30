/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine("Число является квадратным корнем");
}
else
{
    Console.WriteLine("Число не является квадратным корнем");
}