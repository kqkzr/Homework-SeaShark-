﻿Console.Write("Введите первое число - ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
int с = int.Parse(Console.ReadLine());
int max = a ;
if (b>max) max = b;
if (с>max) max = с;
Console.WriteLine($"Наибольшее из трех чисел - {max}");

