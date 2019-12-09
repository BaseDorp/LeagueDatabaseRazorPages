using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LeagueDatabase.Data;
using LeagueDatabase.Models;

namespace LeagueDatabase.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly LeagueDatabase.Data.GameContext _context;

        public DetailsModel(LeagueDatabase.Data.GameContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Tournament)
                .AsNoTracking()
        .       FirstOrDefaultAsync(m => m.ID == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
