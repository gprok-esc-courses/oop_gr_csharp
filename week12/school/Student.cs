using System;
namespace school
{
	public class Student : Person
	{
		public string Major { get; set; }

		public List<Enrollment> Enrollments { get; set; }

		public Student(int id, string name, string major) : base(id, name)
		{
			Major = major;
            Enrollments = new List<Enrollment>();
        }

        public void AddCourse(Course course)
        {
            Enrollments.Add(new Enrollment(course));
        }

        public void GradeCourse(int courseId, int grade)
        {
            foreach(Enrollment enrollment in Enrollments)
            {
                if(enrollment.Course.Id == courseId)
                {
                    enrollment.Grade = grade;
                    Console.WriteLine("Grade set");
                    return;
                }
            }
            Console.WriteLine("Student not attending this course");
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Major;
        }
    }
}

