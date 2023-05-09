using System;
namespace school
{
	public class School
	{
		public List<Course> Courses { get; set; }
		public List<Student> Students { get; set; }

		public School()
		{
			Courses = new List<Course>();
			Students = new List<Student>();
		}

		public void LoadData()
		{
            Students = Data.GetStudents();
			Courses = Data.GetCourses();
			Data.Enroll(this);
		}

		public Student FindStudent(int studentId)
		{
			Student student = null;
			foreach(Student s in Students)
			{
				if(s.Id == studentId)
				{
					student = s;
					break;
				}
			}
			return student;
		}

        public Course FindCourse(int courseId)
        {
            Course course = null;
            foreach (Course c in Courses)
            {
                if (c.Id == courseId)
                {
                    course = c;
                    break;
                }
            }
            return course;
        }

        public void Enroll(int studentId, int courseId)
		{
			Student student = FindStudent(studentId);
			Course course = FindCourse(courseId);

			if(student == null || course == null)
			{
				Console.WriteLine("Student or Course not found");
			}
			else
			{
				student.AddCourse(course);
			}
		}

		public void PrintStudents()
		{
			foreach(Student student in Students)
			{
				Console.WriteLine(student);
			}
			Console.WriteLine("=========================");
		}

		public void PrintEnrollment()
		{
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
				foreach(Enrollment e in student.Enrollments)
				{
					Console.WriteLine("----> " + e.Course);
				}
            }
            Console.WriteLine("=========================");
        }
	}
}

