// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите любое целое число");
int n = int.Parse(Console.ReadLine());
int summ = 0;
if (n<0) n *= -1;
while (n>0) 
{
    summ=summ+n%10;
    n=n/10;
}
Console.WriteLine($"Сумма всех цифр заданного числа равна {summ}");
