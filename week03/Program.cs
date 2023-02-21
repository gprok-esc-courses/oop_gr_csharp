
using School;

List<Student> list = new List<Student>();
for(int i = 0; i < 5; i++)
{
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("major: ");
    string major = Console.ReadLine();
    Student s = new Student(name, major);   
    list.Add(s);
}


foreach(Student s in list)
{
    Console.WriteLine(s);
}