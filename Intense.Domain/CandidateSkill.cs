using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Domain
{
    public class CandidateSkill
    {
        public int CandidateId { get; set; }
        public int SkillId { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
