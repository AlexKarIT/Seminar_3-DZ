/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число:");
int nomber = Convert.ToInt32(Console.ReadLine());
double cube = 0;

Console.WriteLine("Таблица кубов чисел от 1 до " + nomber + ":");
for (int i = 1; i <= nomber; i++)
{
    cube = Math.Pow (i , 3);
    Console.Write(" " + cube + "  |  ");
}