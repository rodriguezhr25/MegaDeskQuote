using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDeskQuote.Models;

namespace MegaDeskQuote.Data
{
    public class MegaDeskQuoteContext : DbContext
    {
        public MegaDeskQuoteContext (DbContextOptions<MegaDeskQuoteContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskQuote.Models.DeskQuote> DeskQuote { get; set; }
    }
}
