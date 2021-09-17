using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages
{
    public class SuperherosModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Superhero Superhero { get; set; }

        public void OnGet()
        {

        }
    }
}
