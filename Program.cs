using System;
using System.Collections.Generic;


namespace studentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 4, or more, exercises.
            Exercise CelebTribute = new Exercise()
            {
                Name = "Celebrity Tribute",
                Language = "CSS"
            };
            Exercise Itinerary = new Exercise()
            {
                Name = "Welcome To Nashville",
                Language = "Javascript"
            };
            Exercise Nutshell = new Exercise()
            {
                Name = "Nutshell",
                Language = "ReactJs"
            };
            Exercise Csharp = new Exercise()
            {
                Name = "practice exercise",
                Language = "C#"
            };

            // // Create 3, or more, cohorts.
            Cohort Cohort34 = new Cohort() { Name = "Day Cohort 34", Number = 34 };
            Cohort Cohort35 = new Cohort() { Name = "Day Cohort 35", Number = 35 };
            Cohort Cohort1 = new Cohort() { Name = "Day Cohort 1", Number = 1 };

            // // Create 4, or more, students and assign them to one of the cohorts.
            Student Michelle = new Student()
            {
                FirstName = "Michelle",
                LastName = "Jimenez",
                SlackHandle = "mjimeneztn",
                Cohort = 34
            };
            Student Billy = new Student()
            {
                FirstName = "Billy",
                LastName = "Bob",
                SlackHandle = "billybob",
                Cohort = 34
            };
            Student Joe = new Student()
            {
                FirstName = "Joe",
                LastName = "Shmo",
                SlackHandle = "joeshmo",
                Cohort = 1
            };
            Student Student4 = new Student()
            {
                FirstName = "PersonNme",
                LastName = "PersonLASTname",
                SlackHandle = "person1",
                Cohort = 35
            };

            // // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Andy = new Instructor()
            {
                FirstName = "Andy",
                LastName = "C",
                SlackHandle = "AndyCollins",
                Cohort = 34,
                Speciality = "Creator of c#"
            };
            Instructor Bryan = new Instructor()
            {
                FirstName = "Bryan",
                LastName = "Nilsen",
                SlackHandle = "bryannilsen",
                Cohort = 34,
                Speciality = "artist"
            };
            Instructor Steve = new Instructor()
            {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "stevenbrownlee",
                Cohort = 35,
                Speciality = "Being awesome"
            };

            // // Have each instructor assign 2 exercises to each of the students.
            Steve.AssignEx(CelebTribute, Michelle);
            Steve.AssignEx(Itinerary, Billy);
            Andy.AssignEx(Nutshell, Michelle);
            Andy.AssignEx(Csharp, Joe);
            Bryan.AssignEx(CelebTribute, Billy);
            Bryan.AssignEx(Itinerary, Joe);
            Andy.AssignEx(Nutshell, Student4);


            // Create a list of students and exercises
            List<Student> students = new List<Student>();
            students.AddRange(new[] { Michelle, Billy, Joe });

            List<Exercise> exercises = new List<Exercise>();
            exercises.AddRange(new[] { CelebTribute, Nutshell, Csharp, Itinerary });

            // Generate a report that displays which students are working on which exercises.
            foreach (Student student in students)
            {
              Console.WriteLine($"{student.FirstName} is working on {student.Exercises[1].Name} and {student.Exercises[0].Name}");
            }

        }
    }
}

