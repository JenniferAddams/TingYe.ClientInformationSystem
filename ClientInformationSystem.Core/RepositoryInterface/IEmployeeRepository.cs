using ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientInformationSystem.Core.RepositoryInterface
{
    public interface IEmployeeRepository:IAsyncRepository<Employees>

    {
    }
}
