﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Domain
{
    public class Candidate : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; } = new HashSet<CandidateSkill>();

        public string FullName => $"{FirstName} {LastName}";
    }
}
