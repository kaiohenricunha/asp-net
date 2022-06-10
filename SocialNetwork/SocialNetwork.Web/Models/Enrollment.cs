namespace SocialNetwork.Web.Models
{
    public enum Difficulty
    {
        BEGINNER, INTERMEDIATE, ADVANCED
    }
    public class Enrollment
    {
        public int EnrrolmentID { get; set; }
        public int TutorialID { get; set; }
        public int SubscriberID { get; set; }
        public Difficulty? Difficulty { get; set; }
        public Tutorial Tutorial { get; set; }
        public Subscriber Subscriber { get; set; }

    }
}
