
namespace ExcerciseOne
{
    public class NSSPeeps
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string slackHandle { get; set; }

        public string fullName
        {
            get
            {
                return ($"{firstName} {lastName}");
            }
        }
    }
}