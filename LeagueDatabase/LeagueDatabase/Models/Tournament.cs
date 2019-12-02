using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueDatabase.Models
{
    public class Tournament
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TournamentID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}