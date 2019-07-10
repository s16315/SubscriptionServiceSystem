using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly SsaContext _ssaContext;

        public UsersRepository(SsaContext ssaContext)
        {
            _ssaContext = ssaContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _ssaContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _ssaContext.Users.Where(x => x.Id == id)
                .Include(x => x.Person)
                .Include(x => x.Person.Address)
                .Include(x => x.Person.Invoice)
                .SingleOrDefaultAsync();
        }

        public async Task<User> GetByName(string name)
        {
            return await _ssaContext.Users.Where(x => x.UserName == name)
                .SingleOrDefaultAsync();
        }

        public Task Add(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task TrueDelete(User entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}