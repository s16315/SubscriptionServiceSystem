using System.Threading.Tasks;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        bool CheckSubscriptionPayment(int userId, string productName);
    }
}