/* Напишите программу, которая выводит маршрут автобуса, который задал пользователь (от 300 до 310)*/
Console.Clear();
Console.WriteLine("Enter number of way");
int number = int.Parse(Console.ReadLine());
switch (number)
{
    case 301 :
    {
        Console.WriteLine("Маршрут автобуса: Опытная - КТЗ - Гагарина - Цемзавод");
        break;
    }
    case 302 :
    {
        Console.WriteLine("Маршрут автобуса: Дворец Металлургов - Нижний Парк - Ленина - Баумана");
        break;
    }
    case 303 :
    {
        Console.WriteLine("Маршрут автобуса: О31 - О32 - О33 - О34");
        break;
    }
    case 304 :
    {
        Console.WriteLine("Маршрут автобуса: 041 - О42 - О43 - О44");
        break;
    }
    case 305 :
    {
        Console.WriteLine("Маршрут автобуса: Баумана - Гагарина - КТЗ - 19й");
        break;
    }
    case 306 :
    {
        Console.WriteLine("Маршрут автобуса:  061 - О62 - О63 - О64");
        break;
    }
    case 307 :
    {
        Console.WriteLine("Маршрут автобуса: 071 - О72 - О73 - О74");
        break;
    }
    case 308 :
    {
        Console.WriteLine("Маршрут автобуса: 081 - О82 - О83 - О84");
        break;
    }
    case 309 :
    {
        Console.WriteLine("Маршрут автобуса: Университетский - КТЗ - Опытная - Цемзавод");
        break;
    }
    case 310 :
    {
        Console.WriteLine("Маршрут автобуса: 27й - Победы - ц Рынок - НЛМК");
        break;
    }
    default :
    {
        Console.WriteLine("Таких маршрутов не существует");
        break;
    }
}