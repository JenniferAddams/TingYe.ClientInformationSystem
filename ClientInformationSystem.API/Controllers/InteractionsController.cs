using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientInformationSystem.Core.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientInformationSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InteractionsController : ControllerBase
    {
        //initialize 
        private readonly IInteractionService _interactionService;
        //depedency injection -> add all depedency injections to start up file
        public InteractionsController(IInteractionService interactionService)
        {
            _interactionService = interactionService;
        }

        //get interactions by Employee id
        [HttpGet]
        [Route("emp/{EmpId}")]
        //http://localhost:2283/api/interactions/emp/1
        public async Task<IActionResult> GetInteractionsByEmpId(int EmpId)
        {
            var interactions = await _interactionService.GetByEmpId(EmpId);
            return Ok(interactions);
        }
        //get interactions by Clients id
        [HttpGet]
        [Route("client/{ClientId}")]
          //http://localhost:2283/api/interactions/client/1
        public async Task<IActionResult> GetInteractionsByClientId(int ClientId)
        {
            var interactions = await _interactionService.GetByClientId(ClientId);
            return Ok(interactions);
        }

    }
}
