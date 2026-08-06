using EFCwithWebAPI.Dbcontext;
using EFCwithWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCwithWebAPI.Services
{
    internal class SentenceService : ISentenceService
    {
        private readonly SentenceDbContext _context;
        public SentenceService(SentenceDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SentenceHolder> GetAll() => _context.Sentences.AsNoTracking().ToList();
        public void AddSentence(SentenceHolder sentence)
        {
            _context.Sentences.Add(sentence);
            _context.SaveChanges();
        }

    }
}
