﻿using freecodecamp.Models;
using Microsoft.EntityFrameworkCore;

namespace freecodecamp.context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
