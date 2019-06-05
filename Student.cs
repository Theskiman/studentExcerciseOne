using System.Collections.Generic;

namespace ExcerciseOne
{

    class Student: NSSPeeps{
        

        public Cohort studentsCohort { get; set; }

        public List<Excercise> excerciseList { get; set; } = new List<Excercise>();

    }
}