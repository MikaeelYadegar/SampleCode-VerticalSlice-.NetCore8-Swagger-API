using Section2.Domain.Entities;

namespace Section2.Domain.Interfaces;

public interface IUserRepository
{
    void CreateUser(User User);
    void UpdateUser(User User);
    List<User> GetAllUsers();
    User GetUserById(long id);
}
