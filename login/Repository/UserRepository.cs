using login.Data;
using login.Dto;
using login.Interfaces;
using login.Models;
using Microsoft.EntityFrameworkCore;

namespace login.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateUser(User user)
        {
            _context.Add(user);
            return Save();
        }

        public User GetUser(int id)
        {
            return _context.Users.Where(u => u.Id == id).FirstOrDefault();

        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public bool Save()
        {
            var Saved = _context.SaveChanges();
            return Saved > 0 ? true : false;
        }



        public bool TrueEntry(DtoLogin userToCheck)
        {
            return _context.Users.Any(u => u.userName == userToCheck.userName && u.password == userToCheck.password);
        }

        public bool UserExists(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }
    }
}
