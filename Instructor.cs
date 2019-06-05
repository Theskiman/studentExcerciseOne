
namespace ExcerciseOne{

    class Instructor: NSSPeeps{
        

         public Cohort instructorsCohort { get; set; }

         public string specialty { get; set; }

         public void addExcercise(Excercise thing, Student person){
             person.excerciseList.Add(thing);
            
         }
    }
}