using System;

namespace studentExercises
{
    public class Instructor
    {
        public string Speciality { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public int Cohort { get; set; }
        public void AssignEx(Exercise ex, Student stu) {
            stu.AddEx(ex);
        }

    }
}