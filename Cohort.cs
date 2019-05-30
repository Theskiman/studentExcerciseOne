using System.Collections.Generic;

namespace ExcerciseOne{

    class Cohort{
        public string cohortName { get; set; }

        public List<Student> studentList = new List<Student>();

        public List<Instructor> instructorList = new List<Instructor>();

    }
}