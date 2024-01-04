using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using doctor;
using doctor.Model;

namespace doctor.Pages.PacientPages
{
    public class IndexModel : PageModel
    {
        private readonly doctor.ApplicationDbContext _context;

        public IndexModel(doctor.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Pacient> Pacient { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pacients != null)
            {
                Pacient = await _context.Pacients.ToListAsync();
            }
        }
    }
}
