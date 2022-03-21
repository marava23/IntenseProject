using FluentValidation;
using Intense.Application.Candidate;
using Intense.Application.DTO;
using Intense.EFDataAccess;
using Intense.Implementation.Validators;
using Intense.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Implementation.Candidates
{
    public class AddJobCandidate : IAddJobCandidate
    {
        private readonly IntenseContext _context;
        private readonly CreateCandidateValidator _validator;

        public AddJobCandidate(IntenseContext context, CreateCandidateValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public void Execute(CandidateDTO request)
        {
            _validator.ValidateAndThrow(request);

            var candidate = new Candidate
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                BirthDay = request.BirthDay,
                PhoneNumber = request.PhoneNumber
            };

            _context.Candidates.Add(candidate);
            _context.SaveChanges();
        }
    }
}
