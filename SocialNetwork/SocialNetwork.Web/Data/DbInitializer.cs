using SocialNetwork.Web.Models;

namespace SocialNetwork.Web.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Subscribers.Any())
            {
                return;
            }

            var subscribers = new Subscriber[]
            {
                new Subscriber{LastName="John",FirstMidName="McCartney" , EnrollmentDate=DateTime.Parse("2022-09-02") },
                new Subscriber{LastName="Paul",FirstMidName="Lennon" , EnrollmentDate=DateTime.Parse("2022-12-01") },
                new Subscriber{LastName="Com",FirstMidName="Truise" , EnrollmentDate=DateTime.Parse("2022-09-04") }
            };
            foreach (Subscriber s in subscribers)
            {
                context.Subscribers.Add(s);
            }
            context.SaveChanges();

            var tutorials = new Tutorial[]
            {
                new Tutorial{TutorialID=1050,Title="Neo Soul Guitar", Duration=10, Instructor="Kazuki Isogai" },
                new Tutorial{TutorialID=4022,Title="Play Faster in 30 Days", Duration=10, Instructor="Sam Blakelock" },
                new Tutorial{TutorialID=1052,Title="Triads Bootcamp", Duration=10, Instructor="Mia Garcia" }
            };
            foreach (Tutorial t in tutorials)
            {
                context.Tutorials.Add(t);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{SubscriberID=1, TutorialID=1050, Difficulty=Difficulty.INTERMEDIATE},
                new Enrollment{SubscriberID=2, TutorialID=4022, Difficulty=Difficulty.ADVANCED},
                new Enrollment{SubscriberID=3, TutorialID=1052, Difficulty=Difficulty.BEGINNER}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
