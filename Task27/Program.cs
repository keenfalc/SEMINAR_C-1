/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

/*
using namespace std;
 
int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
 
    int a, b, c, e;
 
    cout << "Введите пятизначное число:  ";
    cin >> a;
    cout << "\n\n";
 
    if(a >= 9999 && a <= 100000)
    {
                b = a / 10000;
                a = a % 10000;
                c = a / 1000;
                a = a % 1000;
                a = a % 100;
                e = a / 10;
                a = a % 10;
 
                if (b == a && c == e)
                {
                    cout << "Это число палиндром";
                }
                    else
                    cout << "Это число не палиндром";
 
    }
    else
    cout << "Вы ввели не пятизначное число!!!";
    return 0;
}
*/

/*
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
rev = 0;

    if(n == rev && n > 0) 
    {
    dig = n % 10;
    rev = rev * 10 + dig;
    }
    {
        Console.WriteLine("Это палиндром!");
    }
    else
{
          Console.WriteLine("Это не палиндром!");
}
*/

Console.WriteLine("введите пятизначное число");
            int number = int.Parse(Console.ReadLine());
            int pal = 0, num = number;
            while (number > 0) 
            {
                pal = pal * 10 + number % 10; 
                number /= 10;
            }
            Console.WriteLine(num == pal ? "палиндром" : "не палиндром");