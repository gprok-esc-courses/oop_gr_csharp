
char c;

do
{
    Console.Write("Sales: ");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x > 100)
    {
        Console.WriteLine("Very big value");
    }
    else if (x < 0)
    {
        Console.WriteLine("Invalid value");
    }
    else
    {
        for (int i = 0; i < x; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }

    Console.Write("Continue y/n: ");
    c = Convert.ToChar(Console.ReadLine());
} while (c == 'y');
