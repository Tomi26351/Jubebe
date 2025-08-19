namespace Jubebe.Web.Pages;

using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class AddSockModel : PageModel
{
    [BindProperty]
    public Sock Sock { get; set; } = new Sock();
    public void OnGet() { }
}
