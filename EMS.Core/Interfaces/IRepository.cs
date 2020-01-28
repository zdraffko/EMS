using System;
using System.Threading.Tasks;

namespace EMS.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        Task AddAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(Guid id);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
