using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueDatabase.Data;
using LeagueDatabase.Models;

namespace LeagueDatabase.Pages.Tournaments
{
    public class DetailsModel : PageModel
    {
        private readonly LeagueDatabase.Data.GameContext _context;

        public DetailsModel(LeagueDatabase.Data.GameContext context)
        {
            _context = context;
        }

        public Tournament Tournament { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tournament = await _context.Tournaments.FirstOrDefaultAsync(m => m.TournamentID == id);

            if (Tournament == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
