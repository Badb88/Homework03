/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;
Console.Write($"{number} - > ");
for (int i = 1; i <= number; i++)
{
    result = i * i * i;
    Console.Write(result);
if (i!=number)
{
    Console.Write(" , ");
}
}