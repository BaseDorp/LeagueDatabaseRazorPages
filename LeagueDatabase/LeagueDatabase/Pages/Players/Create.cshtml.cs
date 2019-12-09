using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LeagueDatabase.Data;
using LeagueDatabase.Models;

namespace LeagueDatabase.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly LeagueDatabase.Data.GameContext _context;

        public CreateModel(LeagueDatabase.Data.GameContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Player Player { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Player();

            if (await TryUpdateModelAsync<Player>(
                emptyStudent,
                "player",   // Prefix for form value.
                s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate, s => s.Username, s => s.MMR))
            {
                _context.Player.Add(emptyStudent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
