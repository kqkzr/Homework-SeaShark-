// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
Console.Clear();
Console.WriteLine("Введите число M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"функция Аккермана при данных значениях равна {akker(M, N)}");
int akker(int min, int max)
{
    if (min == 0) return max + 1;
    else 
        if ((min != 0) && (max==0)) return akker(min - 1, 1);
    else return akker((min - 1), akker(min, max - 1));
}