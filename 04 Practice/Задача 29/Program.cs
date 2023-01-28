// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Console.Clear();
Console.WriteLine("Введите числовой диапазон генерации элементов массива");
int MaxZnach = int.Parse(Console.ReadLine());
int MinZnach = int.Parse(Console.ReadLine());
int temp=MaxZnach;
if (MinZnach>MaxZnach) 
{
    temp = MaxZnach;
    MaxZnach=MinZnach;
    MinZnach=temp;
}
int[] FillingArray (int mass)
{
    int[] result = new int[mass];
    for (int index = 0; index < mass; index++)
    {
        result[index] = new Random().Next(MinZnach, MaxZnach);
    }
    return result;
}
int [] array = FillingArray(8);
Console.WriteLine($" [ {string.Join(" ", array)} ] ");
