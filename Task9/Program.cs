/*
На вход принимается трехзначное число, на выход показывает его последнюю цифру. */

Console.WriteLine("Введите значение числа n: ");
string text = Console.ReadLine();
int y = text[text.Length - 1] - '0';
Console.WriteLine("Последняя цифра числа {0,5}", y);
