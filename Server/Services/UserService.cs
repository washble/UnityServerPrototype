using Server.Models.Dao;

namespace Server.Services;

public interface IUserService
{
    Task<User> AddUserAsync(User user);
}

public class UserService : IUserService
{
    private readonly IUserDao _userDAO;

    public UserService(IUserDao userDAO)
    {
        _userDAO = userDAO;
    }
    
    public async Task<User> AddUserAsync(User user)
    {
        return await _userDAO.AddUserAsync(user);
    }
}