using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueDatabase.Models
{
    public class Tournament
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Reward { get; set; }
        public int PlayerID { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}