using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Models;
namespace WEBAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly AppDbContext _context;
    BookController(AppDbContext context)
    {
        this._context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get(){
        return await _context.Books.ToListAsync();
    }
}