using System;
using System.Collections.Generic;
using System.Text;
using HeroProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeroProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> Heroes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
