using System;
namespace school
{
	public class Enrollment
	{
        public static int GRADE_NOT_SET = -1;
        public int Grade { get; set; }
        public Course Course { get; set; }

        public Enrollment(Course course)
		{
            Course = course;
            Grade = GRADE_NOT_SET;
        }
	}
}

