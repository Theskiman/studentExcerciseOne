using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Excercise One
            Excercise FizzBuzz = new Excercise()
            {
                name = "FizzBuzz",
                language = "JavaScript"
            };

            Excercise CoffeeHouse = new Excercise()
            {
                name = "CoffeeHouse",
                language = "JavaScript"
            };

            Excercise EnglishIdioms = new Excercise()
            {
                name = "English Idioms",
                language = "C#"
            };

            Excercise FamilyDictionary = new Excercise()
            {
                name = "Family Dictionary",
                language = "C#"
            };

            Cohort Day31 = new Cohort()
            {
                cohortName = "Day Cohort 31",

            };

            Cohort Night20 = new Cohort()
            {
                cohortName = "Night Cohort 20"
            };

            Cohort Day33 = new Cohort()
            {
                cohortName = "Day Cohort 33"
            };

            Student Clif = new Student()
            {
                firstName = "Clifton",
                lastName = "Matuszewski",
                slackHandle = "Theskiman",
            };

            Clif.studentsCohort = Day31;

            Student Josh = new Student()
            {
                firstName = "Josh",
                lastName = "Hibray",
                slackHandle = "jHibray"
            };

            Josh.studentsCohort = Day31;

            Student Chris = new Student()
            {
                firstName = "Blue",
                lastName = "Morgan",
                slackHandle = "Blue_Chris"
            };

            Chris.studentsCohort = Day31;

            Instructor Jisie = new Instructor()
            {
                firstName = "Jisie",
                lastName = "David",
                slackHandle = "jisie",
                specialty = "Talking that trash to people."
            };
            Jisie.instructorsCohort = Day31;
            Instructor Andy = new Instructor()
            {
                firstName = "Andy",
                lastName = "Collins",
                slackHandle = "andyc",
                specialty = "Joshin with people"
            };
            Andy.instructorsCohort = Night20;
            Instructor Kristen = new Instructor()
            {
                firstName = "Kristen",
                lastName = "Norris",
                slackHandle = "kristen.norris",
                specialty = "Bringing her dog to school"
            };
            Kristen.instructorsCohort = Day31;
            Jisie.addExcercise(FizzBuzz, Clif);
            Jisie.addExcercise(CoffeeHouse, Chris);
            Kristen.addExcercise(EnglishIdioms, Josh);
            Kristen.addExcercise(FamilyDictionary, Clif);
            Andy.addExcercise(CoffeeHouse, Clif);
            Andy.addExcercise(FizzBuzz, Chris);
            Jisie.addExcercise(CoffeeHouse, Josh);

            List<Student> allStudents = new List<Student>(){
            Clif, Chris, Josh
        };

            List<Excercise> allExcercises = new List<Excercise>(){
                FizzBuzz, CoffeeHouse, EnglishIdioms, FamilyDictionary
            };

            foreach (Student person in allStudents)
            {
                Console.Write($"{person.firstName} {person.lastName} is currently working on the following excercises:  ");
                foreach (Excercise thing in person.excerciseList)
                {
                    Console.Write($"{thing.name}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(Clif.studentsCohort.cohortName);
            Console.WriteLine("- - - - - - - - - - - - - - - ");

            // Excercise Two
            Console.WriteLine("Start of Excercise Two:");
            Console.WriteLine();
        // 1. List exercises for the JavaScript language by using the Where() LINQ method.

            List<Cohort> allCohorts = new List<Cohort>(){
                Day31, Day33, Night20
            };

            List<Instructor> allInstructors = new List<Instructor>(){
                Jisie, Andy, Kristen
            };

            var javaExcercise = allExcercises.Where(thing => thing.language == "JavaScript");
            foreach (var excercise in javaExcercise)
            {
                Console.WriteLine(excercise.name);
            }

            Console.WriteLine("- - - - - - - - - - - - ");
            Console.WriteLine();
        // 2. List students in a particular cohort by using the Where() LINQ method.

            var studentsCohort31 = allStudents.Where(student => student.studentsCohort == Day31);
            foreach (var student in studentsCohort31)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }

            Console.WriteLine("- - - - - - - - - - - - - ");
            Console.WriteLine();
            // 3. List instructors in a particular cohort by using the Where() LINQ method.

            var instructorsCohort31 = allInstructors.Where(instructor => instructor.instructorsCohort == Day31);
            foreach (var instructor in instructorsCohort31)
            {
                Console.WriteLine(instructor.firstName + " " + instructor.lastName);
            }

            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine();

            // 4. Sort the students by their last name.

            List<Student> byLastName = allStudents.OrderBy(student => student.lastName).ToList();
            foreach (Student student in byLastName)
            {
                Console.WriteLine($"{student.firstName} {student.lastName}");
            }

            Console.WriteLine("- - - - - - - -");
            Console.WriteLine();
            
            // 5. Display any students that aren't working on any exercises

            Student John = new Student();
            John.firstName = "Jon";
            John.lastName = "Schaffer";
            John.slackHandle = "JohnsSlack";
            John.studentsCohort = Day31;
            allStudents.Add(John);

        IEnumerable<Student> noExcercises = allStudents.Where(student => student.excerciseList.Count == 0);

            foreach(Student student in noExcercises){
                 
                    Console.WriteLine($"{student.firstName} {student.lastName} is lazy he isn't doing any excercises");
                 
            }

            Console.WriteLine("- - - - - - - - - - -");
            Console.WriteLine();

            // 6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
        Student maxExcercises = allStudents.Single(student => student.excerciseList.Count == allStudents.Max(s => s.excerciseList.Count));
        Console.WriteLine(maxExcercises.firstName + " " + maxExcercises.lastName);

        Console.WriteLine("- - - - - - - - - -");
        Console.WriteLine();

        // 7. How many students in each cohort?

        Day31.studentList.Add(Clif);
        Day31.studentList.Add(John);
        Day33.studentList.Add(Josh);
        Night20.studentList.Add(Chris);

         allCohorts.ForEach(c => Console.WriteLine($"{c.cohortName} has {(c.studentList).Count()} students in it."));


           
            
        }
    }
}
