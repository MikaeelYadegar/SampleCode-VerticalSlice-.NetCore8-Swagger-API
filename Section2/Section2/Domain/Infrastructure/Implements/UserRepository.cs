using Section2.Domain.Entities;
using Section2.Domain.Interfaces;

namespace Section2.Domain.Infrastructure.Implements;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
       _context = context;
    }
    public void CreateUser(User User)
    {
        _context.Users.Add(User);
        _context.SaveChanges();
    }

    public List<User> GetAllUsers()
    {
       ////var users = _context.Users.ToList();
        ////return users;
        return _context.Users.ToList();
    }

    public User GetUserById(long id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id)!;
    }

    public void UpdateUser(User User)
    {
        throw new NotImplementedException();
    }
}
