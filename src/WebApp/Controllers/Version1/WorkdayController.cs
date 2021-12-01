﻿using Microsoft.AspNetCore.Mvc;
using Presentismo.Application.Features.Version1.Workday.Commands.FinishWorkday;
using Presentismo.Application.Features.Version1.Workday.Commands.InitWorkday;

using System.Threading.Tasks;

namespace WebApp.Controllers.Version1
{
    public class WorkdayController : ApiControllerBase
    {
        [HttpPost("initial")]
        public async Task<IActionResult> InitialWorkday([FromBody] InitWorkdayContract.InitCommand command)
        {
            var res = await Mediator.Send(command);
            return Ok(res);
        }
        [HttpPost("finish")]
        public async Task<IActionResult> FinishWorkday([FromBody] FinishWorkdayContract.FinishCommand command)
        {
            var res = await Mediator.Send(command);
            return Ok(res);
        }
    }
}
