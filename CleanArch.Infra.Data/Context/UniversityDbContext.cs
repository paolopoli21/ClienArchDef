using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options) {

        }

        public DbSet<Course> Course { get; set; }

        
    }
}
