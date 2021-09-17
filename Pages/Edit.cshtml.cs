using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Data;
using SuperheroSocialClub.Models;
using System.Linq;

namespace SuperheroSocialClub.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Superhero Superhero { get; set; }

        public void OnGet()
        {
            Superhero = SuperheroDb.Superheroes.Where(h => h.Id == Superhero.Id).FirstOrDefault();
        }

        public IActionResult OnPost()
        {
            foreach (var hero in SuperheroDb.Superheroes)
            {
                if (hero.Id == Superhero.Id)
                {
                    hero.SuperheroName = Superhero.SuperheroName;
                    hero.SecretIdentity = Superhero.SecretIdentity;
                    hero.Superpower = Superhero.Superpower;
                }
            }
            return RedirectToPage("/Superheroes");
        }
    }
}
