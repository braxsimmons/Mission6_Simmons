using System.ComponentModel.DataAnnotations;

namespace Mission6_Simmons.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}