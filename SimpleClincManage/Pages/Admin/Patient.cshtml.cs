using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleClincManage.Models;

namespace SimpleClincManage.Pages.Admin
{
    public class PatientModel : PageModel
    {
        private readonly AuthDbContext _db;
        public PatientModel(AuthDbContext db)
        {
            _db = db; 
        }
        public IEnumerable<patients> Patient; 
        public async Task  OnGet()
        {
           Patient= await _db.Patients.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var patient = await _db.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();

            }
            _db.Patients.Remove(patient);
            await _db.SaveChangesAsync();

            return RedirectToPage("Patient");
        }
    }
}
