using Microsoft.AspNetCore.Mvc;

namespace UsersREST;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private static readonly List<User> Users = [
        new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
        new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers() => Ok(Users);

    [HttpGet("{id}")]
    public ActionResult<User> GetUserById(int id)
    {
        var user = Users.FirstOrDefault(u => u.Id == id);
        return user is null ? NotFound() : Ok(user);
    }
}