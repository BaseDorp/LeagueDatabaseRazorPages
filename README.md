# LeagueDatabaseRazorPages
A League of Legends inspired player database using Razor Pages in ASP.net Core

ContosoUniversity => LeagueDatabase
Students => Players
Enrollment => Enrollment
Courses => Tournaments
ContosoUniversity.Data.SchoolContext => LeagueDatabase.Data.GameContext
CourseID => TournamentID

public DbSet<Player> Players { get; set; } => Player not Players