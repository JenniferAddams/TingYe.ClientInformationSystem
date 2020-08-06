using ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Core.RepositoryInterface
{
   public interface IInteractionRepository:IAsyncRepository<Interactions>
    {
        Task<Interactions> GetByEmployeeIdAsync(int EmpId);
        Task<Interactions> GetByClientIdAsync(int ClientId);
    }
}
