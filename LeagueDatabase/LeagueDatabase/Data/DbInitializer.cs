using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeagueDatabase.Data;
using LeagueDatabase.Models;

namespace LeagueDatabase.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GameContext context)
        {
            context.Database.EnsureCreated();

            // Looks for players in the database
            if (context.Players.Any())
            {
                // DB has been seeded
                return;
            }

            var players = new Player[]
            {
                new Player{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Player{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Player{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Player{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Player{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Player{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Player{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Player{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };
            foreach (Player p in players)
            {
                context.Players.Add(p);
            }
            context.SaveChanges();

            var tournaments = new Tournament[]
            {
                new Tournament{TournamentID=1,Title="Ignite"},
                new Tournament{TournamentID=2,Title="Revenge"}
            };
            foreach (Tournament t in tournaments)
            {
                context.Tournaments.Add(t);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,TournamentID=1,Rank=Rank.Diamond},
                new Enrollment{StudentID=3,TournamentID=2,Rank=Rank.Bronze}
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}
