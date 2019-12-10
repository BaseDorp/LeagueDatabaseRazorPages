namespace LeagueDatabase.Models
{
    public enum Rank
    {
       // Bronze, Silver, Gold, Platinum, Diamond, Masters, Challengers
       A,B,C
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ID { get; set; }
        public int StudentID { get; set; }
        public Rank? Rank { get; set; }

        public Tournament Tournament { get; set; }
        public Player Player { get; set; }
    }
}