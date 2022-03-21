using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Domain
{
    public class Skill : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<CandidateSkill> CandidateSkills { get; set; } = new HashSet<CandidateSkill>();
    }
}
