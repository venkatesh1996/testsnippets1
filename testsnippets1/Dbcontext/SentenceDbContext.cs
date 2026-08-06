using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using testsnippets1.Models;

namespace testsnippets1.Dbcontext
{
    // C#
    internal class SentenceDbContext : DbContext
    {
        public DbSet<SentenceHolder> Sentences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("SentencesDb");
            // LocalDB connection string (works with Visual Studio)
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SentencesDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SentenceHolder>().HasKey(s => s.Id);
        }
       
        
    }
}
