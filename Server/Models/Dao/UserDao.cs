namespace Server.Models.Dao;

public interface IUserDao
{
    Task<User> AddUserAsync(User user);
}

public class UserDao : IUserDao
{
    private readonly ServerDbContext _dbContext;

    public UserDao(ServerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> AddUserAsync(User user)
    {
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        
        return user;
    }
}