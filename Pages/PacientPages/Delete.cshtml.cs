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
    public class DeleteModel : PageModel
    {
        private readonly doctor.ApplicationDbContext _context;

        public DeleteModel(doctor.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Pacient Pacient { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pacients == null)
            {
                return NotFound();
            }

            var pacient = await _context.Pacients.FirstOrDefaultAsync(m => m.Id == id);

            if (pacient == null)
            {
                return NotFound();
            }
            else 
            {
                Pacient = pacient;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pacients == null)
            {
                return NotFound();
            }
            var pacient = await _context.Pacients.FindAsync(id);

            if (pacient != null)
            {
                Pacient = pacient;
                _context.Pacients.Remove(Pacient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
