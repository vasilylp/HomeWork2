/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
Математическое решение_____________________________________________________*/

System.Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;
int number3 = 0;

if (number > 99)
{
    while(number > 999)
    {
        number = number / 10;
    }
    number3 = number % 10;
    System.Console.WriteLine($"{temp} -> {number3}");
}
else
{
    System.Console.WriteLine($"{number} -> Третьей цифры нет");
}



