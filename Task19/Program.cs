/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

void GetQuater(int quater)
{
if (quater == 1)
    {
        Console.WriteLine("X>0 и Y>0");
    }
    else if (quater == 2)
{
Console.WriteLine("X < 0 и Y < 0");
}
else if (quater == 3)
{
Console.WriteLine("X < 0 и Y > 0");
}
else if (quater == 4)
{
Console.WriteLine("X > 0 и Y < 0");
}
else
{
    Console.WriteLine("Неверно");
}
}

Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());
GetQuater(number);

