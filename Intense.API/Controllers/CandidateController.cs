using Intense.Application;
using Intense.Application.Candidate;
using Intense.Application.DTO;
using Intense.Application.Search;
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
    public class CandidateController : ControllerBase
    {
        private readonly UseCaseExecutor executor;

        public CandidateController(UseCaseExecutor executor)
        {
            this.executor = executor;
        }

        // GET: api/<CandidateController>
        [HttpGet]
        public IActionResult Get(
            [FromQuery] CandidateSearch search,
            [FromServices] ISearchJobCandidate query
            )
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // POST api/<CandidateController>
        [HttpPost]
        public void Post(
            [FromBody] CandidateDTO dto,
            [FromServices] IAddJobCandidate command
            )
        {
            executor.ExecuteCommand(command, dto);
        }

        // DELETE api/<CandidateController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(
            [FromBody] int id,
            [FromServices] IRemoveCandidate command
            )
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
