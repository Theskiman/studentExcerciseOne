
namespace ExcerciseOne{

    class Instructor{
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string slackHandle { get; set; }

         public Cohort instructorsCohort = new Cohort();

         public string specialty { get; set; }

         public void addExcercise(Excercise thing, Student person){
             person.excerciseList.Add(thing);
         }
    }
}