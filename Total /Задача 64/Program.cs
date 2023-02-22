// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();
Console.WriteLine("Введи значение N");
int N = int.Parse(Console.ReadLine());
PrintNumbers(N,1);
void PrintNumbers(int start, int end)
{
Console.Write($"{start} ");
if (start == end) return;
else if (start<end) PrintNumbers(start + 1, end);
else PrintNumbers(start - 1, end);
}
