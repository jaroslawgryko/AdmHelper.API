using System.Collections.Generic;
using System.Threading.Tasks;
using AdmHelper.API.Models;

namespace AdmHelper.API.Data
{
    public interface IHelperRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();

        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}