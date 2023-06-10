using eComerce.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace eComerce.Data.Base
{
    public interface IEntityBaseRepository<T> where T:class, IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
