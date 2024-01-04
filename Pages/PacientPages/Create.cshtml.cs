using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using doctor;
using doctor.Model;

namespace doctor.Pages.PacientPages
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
        public Pacient Pacient { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Pacients == null || Pacient == null)
            {
                return Page();
            }

            _context.Pacients.Add(Pacient);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
