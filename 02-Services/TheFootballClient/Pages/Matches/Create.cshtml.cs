using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TfcDomain.Models;
using TfcInfrastracture.DbContext;

namespace TheFootballClient.Pages.Matches
{
    public class CreateModel : PageModel
    {
        private readonly TheFootballClientContext _context;

        public CreateModel(TheFootballClientContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FirstClubId"] = new SelectList(_context.Clubs, "Id", "Name");
        ViewData["SecondClubId"] = new SelectList(_context.Clubs, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Match Match { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Matches.Add(Match);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
