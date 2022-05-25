﻿/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = number; i > 0; i /= 10)
{
    result = (result * 10) + (i % 10);
}
/*while (number > 0)
{
    int x = number % 10;
    result = result * 10 + x;
    number = number / 10;
}*/
if (result==number)
{
    Console.WriteLine("Является палиндромом.");
}
else
{
    Console.WriteLine("Не является палиндромом.");
}