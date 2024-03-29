﻿using Microsoft.EntityFrameworkCore;
using StudentsManagemantSystem.Models;

namespace StudentsManagemantSystem.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Student>Students { get; set; }
    }
}
