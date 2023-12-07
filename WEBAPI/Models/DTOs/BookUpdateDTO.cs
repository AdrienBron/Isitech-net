using System.ComponentModel.DataAnnotations;
namespace WEBAPI.Models.DTOs

{

    public class BookUpdateDTO : BaseModel
    {
        [RegularExpression(@"([A-Za-z0-9]+( [A-Za-z0-9]+)+)", ErrorMessage = "Seulement les chiffres et les lettres sont acceptées")]
        [MaxLength(50)]
        public string? Title { get; set; }
        [RegularExpression(@"([A-Za-z]+( [A-Za-z]+)+)", ErrorMessage = "Seulement les lettres sont acceptées")]
        [MaxLength(30)]
        public string? Author { get; set; }
        [RegularExpression(@"([A-Za-z]+( [A-Za-z]+)+)", ErrorMessage = "Seulement les lettres sont acceptées")]
        [MaxLength(100)]
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
        [RegularExpression(@"([A-Za-z0-9]+( [A-Za-z0-9]+)+)", ErrorMessage = "Seulement les chiffres et les lettres sont acceptées")]
        [MaxLength(200)]
        public string? Description { get; set; }
        [RegularExpression(@"([A-Za-z0-9]+( [A-Za-z0-9]+)+)", ErrorMessage = "Seulement les chiffres et les lettres sont acceptées")]
        [MaxLength(150)]
        public string? Remarks { get; set; }
    }
    
}