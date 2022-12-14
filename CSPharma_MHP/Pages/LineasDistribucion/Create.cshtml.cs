using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL.Models;

namespace CSPharma_MHP.Pages.LineasDistribucion
{
    public class CreateModel : PageModel
    {
        private readonly DAL.Models.CspharmaInformacionalContext _context;

        public CreateModel(DAL.Models.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TdcCatLineasDistribucion TdcCatLineasDistribucion { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TdcCatLineasDistribucions.Add(TdcCatLineasDistribucion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
