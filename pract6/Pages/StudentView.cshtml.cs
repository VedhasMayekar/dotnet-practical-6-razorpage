using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pract6.Models;

namespace pract6.Pages
{
    public class StudentViewModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; } = new Student();

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("Success", new { name = student.Name });
        }
    }
}
