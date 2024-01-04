using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using doctor;
using doctor.Model;

namespace doctor.Pages.VisitPages
{
    public class DetailsModel : PageModel
    {
        private readonly doctor.ApplicationDbContext _context;

        public DetailsModel(doctor.ApplicationDbContext context)
        {
            _context = context;
        }

      public Visit Visit { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Visits == null)
            {
                return NotFound();
            }

            var visit = await _context.Visits.FirstOrDefaultAsync(m => m.Id == id);
            if (visit == null)
            {
                return NotFound();
            }
            else 
            {
                Visit = visit;
            }
            return Page();
        }
    }
}
