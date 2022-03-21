using Intense.Application.Candidate;
using Intense.Application.DTO;
using Intense.Application.Search;
using Intense.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Implementation.Candidates
{
    public class SearchJobCandidate : ISearchJobCandidate
    {
        private readonly IntenseContext _context;

        public SearchJobCandidate(IntenseContext context)
        {
            _context = context;
        }

        public PagedResponseDTO<CandidateDTO> Execute(CandidateSearch search)
        {
            var query = _context.Candidates.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x =>
                x.FirstName.ToLower().Contains(search.Name.ToLower()) ||
                x.LastName.ToLower().Contains(search.Name.ToLower())) ;
            }

            if (!string.IsNullOrEmpty(search.Skill) || !string.IsNullOrWhiteSpace(search.Skill))
            {
                query = query.Where(x => x.CandidateSkills.Any(y => y.Skill.Name.ToLower().Contains(search.Skill.ToLower())));
            }

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponseDTO<CandidateDTO>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new CandidateDTO
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthDay = x.BirthDay,
                    Email = x.Email,
                    PhoneNumber = x.PhoneNumber
                }).ToList()
            };

            return response;
        }
    }
}
