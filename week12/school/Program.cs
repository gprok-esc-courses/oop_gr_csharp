using school;

School School = new School();
School.LoadData();

int choice = 0;

do
{
    Console.WriteLine("1. Print Students");
    Console.WriteLine("2. Enroll");
    Console.WriteLine("3. Print Enrollment");
    Console.WriteLine("0. EXIT");
    Console.Write("> ");
    choice = Int32.Parse(Console.ReadLine());

    if(choice == 1)
    {
        School.PrintStudents();
    }
    else if(choice == 2)
    {
        Console.Write("Student ID: ");
        int sid = Int32.Parse(Console.ReadLine());
        Console.Write("Course ID: ");
        int cid = Int32.Parse(Console.ReadLine());
        School.Enroll(sid, cid);
    }
    else if(choice == 3)
    {
        School.PrintEnrollment();
    }
    else if(choice == 0)
    {
        Console.WriteLine("Bye!");
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }


} while (choice != 0);

