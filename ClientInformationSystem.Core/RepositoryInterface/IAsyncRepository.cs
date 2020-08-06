using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformationSystem.Core.RepositoryInterface 
{
    
    public interface IAsyncRepository<T> where T : class
{
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> ListAllAsync();

    }
}
