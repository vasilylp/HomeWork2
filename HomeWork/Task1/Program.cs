/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
Решение математическим способом _____________________________________*/

System.Console.WriteLine("Введите трехзначное число :");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 0;

if (number > 99 && number < 1000)
{
    number2 = number / 10;
    number2 = number2 % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} : {number2} ");
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
