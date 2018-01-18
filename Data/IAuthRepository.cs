using System.Threading.Tasks;
using AdmHelper.API.Models;

namespace AdmHelper.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<bool> UserExists(string username);         
    }
}