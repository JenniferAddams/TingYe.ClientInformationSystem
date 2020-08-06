using ClientInformationSystem.Core.RepositoryInterface;
using ClientInformationSystem.Core.Entities;
using ClientInformationSystem.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService 
    {
        //call this class
        private readonly IEmployeeRepository _employeeRepository;
        //depedency injection

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        //Implment interface
        public async Task<Employees> AddEmployee(Employees employees)
        {
            return await _employeeRepository.AddAsync(employees);
        }

        public async Task<IEnumerable<Employees>> GetALLEmployees()
        {
            return await _employeeRepository.ListAllAsync();
        }

        public async Task<Employees> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }


        public async Task<Employees> UpdateEmployee(Employees employees)
        {
            return await _employeeRepository.UpdateAsync(employees);
        }
    }
}
