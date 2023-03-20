using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] // /api/users

public class UsersController : ControllerBase
{
    private readonly DataContext _context;
   
    // Constructor
    public UsersController(DataContext context)
    {
        _context = context;
    }

    [HttpGet] // attribute
    // async -> async keyword + Task <>
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _context.Users.ToListAsync();

        return users;
    }

    [HttpGet("{id}")]
    // async -> async keyword + Task <>
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        return await _context.Users.FindAsync(id);
    }
}