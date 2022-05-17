/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100,1000);
Console.WriteLine( randomNumber );
int numberOne = (randomNumber / 100) * 10;
int numberTwo = randomNumber % 10;
Console.WriteLine($"Первая и последняя циферки вышеуказанного числа: {numberOne + numberTwo}" );
