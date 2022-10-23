using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TfcDomain.Models;
using TfcInfrastracture.DbContext;

namespace TheFootballClient.Pages.Matches
{
    public class EditModel : PageModel
    {
        private readonly TheFootballClientContext _context;

        public EditModel(TheFootballClientContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Match Match { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Matches == null)
            {
                return NotFound();
            }

            var match =  await _context.Matches.FirstOrDefaultAsync(m => m.Id == id);
            if (match == null)
            {
                return NotFound();
            }
            Match = match;
           ViewData["FirstClubId"] = new SelectList(_context.Clubs, "Id", "Name");
           ViewData["SecondClubId"] = new SelectList(_context.Clubs, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Match).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatchExists(Match.Id))
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

        private bool MatchExists(int id)
        {
          return _context.Matches.Any(e => e.Id == id);
        }
    }
}
