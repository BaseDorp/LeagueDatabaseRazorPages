namespace LeagueDatabase.Models
{
    public enum Rank
    {
        Bronze, Silver, Gold, Platinum, Diamond
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int TournamentID { get; set; }
        public int StudentID { get; set; }
        public Rank? Rank { get; set; }

        public Tournament Tournament { get; set; }
        public Player Player { get; set; }
    }
}