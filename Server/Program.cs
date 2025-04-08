using Server;
using Server.Services;
using Microsoft.EntityFrameworkCore;
using Server.Models.Dao;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ServerDbContext>(options => options.UseMySql
(
    builder.Configuration.GetConnectionString("Db"),
    new MySqlServerVersion(new Version(11, 4, 5))
));

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserDao, UserDao>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();