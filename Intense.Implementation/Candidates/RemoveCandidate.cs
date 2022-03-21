using Intense.Application.Candidate;
using Intense.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intense.Implementation.Candidates
{
    public class RemoveCandidate : IRemoveCandidate
    {
        private readonly IntenseContext _context;

        public RemoveCandidate(IntenseContext context)
        {
            _context = context;
        }

        public void Execute(int request)
        {
            var candidate = _context.Candidates.Find(request);

            if(candidate == null)
            {
                throw new EntryPointNotFoundException();
            }

            _context.Candidates.Remove(candidate);

            _context.SaveChanges();
        }
    }
}
