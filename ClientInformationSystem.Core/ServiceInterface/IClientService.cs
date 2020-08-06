using ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Core.ServiceInterface
{
    public interface IClientService
    {
        Task<Clients> UpdateClients(Clients clients);
        Task<Clients> AddClients(Clients clients);
        Task<IEnumerable<Clients>> GetALLClients();
        Task<Clients> GetClientsById(int id);
    }
}
