﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
Console.Clear();
Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());
if (number < 0) 
{
    number *= -1;
}
if (number>=100)
{
while (number>999)
{
number = number/10;
}
Console.WriteLine($"Третья цифра числа {number%10}");
}
else 
{
    Console.Write("Введенное число не трехначное");
}
