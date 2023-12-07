using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Models;
namespace WEBAPI.Controllers;

[ApiController]
[Route("api/[controller]")] //Route par default
public class CustomerController : ControllerBase
{
    private readonly AppDbContext _context; //création d'un _context d'AppDbContext vide
    public CustomerController(AppDbContext context)
    {
        _context = context; //assignation du context
    }

    [HttpGet]
    public async Task<IEnumerable<Customer>> Get()
    {
        return await _context.Customers.ToListAsync();  //return une lite des Customers du context
    }

    // GET: api/Customer/[id]
    [HttpGet("Get/{id}", Name = nameof(GetCustomer))]
    public async Task<ActionResult<Customer>> GetCustomer(int id)
    {
        var Customer = await _context.Customers.FindAsync(id); //trouve un Customer qui a cette id
        if (Customer == null)
        {
            return NotFound();
        }
        return Customer;
    }
}