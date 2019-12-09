using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeagueDatabase.Data;
using LeagueDatabase.Models;

namespace LeagueDatabase.Pages.Players
{
    public class EditModel : PageModel
    {
        private readonly LeagueDatabase.Data.GameContext _context;

        public EditModel(LeagueDatabase.Data.GameContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player.FindAsync(id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var studentToUpdate = await _context.Player.FindAsync(id);

            if (studentToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Player>(
                studentToUpdate,
                "player",
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate, s => s.Username, s => s.MMR))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }

        private bool PlayerExists(int id)
        {
            return _context.Player.Any(e => e.ID == id);
        }
    }
}
