// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int len = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон массива от ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("до");
int max = int.Parse(Console.ReadLine());
double[] MyRandom = new double[len];
for (int i = 0; i < len; i++)
{
    double UnInt = new Random().NextDouble();
    MyRandom[i] = Math.Round((new Random().Next(min, max) + UnInt), 2);
}
ShowArray(MyRandom);
double maxMR = MyRandom[0];
double minMR = MyRandom[0];
for (int count = 0; count < len; count++)
{
    if (MyRandom[count]>maxMR)
    {
        maxMR=MyRandom[count];
    }
    else if (MyRandom[count]<minMR)
    {
        minMR=MyRandom[count];
    }
}
Console.WriteLine($"max {maxMR}");
Console.WriteLine($"min {minMR}");
Console.WriteLine($"Разница между большим и меньшим значением массива {maxMR-minMR}");
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "    ");
    }
    Console.WriteLine();
}