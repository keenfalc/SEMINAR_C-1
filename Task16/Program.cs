/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
    int number = Convert.ToInt32(Console.ReadLine()); 
    if (number >=1 && number <=5 )
    {
        Console.WriteLine("Это номер рабочего дня недели");
    }
    if (number >= 6 && number <= 7)
    {
        Console.WriteLine("Это номер выходного дня недели");
    }
    else
    {
        Console.WriteLine("Введите цифру дня недели от 1 до 7");
    }