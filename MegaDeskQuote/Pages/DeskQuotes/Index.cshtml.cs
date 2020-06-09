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
    public class IndexModel : PageModel
    {
        private readonly MegaDeskQuote.Data.MegaDeskQuoteContext _context;

        public IndexModel(MegaDeskQuote.Data.MegaDeskQuoteContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchCustomer { get; set; }
        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CustomerFilter { get; set; }

        public async Task OnGetAsync(string sortOrder, string customerFilter, string searchCustomer)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            if (searchCustomer == null)            {

                searchCustomer = customerFilter;
            }

            CustomerFilter = searchCustomer;
        
            IQueryable<DeskQuote> deskQuotes = from s in _context.DeskQuote
                                                 select s;

            if (!string.IsNullOrEmpty(searchCustomer))
            {
                deskQuotes = deskQuotes.Where(s => s.Customer.Contains(searchCustomer));
            }
          

            switch (sortOrder)
            {
                case "name_desc":
                    deskQuotes = deskQuotes.OrderByDescending(s => s.Customer);
                    break;
                case "Date":
                    deskQuotes = deskQuotes.OrderBy(s => s.DateQuote);
                    break;
                case "date_desc":
                    deskQuotes = deskQuotes.OrderByDescending(s => s.DateQuote);
                    break;
                default:
                    deskQuotes = deskQuotes.OrderBy(s => s.Customer);
                    break;
            }

            DeskQuote = await deskQuotes.AsNoTracking().ToListAsync();
        }
    }
}
