using System.Collections.Generic;
using System.Threading.Tasks;

namespace SubscriptionServiceApi.Infrastructure.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> GetByName(string name);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task TrueDelete(TEntity entity);
        Task Delete(int id);   
    }
}