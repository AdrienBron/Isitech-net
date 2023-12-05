using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Models;
namespace WEBAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly AppDbContext _context;
    public BookController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get(){
        return await _context.Books.ToListAsync();
    }

    // GET: api/Book/[id]
    [HttpGet("Get/{id}", Name = nameof(GetBook))]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }

        return book;
    }

    // POST: api/Book
    // BODY: Book (JSON)
    [HttpPost]
    [ProducesResponseType(201, Type = typeof(Book))]
    [ProducesResponseType(400)]
    public async Task<ActionResult<Book>> PostBook([FromBody] Book book)
    {
        // we check if the parameter is null
        if (book == null)
        {
            return BadRequest();
        }
        // we check if the book already exists
        Book? addedBook = await _context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
        if (addedBook != null)
        {
            return BadRequest("Book already exists");
        }
        else
        {
            // we add the book to the database
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            // we return the book
            return CreatedAtRoute(
                routeName: nameof(GetBook),
                routeValues: new { id = book.Id },
                value: book);

        }
    }

    // TODO: PUT: api/Book/[id] creer la route qui permet de mettre a jour un livre existant
/*     [HttpGet("Put/{id}")]
    [ProducesResponseType(201, Type = typeof(Book))]
    [ProducesResponseType(400)]
    public async Task<ActionResult<Book>> PutBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        
        // we check if the parameter is null
        if (book == null)
        {
            return BadRequest();
        }
        // we check if the book already exists
        Book? addedBook = await _context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
        if (addedBook == null)
        {
            return BadRequest();
        }
        else
        {
            // we add the book to the database
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            // we return the book
            return CreatedAtRoute(
                routeName: nameof(GetBook),
                routeValues: new { id = book.Id },
                value: book);
        }
    } */

    // TODO: DELETE: api/Book/[id] creer la route qui permet de supprimer un livre existant
    [HttpGet("Delete/{id}")]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }
        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

            // we return the book
        return CreatedAtRoute(
            routeName: nameof(GetBook),
            routeValues: new { id = book.Id },
            value: book);
    }


}