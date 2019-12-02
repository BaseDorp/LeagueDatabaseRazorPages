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

        public Player Players { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Players = await _context.Players.FirstOrDefaultAsync(m => m.ID == id);

            if (Players == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
