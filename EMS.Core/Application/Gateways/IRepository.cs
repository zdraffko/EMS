using System;
using System.Threading.Tasks;

using EMS.Core.Domain.Interfaces;

namespace EMS.Core.Application.Gateways
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot
    {
        Task AddAsync(TEntity entity);

        Task<TEntity> GetByIdAsync(Guid id);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
