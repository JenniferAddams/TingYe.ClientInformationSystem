using ClientInformationSystem.Core.Entities;
using ClientInformationSystem.Core.RepositoryInterface;
using ClientInformationSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientInformationSystem.Infrastructure.Repositories
{
    public class EmployeeRepository : EfRepository<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(ClientInformationSystemDbContext dbContext ) :base(dbContext)
        {

        }

    }
}
