using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace RemittanceManagement.Pages;

public class IndexModel : RemittanceManagementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
