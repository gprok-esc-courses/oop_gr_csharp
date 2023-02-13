
Console.Write("Year: ");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("Year 1");
        break;
    case 2:
        Console.WriteLine("Year 2");
        break;
    case 3:
        Console.WriteLine("Year 3");
        break;
    case 4:
        Console.WriteLine("Year 4");
        break;
    case 5:
    case 6:
        Console.WriteLine("MSc");
        break;
    case > 6:
        Console.WriteLine("PhD");
        break;
    default:
        Console.WriteLine("Wrong Value");
        break;
}
