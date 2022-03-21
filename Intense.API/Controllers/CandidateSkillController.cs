using Intense.Application;
using Intense.Application.Candidate;
using Intense.Application.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Intense.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateSkillController : ControllerBase
    {
        private readonly UseCaseExecutor executor;

        public CandidateSkillController(UseCaseExecutor executor)
        {
            this.executor = executor;
        }


        // POST api/<CandidateSkillController>
        [HttpPost]
        public void Post(
            [FromBody] SkillCandidateDTO dto,
            [FromServices] IUpdateJobCandidateWithSkill command
            )
        {
            executor.ExecuteCommand(command, dto);
        }

        // DELETE api/<CandidateSkillController>/5
        [HttpDelete("{id}")]
        public void Delete(
            [FromServices] IRemoveSkillFromJobCandidate command,
            [FromBody] SkillCandidateDTO dto)
        {
            executor.ExecuteCommand(command, dto);
        }
    }
}
