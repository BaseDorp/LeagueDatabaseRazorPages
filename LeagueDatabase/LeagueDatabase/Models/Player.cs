﻿using System;
using System.Collections.Generic;

namespace LeagueDatabase.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Username { get; set; }
        public int MMR { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}