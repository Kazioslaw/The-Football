using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TfcDomain.Models;
using TfcInfrastracture.DbContext;

namespace TheFootballClient.Pages.Matches
{
    public class DetailsModel : PageModel
    {
        private readonly TheFootballClientContext _context;

        public DetailsModel(TheFootballClientContext context)
        {
            _context = context;
        }

      public Match Match { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Matches == null)
            {
                return NotFound();
            }

            var match = await _context.Matches.FirstOrDefaultAsync(m => m.Id == id);
            if (match == null)
            {
                return NotFound();
            }
            else 
            {
                Match = match;
            }
            return Page();
        }
    }
}
