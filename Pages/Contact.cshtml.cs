// Pages/Contact.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace PortfolioWebsite.Pages
{
    public class ContactModel : PageModel
    {
        // Properties to bind form input data
        [BindProperty]
        public ContactForm Input { get; set; }

        // Called automatically on HTTP GET requests
        public void OnGet()
        {
            // Initialize any necessary data here
        }

        // Called automatically on HTTP POST requests
        public IActionResult OnPost()
        {
            // Validate the form input
            if (!ModelState.IsValid)
            {
                // If the form submission is invalid, return the page with validation errors
                return Page();
            }

            // Process the contact form submission
            // For example, send an email, save to a database, etc.

            // Set a success message to notify the user
            TempData["SuccessMessage"] = "Thank you for contacting us. We will get back to you soon!";
            
            // Redirect to the same page to clear form input and display success message
            return RedirectToPage("/Contact");
        }
    }

    public class ContactForm
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Message must be between 5 and 500 characters")]
        public string Message { get; set; }
    }
}
