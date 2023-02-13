
int[] sales = { 10, 8, 12, 15 };
char[] quarter = { 'A', 'B', 'C', 'D' };

for(int i = 0; i < sales.Length; i++)
{
    Console.Write(quarter[i] + " ");
    for (int j = 0; j < sales[i]; j++)
    {
        Console.Write('*');
    }
    Console.WriteLine(" (" + sales[i] + ")");
}
