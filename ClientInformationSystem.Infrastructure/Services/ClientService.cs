using ClientInformationSystem.Core.RepositoryInterface;
using ClientInformationSystem.Core.Entities;
using ClientInformationSystem.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Infrastructure.Services
{
    public class ClientService:IClientService
    {
        //call this class
        private readonly IClientRepository _clientRepository;
        //depedency injection
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        //Implment interface
        public async Task<Clients> AddClients(Clients clients)
        {
            return await _clientRepository.AddAsync(clients);
        }

        public async Task<IEnumerable<Clients>> GetALLClients()
        {
            return await _clientRepository.ListAllAsync();
        }

        public async  Task<Clients> GetClientsById(int id)
        {
            return await _clientRepository.GetByIdAsync(id);
        }

        public async Task<Clients> UpdateClients(Clients clients)
        {
            return await _clientRepository.UpdateAsync(clients);
        }



    }
}
