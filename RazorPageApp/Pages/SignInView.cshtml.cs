using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageApp.Models;
using RazorPageApp.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace RazorPageApp.Pages
{
    public class SignInViewModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;


        public SignInViewModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [BindProperty]
        public required LoginInputModel Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await _signInManager.PasswordSignInAsync(Input.Username, Input.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded) 
            {
                return RedirectToPage("/Index");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

    }
}
