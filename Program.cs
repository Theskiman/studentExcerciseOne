using System;
using System.Collections.Generic;

namespace ExcerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {

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

            Instructor Jisie = new Instructor(){
                firstName = "Jisie",
                lastName = "David",
                slackHandle = "jisie",
                specialty = "Talking that trash to people."
            };

            Instructor Andy = new Instructor(){
                firstName = "Andy",
                lastName = "Collins",
                slackHandle = "andyc",
                specialty = "Joshin with people"
            };

            Instructor Kristen = new Instructor(){
                firstName = "Kristen",
                lastName = "Norris",
                slackHandle = "kristen.norris",
                specialty = "Bringing her dog to school"
            };

            Jisie.addExcercise(FizzBuzz, Clif);
            Jisie.addExcercise(CoffeeHouse, Chris);
            Kristen.addExcercise(EnglishIdioms, Josh);
            Kristen.addExcercise(FamilyDictionary, Clif);
            Andy.addExcercise(CoffeeHouse, Clif);
            Andy.addExcercise(FizzBuzz, Chris);
            Jisie.addExcercise(CoffeeHouse, Josh);

            
        }
    }
}
