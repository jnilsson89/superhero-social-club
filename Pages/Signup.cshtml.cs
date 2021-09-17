using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Data;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages
{
    public class SignupModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Superhero Superhero { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public void OnGet()
        {
            Id = SuperheroDb.Superheroes.Count + 1;
            Superhero.Id = Id;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SuperheroDb.Superheroes.Add(Superhero);

            return RedirectToPage("/Superheroes");
        }
    }
}