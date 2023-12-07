using System.ComponentModel.DataAnnotations;
namespace WEBAPI.Models.DTOs

{
    public class BookUpdateDTO : BaseModel
    {
        [MaxLength(50)]
        public string? Title { get; set; }
        [MaxLength(30)]
        public string? Author { get; set; }
        [MaxLength(100)]
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(150)]
        public string? Remarks { get; set; }
    }
    
}