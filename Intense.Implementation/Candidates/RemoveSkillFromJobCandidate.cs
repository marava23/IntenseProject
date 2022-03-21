using Intense.Application.Candidate;
using Intense.Application.DTO;
using Intense.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Implementation.Candidates
{
    public class RemoveSkillFromJobCandidate : IRemoveSkillFromJobCandidate
    {
        private readonly IntenseContext _context;

        public RemoveSkillFromJobCandidate(IntenseContext context)
        {
            _context = context;
        }


        public void Execute(SkillCandidateDTO request)
        {
            var candidateSkill = _context.CandidateSkills.Find(request.CandidateId,request.SkillId);
            if(candidateSkill == null)
            {
                throw new EntryPointNotFoundException();
            }

            _context.CandidateSkills.Remove(candidateSkill);
            _context.SaveChanges();
        }
    }
}
