using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Simmons.Models
{
    public class MovieModel
    {
        [Key]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string? Title { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; } = string.Empty;

        //[Required]
        //public string Category { get; set; } = string.Empty;

        // Incorporate Rating directly into MovieModel
        public string?  Rating { get; set; } = string.Empty; // Assuming rating is a string like "PG-13", "R", etc.
    }
}
