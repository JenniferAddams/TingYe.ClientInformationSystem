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
    public class EfRepository <T>: IAsyncRepository<T> where T : class
    {
        protected readonly ClientInformationSystemDbContext _dbContext;

        public EfRepository(ClientInformationSystemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;

        }
        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public virtual async Task<T> GetByIdAsync(int id)//make virtual ,will override
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }



}
