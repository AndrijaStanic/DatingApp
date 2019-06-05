using System.Collections.Generic;
using System.Threading.Tasks;
using Dating.API.Helpers;
using Dating.API.Models;

namespace Dating.API.Data
{
    //interface za komunikaciju entiteta sa bazom
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class; //dodaje usera/sliku u memoriju
         void Delete<T>(T entity) where T: class; //brise usera ili sliku iz memorije
         Task<bool> SaveAll(); //spremni ako je true, inace: nista
         Task<PagedList<User>> GetUsers(UserParams userParams); //lista svih usera, dohavcena iz baze
         Task<User> GetUser(int id); //dohavca usera iz baze po Id-u
         Task<Photo> GetPhoto(int id); //dohavca sliku
         Task<Photo> GetMainPhotoForUser(int userId); //dohvaca glavnu sliku
         Task<Like> GetLike(int userId, int recipientId); //vraca likove
         Task<Message> GetMessage(int id); // vraca poruku
         Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams); // vraca sve poruke usera
         Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId); // razgovor usera
    }
}