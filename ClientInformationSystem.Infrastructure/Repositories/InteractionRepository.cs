using ClientInformationSystem.Core.Entities;
using ClientInformationSystem.Core.RepositoryInterface;
using ClientInformationSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Infrastructure.Repositories
{
    public class InteractionRepository : EfRepository<Interactions>, IInteractionRepository
    {
        public InteractionRepository(ClientInformationSystemDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<Interactions> GetByClientIdAsync(int ClientId)
        {
            var interactions = await _dbContext.Interactions.Where(i => i.ClientId == ClientId).FirstAsync();
            return interactions;
        }
        public async Task<Interactions> GetByEmployeeIdAsync(int EmpId)
        {
            var interactions = await _dbContext.Interactions.Where(i => i.EmpId == EmpId).FirstAsync(); ;
            return interactions;
        }
    }
}
