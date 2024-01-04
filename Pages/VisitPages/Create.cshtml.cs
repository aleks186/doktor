using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using doctor;
using doctor.Model;

namespace doctor.Pages.VisitPages
{
    public class CreateModel : PageModel
    {
        private readonly doctor.ApplicationDbContext _context;

        public CreateModel(doctor.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Visit Visit { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Visits == null || Visit == null)
            {
                return Page();
            }

            _context.Visits.Add(Visit);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
