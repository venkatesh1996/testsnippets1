using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFCwithWebAPI.Models;

namespace EFCwithWebAPI.Dbcontext
{
    // C#
    internal class SentenceDbContext : DbContext
    {
        public SentenceDbContext(DbContextOptions<SentenceDbContext> options) : base(options)
        {
        }
        public DbSet<SentenceHolder> Sentences { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SentenceHolder>().HasKey(s => s.Id);
        }
       
        
    }
}
