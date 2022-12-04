/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int Digit1 = number / 10000;
    int Digit2 = number / 1000 % 10;
    int Digit4 = number / 10 % 10;
    int Digit5 = number % 10;


    if (Digit1 == Digit5 && Digit2 == Digit4)
    {
        Console.WriteLine("Число - палиндром");
    }
    else
    {
        Console.WriteLine("Число - не палиндром");
    }

}
else
{
    Console.WriteLine("Введенное число не пятизначное");
}