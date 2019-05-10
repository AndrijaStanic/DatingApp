using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating.API.Helpers;
using Dating.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dating.API.Data
{
    public class DatingRepository : IDatingRepository
    {
        private readonly DataContext _context;

        public DatingRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity); //spremi entitet u memoriju
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity); //brise entitet iz memorije
        }

        public async Task<Photo> GetMainPhotoForUser(int userId) //dohvaca profilnu sliku usera ili null ako nema main
        {
            return await _context.Photos.Where(u => u.UserId == userId).FirstOrDefaultAsync(p => p.IsMain);
        }

        public async Task<Photo> GetPhoto(int id) //dohvaca sliku pod id-u
        {
            var photo = await _context.Photos.FirstOrDefaultAsync(p => p.Id == id);
            return photo;
        }
        public async Task<User> GetUser(int id) //dohvaca id ili null ako ne dohvati
        {
            var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams) //dohavaca listu usera
        {
            var users =  _context.Users.Include(p => p.Photos);
            return await PagedList<User>.CreateAsync(users, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<bool> SaveAll() //sprema ako se ima sta spremit
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}