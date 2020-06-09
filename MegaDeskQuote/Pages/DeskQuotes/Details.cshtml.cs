using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskQuote.Data;
using MegaDeskQuote.Models;

namespace MegaDeskQuote.Pages.DeskQuotes
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskQuote.Data.MegaDeskQuoteContext _context;

        public DetailsModel(MegaDeskQuote.Data.MegaDeskQuoteContext context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
