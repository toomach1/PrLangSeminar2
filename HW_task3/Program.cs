
Console.WriteLine("Введите, обозначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("-> нет");//("понедельник");
        break;
    case 2:
        Console.WriteLine("-> нет");//("вторник");
        break;
    case 3:
        Console.WriteLine("-> нет");//("среда");
        break;
    case 4:
        Console.WriteLine("-> нет");//("четверг");
        break;
    case 5:
        Console.WriteLine("-> нет");//("пятница");
        break;
    case 6:
        Console.WriteLine("-> да");//("суббота - выходной");
        break;
    case 7:
        Console.WriteLine("-> да");//("воскресенье - выходной");
        break;    
    default:
        Console.WriteLine("число не является обозначением дня недели");
        break;
}