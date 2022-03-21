using Intense.Application.DTO;
using Intense.Application.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Application.Candidate
{
    public interface ISearchJobCandidate : IQuery<CandidateSearch, PagedResponseDTO<CandidateDTO>>
    {
    }
}
