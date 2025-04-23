using Server.Models.Dao;

namespace Server.Services;

public interface IUserService
{
    Task<User> GetUserAsync(string device);
    Task<User> AddUserAsync(User user);
}

public class UserService : IUserService
{
    private readonly IUserDao _userDAO;

    public UserService(IUserDao userDAO)
    {
        _userDAO = userDAO;
    }

    public async Task<User> GetUserAsync(string device)
    {
        return await _userDAO.GetUserAsync(device);
    }

    public async Task<User> AddUserAsync(User user)
    {
        return await _userDAO.AddUserAsync(user);
    }
}