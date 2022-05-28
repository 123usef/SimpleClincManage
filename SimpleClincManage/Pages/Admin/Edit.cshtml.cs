using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleClincManage.Models;

namespace SimpleClincManage.Pages.Admin
{
    public class EditModel : PageModel
    {
        private AuthDbContext _db;
        public EditModel(AuthDbContext db )
        {
            _db = db; 

        }
        [BindProperty]
        public patients Patients { get; set; }
        public async Task OnGet(int id )
        {
            Patients = await _db.Patients.FindAsync(id);
        }
        public async Task<IActionResult> OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                var patientfromdb = await _db.Patients.FindAsync(id);
                patientfromdb.PatientName = Patients.PatientName;
                patientfromdb.Email = Patients.Email;
                patientfromdb.PhoneNo = Patients.PhoneNo;
                patientfromdb.MedicalRec = Patients.MedicalRec;

                await _db.SaveChangesAsync();

                return RedirectToPage("Patient");

            }
            return RedirectToPage();

        }
    }
}
