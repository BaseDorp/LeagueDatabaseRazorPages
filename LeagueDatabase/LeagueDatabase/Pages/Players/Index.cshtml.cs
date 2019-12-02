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
    public class IndexModel : PageModel
    {
        private readonly LeagueDatabase.Data.GameContext _context;

        public IndexModel(LeagueDatabase.Data.GameContext context)
        {
            _context = context;
        }

        public IList<Player> Players { get;set; }

        public async Task OnGetAsync()
        {
            Players = await _context.Players.ToListAsync();
        }
    }
}
