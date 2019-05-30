using System.Collections.Generic;

namespace ExcerciseOne
{

    class Student{
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string slackHandle { get; set; }

        public Cohort studentsCohort = new Cohort();

        public List<Excercise> excerciseList = new List<Excercise>();

    }
}