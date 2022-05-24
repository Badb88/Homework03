/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = number;
int result = 0;
while (number > 0)
{
    int x = number % 10;
    result = result * 10 + x;
    number = number / 10;
}
if (result==i)
{
    Console.WriteLine("Является палиндромом.");
}
else
{
    Console.WriteLine("Не является палиндромом.");
}