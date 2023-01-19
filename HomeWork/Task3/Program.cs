/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
_______________________________________________________________________*/

System.Console.Write("Введите первое число : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 6)
{
    System.Console.WriteLine($"{number} -> Нет, рабочий день");
}
else if(number > 5 && number < 8)
{
    System.Console.WriteLine($"{number} -> Да, выходной");
}
else
{
    System.Console.WriteLine($"Число {number} -> не является днем недели");
}
