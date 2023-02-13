// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int len = int.Parse(Console.ReadLine());
Console.WriteLine("Введите диапазон массива от ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("до");
int max = int.Parse(Console.ReadLine());
int[] MyRandom = CreateRandomArray(len, min, max);
ShowArray(MyRandom);
int summ = 0;
for (int i = 1; i < len; i = i + 2) 
{
    summ = summ + MyRandom[i];
}
Console.WriteLine($"Сумма всех нечетных элементов равна {summ}");

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}