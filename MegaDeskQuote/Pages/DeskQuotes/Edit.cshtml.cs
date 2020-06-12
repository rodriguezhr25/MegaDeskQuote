using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskQuote.Data;
using MegaDeskQuote.Models;

namespace MegaDeskQuote.Pages.DeskQuotes
{
    public class EditModel : PageModel
    {
        private readonly MegaDeskQuote.Data.MegaDeskQuoteContext _context;

        public EditModel(MegaDeskQuote.Data.MegaDeskQuoteContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {


                //calculate the rest of values from input user
                DeskQuote.TotalSize = DeskQuote.Width * DeskQuote.Depth;


                //
                int cost = 0;
                switch (DeskQuote.Material)

                {
                    case DeskQuote.TMaterials.Oak:

                        cost = 200;

                        break;
                    case DeskQuote.TMaterials.Laminate:

                        cost = 100;

                        break;
                    case DeskQuote.TMaterials.Pine:

                        cost = 50;

                        break;
                    case DeskQuote.TMaterials.Rosewood:

                        cost = 300;

                        break;
                    case DeskQuote.TMaterials.Veneer:

                        cost = 125;

                        break;
                }

                DeskQuote.MaterialCost = cost;

                int cost1 = 0;

                decimal TotalSizeDesk = DeskQuote.TotalSize;

                switch (DeskQuote.RushDay)
                //switch (cost1)
                {
                    case DeskQuote.OptShipping.Three:

                        if (TotalSizeDesk < 1000)

                            cost1 = 60;

                        else if (TotalSizeDesk < 2001)
                            cost1 = 70;

                        else cost1 = 80;

                        DeskQuote.ShippingMethod = "3 Days";

                        break;
                    case DeskQuote.OptShipping.Five:

                        if (TotalSizeDesk < 1000)

                            cost1 = 40;

                        else if (TotalSizeDesk < 2001)
                            cost1 = 50;

                        else cost1 = 60;

                        DeskQuote.ShippingMethod = "5 Days";
                        break;
                    case DeskQuote.OptShipping.Seven:

                        if (TotalSizeDesk < 1000)

                            cost1 = 30;

                        else if (TotalSizeDesk < 2001)
                            cost1 = 35;

                        else cost1 = 40;

                        DeskQuote.ShippingMethod = "7 Days";
                        break;
                    case DeskQuote.OptShipping.Fourteen:

                        cost1 = 0;
                        DeskQuote.ShippingMethod = "Normal";
                        break;
                }
                DeskQuote.DrawerCost = DeskQuote.Drawers * 50;
                DeskQuote.ShippingCost = cost1;

                DeskQuote.Total = cost + cost1 + DeskQuote.DrawerCost;



                //---------------

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            


            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.ID == id);
        }
    }
}
