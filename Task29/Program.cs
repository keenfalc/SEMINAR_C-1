/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int i = 1; i <= number; i++)
    {
      Console.WriteLine($"Кубы всех чисел от 1 до {number} = {i * i * i}");
    }
    
}
else 
{
    Console.WriteLine($"Кубы всех чисел от 1 до {number} = 0");
}