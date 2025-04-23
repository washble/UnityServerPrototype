using Microsoft.EntityFrameworkCore;

namespace Server.Models.Dao;

public interface IUserDao
{
    Task<User> GetUserAsync(string deviceId);
    Task<User> AddUserAsync(User user);
}

public class UserDao : IUserDao
{
    private readonly ServerDbContext _dbContext;

    public UserDao(ServerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> GetUserAsync(string deviceId)
    {
        User? userInfo 
            = await _dbContext.Users.FirstOrDefaultAsync(u => u.deviceId == deviceId);

        if (userInfo is not null)
        {
            return userInfo;
        }
        
        return null!;
    }

    public async Task<User> AddUserAsync(User user)
    {
        try
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return user.playerId > 0 ? user : null!;
        }
        catch (DbUpdateException e)
        {
            Console.WriteLine($"Error in AddUserAsync: {e.Message}");
            
            return null!;
        }
    }
}