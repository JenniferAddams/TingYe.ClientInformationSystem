using ClientInformationSystem.Core.RepositoryInterface;
using ClientInformationSystem.Core.Entities;
using ClientInformationSystem.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ClientInformationSystem.Infrastructure.Services
{
    public class InteractionService : IInteractionService
    {        //call this class
        private readonly IInteractionRepository _interactionRepository;
        //depedency injection
        public InteractionService(IInteractionRepository interactionRepository)
        {
            _interactionRepository = interactionRepository;
        }

        //Implment interface
        public async Task<Interactions> GetByClientId(int ClientId)
        {
            return await _interactionRepository.GetByClientIdAsync(ClientId);
        }

        public async Task<Interactions> GetByEmpId(int EmpId)
        {
            return await _interactionRepository.GetByEmployeeIdAsync(EmpId);
        }
    }
}
