using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TextId.Models;

namespace TextId.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Possition> Possitions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
