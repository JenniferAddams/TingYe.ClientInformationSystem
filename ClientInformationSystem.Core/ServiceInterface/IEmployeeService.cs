using ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Core.ServiceInterface
{
   public  interface IEmployeeService
    {
        Task<Employees> UpdateEmployee(Employees employees);
        Task<Employees> AddEmployee(Employees employees);
        Task<IEnumerable<Employees>> GetALLEmployees();
        Task<Employees> GetEmployeeById(int id);
    }
}
