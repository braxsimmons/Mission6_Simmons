using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6_Simmons.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [StringLength(25)]
        public string? Notes { get; set; } = string.Empty;

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        // Incorporate Rating directly into MovieModel
        [Required]
        public string Rating { get; set; } = string.Empty; // Assuming rating is a string like "PG-13", "R", etc.
    }
}
