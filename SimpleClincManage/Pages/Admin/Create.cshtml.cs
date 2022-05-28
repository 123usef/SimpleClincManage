using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleClincManage.Models;

namespace SimpleClincManage.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly AuthDbContext _db;
        public CreateModel(AuthDbContext db)
        {
            _db = db;

        }
        [BindProperty]
        public patients patients { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Patients.AddAsync(patients);
                await _db.SaveChangesAsync();
                return RedirectToPage("Patient");
            }
            else
            {
                return Page();
            }
        }
    }
}
