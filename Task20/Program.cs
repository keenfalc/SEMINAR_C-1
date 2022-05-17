/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

double GeTOtrezok(int X1, int Y1, int X2, int Y2)
{
 int Katet1 = (X1-X2);
 int Katet2 = (Y1-Y2);
 double Result = Katet1*Katet1 + Katet2*Katet2;
 Result = Math.Sqrt(Result);
 return Result;
}
Console.WriteLine("Введите координаты x1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
double lengh =GeTOtrezok(X1,Y1,X2,Y2);
Console.WriteLine($"Длина равно : {lengh}");
