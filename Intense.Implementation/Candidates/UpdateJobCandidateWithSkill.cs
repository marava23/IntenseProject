using FluentValidation;
using Intense.Application.Candidate;
using Intense.Application.DTO;
using Intense.Domain;
using Intense.EFDataAccess;
using Intense.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Implementation.Candidates
{
    public class UpdateJobCandidateWithSkill : IUpdateJobCandidateWithSkill
    {
        private readonly UpdateJobCandidateWithSkillValidator _validator;
        private readonly IntenseContext _context;

        public UpdateJobCandidateWithSkill(UpdateJobCandidateWithSkillValidator validator, IntenseContext context)
        {
            _validator = validator;
            _context = context;
        }

        public void Execute(SkillCandidateDTO request)
        {
            _validator.ValidateAndThrow(request);

            var candidateSkill = new CandidateSkill
            {
                SkillId = request.SkillId,
                CandidateId = request.CandidateId
            };

            _context.CandidateSkills.Add(candidateSkill);
            _context.SaveChanges();
        }
    }
}
