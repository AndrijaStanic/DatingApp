using System.Collections.Generic;
using System.Threading.Tasks;
using Dating.API.Models;

namespace Dating.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class; //adding User/Photo -class
         void Delete<T>(T entity) where T: class; //deleting User/Photo -class
         Task<bool> SaveAll(); //false=no changers, true=changes
         Task<IEnumerable<User>> GetUsers(); //lists all users
         Task<User> GetUser(int id); //lists a single user tracked by id
    }
}