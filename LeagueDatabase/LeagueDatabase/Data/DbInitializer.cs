using LeagueDatabase.Data;
using LeagueDatabase.Models;
using System;
using System.Linq;

namespace LeagueDatabase.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GameContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Player.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Player[]
            {
                new Player{FirstMidName="Carson",LastName="Alexander",Username="Epic Gamer",MMR=1220},
                new Player{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Player{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Player{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Player{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Player{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Player{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Player{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };
            foreach (Player s in students)
            {
                context.Player.Add(s);
            }
            context.SaveChanges();

            var courses = new Tournament[]
            {
                new Tournament{TournamentID=1050,Title="Clash",Reward=50},
                new Tournament{TournamentID=4022,Title="All Star",Reward=500},
                new Tournament{TournamentID=4041,Title="Worlds",Reward=10000},
            };
            foreach (Tournament c in courses)
            {
                context.Tournaments.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,TournamentID=1050,Rank=Rank.A},
                new Enrollment{StudentID=1,TournamentID=4022,Rank=Rank.A},
                new Enrollment{StudentID=1,TournamentID=4041,Rank=Rank.A},
                new Enrollment{StudentID=2,TournamentID=1045,Rank=Rank.A},
                new Enrollment{StudentID=2,TournamentID=3141,Rank=Rank.A},
                new Enrollment{StudentID=2,TournamentID=2021,Rank=Rank.A},
                new Enrollment{StudentID=3,TournamentID=1050},
                new Enrollment{StudentID=4,TournamentID=1050},
                new Enrollment{StudentID=4,TournamentID=4022,Rank=Rank.A},
                new Enrollment{StudentID=5,TournamentID=4041,Rank=Rank.A},
                new Enrollment{StudentID=6,TournamentID=1045},
                new Enrollment{StudentID=7,TournamentID=3141,Rank=Rank.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}