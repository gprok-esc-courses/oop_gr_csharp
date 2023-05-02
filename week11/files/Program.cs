Console.WriteLine(Directory.GetCurrentDirectory());

string[] lines = File.ReadAllLines("data.txt");

foreach(string line in lines)
{
    string[] tokens = line.Split(',');
    Console.WriteLine(line);
    Console.WriteLine(tokens[0] + " - " + tokens[1] + " - " + tokens[2]);
}

