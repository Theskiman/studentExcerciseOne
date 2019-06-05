
namespace ExcerciseOne{

    public class Instructor: NSSPeeps{
        

       

         public string specialty { get; set; }

         public void addExcercise(Excercise thing, Student person){
             person.excerciseList.Add(thing);
            
         }
    }
}