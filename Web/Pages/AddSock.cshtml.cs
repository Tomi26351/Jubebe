namespace Jubebe.Web.Pages;

using BLL.Services;
using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


public class AddSockModel : PageModel
{
    [BindProperty]
    public Sock Sock { get; set; }

    public SockService _sockService;

    public AddSockModel(SockService sockService)
    {
        _sockService = sockService;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        _sockService.createSock(Sock);
        return Redirect("/Index");
    }
}
