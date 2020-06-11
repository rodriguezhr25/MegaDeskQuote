using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskQuote.Data;
using MegaDeskQuote.Models;

namespace MegaDeskQuote.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskQuote.Data.MegaDeskQuoteContext _context;

        public CreateModel(MegaDeskQuote.Data.MegaDeskQuoteContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            DeskQuote.TotalSize = DeskQuote.Width * DeskQuote.Depth;

            //
            int cost = 0;
            switch (DeskQuote.Material)
                
            {
                case "Oak":

                    cost = 200;

                    break;
                case "Laminate":

                    cost = 100;

                    break;
                case "Pine":

                    cost = 50;

                    break;
                case "Rosewood":

                    cost = 300;

                    break;
                case "Veneer":

                    cost = 125;

                    break;
            }

            int cost1 = 0;

            decimal TotalSizeDesk = DeskQuote.TotalSize;

            switch (DeskQuote.RushDay)

            {
                case 3:

                    if ( TotalSizeDesk < 1000)

                        cost1 = 60;

                    else if (TotalSizeDesk < 2001)
                        cost1 = 70;

                    else cost1 = 80;

                    break;
                case 5:

                    if (TotalSizeDesk < 1000)

                        cost1 = 40;

                    else if (TotalSizeDesk < 2001)
                        cost1 = 50;

                    else cost1 = 60;

                    break;
                case 7:

                    if (TotalSizeDesk < 1000)

                        cost1 = 30;

                    else if (TotalSizeDesk < 2001)
                        cost1 = 35;

                    else cost1 = 40;

                    break;
                case 14:

                    cost1 = 0;

                    break;
            }

            //return cost1;
            //DeskQuote.Customer ="TEST";
        
            _context.DeskQuote.Add(DeskQuote);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
        }
    }
}
