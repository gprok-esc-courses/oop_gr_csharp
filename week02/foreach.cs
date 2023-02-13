
int[] values = { 12, 15, 78, 23, 14, 65, 28, 90 };

for (int i = 0; i < values.Length; i++)
{
    Console.WriteLine(values[i]);
}

Console.WriteLine("#################");

foreach(int v in values)
{
    Console.WriteLine(v);
}