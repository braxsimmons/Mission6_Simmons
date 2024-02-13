using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Mission6_Simmons.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission6_Simmons.Models
{
    public class Rating
    {
       
        public Rating()
        {
            Name = string.Empty; // Ensures Name is never null
            Movies = new List<MovieModel>(); // Initializes the list to prevent null reference
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<MovieModel> Movies { get; set; }
    }

}
