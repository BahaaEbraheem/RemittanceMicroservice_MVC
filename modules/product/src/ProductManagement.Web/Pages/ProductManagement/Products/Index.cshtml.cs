using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProductManagement.Pages.ProductManagement.Products
{
    public class IndexModel : AbpPageModel
    {
        public Task OnGetAsync()
        {
            return Task.CompletedTask;
        }
    }
}