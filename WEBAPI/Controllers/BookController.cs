using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Models.DTOs;
using WEBAPI.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
namespace WEBAPI.Controllers;

[ApiController]
[Route("api/[controller]")] //Route par default
public class BookController : ControllerBase
{
    private readonly AppDbContext _context; //création d'un _context d'AppDbContext vide
    private readonly IMapper _mapper;
    public BookController(AppDbContext context, IMapper mapper)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<BookUpdateDTO, Book>());
        mapper = config.CreateMapper();
        _mapper = mapper;
        _context = context; //assignation du context
    }

    [HttpGet]
    public async Task<IEnumerable<Book>> Get()
    {
        return await _context.Books.ToListAsync();  //return une lite des books du context
    }

    // GET: api/Book/[id]
    [HttpGet("Get/{id}", Name = nameof(GetBook))]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await _context.Books.FindAsync(id); //trouve un book qui a cette id
        if (book == null)
        {
            return NotFound();
        }
        return book;
    }
    // POST: api/Book
    // BODY: Book (JSON)
    [HttpPost("Post", Name = nameof(PostBook))]
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
    /*     [HttpPut("Put/{id},Title,Author,Genre,Price,PublishDate,Description,Remarks", Name = nameof(PutBook))]
        public async Task<ActionResult<Book>> PutBook(int id, string? Title, string? Author, string? Genre, decimal Price, DateTime PublishDate, string? Description, string? Remarks)
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
            Book newbooks=book;
            if (Title!=null)newbooks.Title=Title;
            if (Author!=null)newbooks.Author=Author;
            if (Genre!=null)newbooks.Genre=Genre;
            if (Price!=null)newbooks.Price=Price;
            if (PublishDate!=null)newbooks.PublishDate=PublishDate;
            if (Description!=null)newbooks.Description=Description;
            if (Remarks!=null)newbooks.Remarks=Remarks;
            await _context.SaveChangesAsync();

            return NoContent();
        }  */

    // TODO: PUT: api/Book/[id] creer la route qui permet de mettre a jour un livre existant
    // TODO: utilisez des annotations pour valider les donnees entrantes avec ModelState
    // TODO: utilisez le package AutoMapper pour mapper les donnees de BookUpdateDTO vers Book
    [HttpPut("{id}")]
    public async Task<ActionResult<Book>> PutBook(int id, [FromBody] BookUpdateDTO bookData)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return BadRequest();
        }
        if(!ModelState.IsValid){
            return BadRequest();
        }

        if (bookData.Title!="string") book.Title = bookData.Title;
        if (bookData.Author!="string")book.Author = bookData.Author;
        if (bookData.Genre!="string")book.Genre = bookData.Genre;
        if (bookData.Price!=0)book.Price = bookData.Price;
        if (bookData.Description!="string")book.Description = bookData.Description;
        if (bookData.Remarks!="string")book.Remarks = bookData.Remarks;
        await _context.SaveChangesAsync();
        return book;
    }

    // TODO: DELETE: api/Book/[id] creer la route qui permet de supprimer un livre existant
    [HttpDelete("Delete/{id}", Name = nameof(DeleteBook))]
    public async Task<ActionResult<Book>> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
        {
            return NotFound();
        }
        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}