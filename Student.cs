using System.Collections.Generic;

namespace ExcerciseOne
{

    class Student{
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string slackHandle { get; set; }

        public Cohort studentsCohort { get; set; }

        public List<Excercise> excerciseList { get; set; } = new List<Excercise>();

    }
}