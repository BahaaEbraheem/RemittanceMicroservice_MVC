using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace CurrencyManagment.Pages;

public class IndexModel : CurrencyManagmentPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
