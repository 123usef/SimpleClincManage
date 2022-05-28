using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleClincManage.ViewModel;

namespace SimpleClincManage.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;
        [BindProperty]
        public Login Model { get; set; }
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string? returnurl = null)
        {
            if (ModelState.IsValid)
            {
                var IdentityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.Remmemberme, false);
                if (IdentityResult.Succeeded)
                {
                    if (returnurl == null || returnurl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnurl);
                    }
                }
                ModelState.AddModelError("", "Username or Password incorrect");

            }

            return Page();

        }
    }
}
