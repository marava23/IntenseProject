using Intense.Application;
using Intense.Application.DTO;
using Intense.Application.Skills;
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
    public class SkillController : ControllerBase
    {
        private readonly UseCaseExecutor executor;

        public SkillController(UseCaseExecutor executor)
        {
            this.executor = executor;
        }

        // POST api/<SkillController>
        [HttpPost]
        public void Post(
            [FromBody] SkillDTO dto,
            [FromServices] IAddSkill command)
        {
            executor.ExecuteCommand(command, dto);
        }
    }
}
