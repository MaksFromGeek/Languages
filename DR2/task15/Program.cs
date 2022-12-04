Console.Write("Введите порядковый номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Понедельник не выходной");
        break;
    case 2:
        Console.WriteLine("Вторник не выходной");
        break; 
    case 3:
        Console.WriteLine("Среда не выходной");
        break; 
    case 4:
        Console.WriteLine("Четверг не выходной");
        break; 
    case 5:
        Console.WriteLine("Пятница не выходной");
        break; 
    case 6:
        Console.WriteLine("Суббота выходной день");
        break; 
    case 7:
        Console.WriteLine("Выоскресенье выходной день");
        break; 
    default:
        Console.WriteLine("Не является днем недели");
        break; 
}
