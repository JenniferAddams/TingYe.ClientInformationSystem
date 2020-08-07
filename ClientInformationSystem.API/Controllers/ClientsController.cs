using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientInformationSystem.Core.Entities;
using ClientInformationSystem.Core.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientInformationSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        //initialize
        private readonly IClientService _clientService;
        //depedency injection
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        [Route("ClientList")]
        //http://localhost:2283/api/clients/clientlist
        //we want the client page show client list
        public async Task<IActionResult> GetAllClients()
        {
            var client = await _clientService.GetALLClients();
            return Ok(client);
        }

        [HttpPost]
        [Route("Add")]
        //http://localhost:2283/api/clients/add
        public async Task<IActionResult> AddClient([FromBody]Clients clients)
        {
            var createdUser = await _clientService.AddClients(clients);
            return Ok(createdUser);
        }

    }
}
