using LearnAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnAPI.Data
{
    public class QuoteDBContext : DbContext
    {
        public QuoteDBContext(DbContextOptions<QuoteDBContext> options) : base(options)
        {
        }

        public DbSet<Quotes> Quotes { get; set; }
    }
}
