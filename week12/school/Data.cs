using System;
namespace school
{
	public class Data
	{
		public Data()
		{
		}

		public static List<Student> GetStudents()
		{
			List<Student> students = new List<Student>();
			students.Add(new Student(1, "John Doe", "Computing"));
            students.Add(new Student(2, "Mary Doe", "Marketing"));
            students.Add(new Student(3, "Patti Smith", "Psychology"));
            students.Add(new Student(4, "Jeff Beck", "Computing"));
            students.Add(new Student(5, "Ray Charles", "Shipping"));
            students.Add(new Student(6, "Janis Joplin", "Physics"));
            students.Add(new Student(7, "Bob Dylan", "Computing"));
            students.Add(new Student(8, "Joe Cocker", "Physics"));

			return students;
        }

		public static List<Course> GetCourses()
		{
			List<Course> courses = new List<Course>();
			courses.Add(new Course(1, "C#"));
            courses.Add(new Course(2, "Database"));
            courses.Add(new Course(3, "Google Ads"));
            courses.Add(new Course(4, "Port Management"));
            courses.Add(new Course(5, "Nuclear Energy"));
            courses.Add(new Course(6, "Cognitive Behavior"));
            courses.Add(new Course(7, "Python"));
            courses.Add(new Course(8, "Data Structures"));
            courses.Add(new Course(9, "Logistics"));
            courses.Add(new Course(10, "Human Resources"));

            return courses;
        }

        public static void Enroll(School school)
        {
            school.Enroll(1, 1);
            school.Enroll(1, 2);
            school.Enroll(2, 7);
            school.Enroll(3, 3);
            school.Enroll(4, 8);
            school.Enroll(4, 7);
            school.Enroll(5, 4);
            school.Enroll(6, 7);
        }
	}
}

