﻿using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Mission6_Simmons.Models;
using System.Collections.Generic;

namespace Mission6_Simmons.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }
       
    }
}
