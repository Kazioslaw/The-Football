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
    public class IndexModel : PageModel
    {
        private readonly TheFootballClientContext _context;

        public IndexModel(TheFootballClientContext context)
        {
            _context = context;
        }

        public IList<Match> Match { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Matches != null)
            {
                Match = await _context.Matches
                .Include(m => m.FirstClub)
                .Include(m => m.SecondClub).ToListAsync();
            }
        }
    }
}
