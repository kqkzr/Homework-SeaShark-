//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.WriteLine("Введите натуральное число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую вы хотите возвести предыдущее число");
int n = int.Parse(Console.ReadLine());
double result = 1;
if (n == 0)
{
    Console.WriteLine("Результат возведения любого числа в нулевую степень равняется 1");
}
else
{
    for (int i = 0; i < Math.Abs(n); i++)
    {
        result = result * a;
    }
}
if (n > 0) Console.WriteLine($"Результата возведения {a} в степень {n} равен {result}");
if (n < 0) Console.WriteLine($"Результата возведения {a} в степень {n} равен {1 / result}");


