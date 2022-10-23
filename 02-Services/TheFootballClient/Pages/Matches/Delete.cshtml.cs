using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TfcDomain.Models;
using TfcInfrastracture.DbContext;

namespace TheFootballClient.Pages.Matches
{
    public class DeleteModel : PageModel
    {
        private readonly TheFootballClientContext _context;

        public DeleteModel(TheFootballClientContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Matches == null)
            {
                return NotFound();
            }
            var match = await _context.Matches.FindAsync(id);

            if (match != null)
            {
                Match = match;
                _context.Matches.Remove(Match);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
