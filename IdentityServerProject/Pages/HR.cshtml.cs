using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServerProject.Pages
{
    [Authorize(Policy ="MustBeHR")]
    public class HRModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
