using System.ComponentModel.DataAnnotations.Schema;

namespace SocialNetwork.Web.Models
{
    public class Tutorial
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TutorialID { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Instructor { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
