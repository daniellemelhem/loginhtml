using login.Dto;
using login.Models;

namespace login.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int id);
        bool UserExists(int id);
        bool CreateUser(User user);
        bool TrueEntry(DtoLogin userToCheck);
        bool Save();
    }
}
