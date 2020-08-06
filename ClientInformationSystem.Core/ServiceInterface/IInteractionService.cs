using ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ClientInformationSystem.Core.ServiceInterface
{
   public  interface IInteractionService
    {

        Task<Interactions> GetByEmpId(int EmpId);
        Task<Interactions> GetByClientId(int ClientId);
    }
}
