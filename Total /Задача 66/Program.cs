// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма натуральных чисел в заданном промежутке равна {CountSum(M,N)}");
int CountSum(int min, int max)
{
    int sum=0;
    if (min<max)
    {
    for (int i=min; i<=max;i++)
    {
        sum+=i;
    }
    }
    else
    {
        for (int i=max; i<=min;i++)
    {
        sum+=i;
    }
    }
    return sum;
}