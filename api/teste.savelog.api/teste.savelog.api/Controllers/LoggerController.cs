using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.savelog.api.Models;

namespace teste.savelog.api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoggerController : ControllerBase
    {

        private readonly ILoggerService _iloggerService;

        public LoggerController(ILoggerService iloggerService)
        {
            _iloggerService = iloggerService;
        }

        [HttpPost]
        [Route("Warning/")]
        public async Task<IActionResult> LogWarning(LoggerRequest request)
        {
            if(request == null)
            {
                return BadRequest();
            }

            await _iloggerService.LogWarning(request);
            return Ok();
        }

        [HttpPost]
        [Route("Information/")]
        public async Task<IActionResult> LogInformation(LoggerRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            await _iloggerService.LogInformation(request);
            return Ok();
        }


        [HttpPost]
        [Route("Error/")]
        public async Task<IActionResult> LogError(LoggerRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            await _iloggerService.LogError(request);
            return Ok();
        }
    }
}
