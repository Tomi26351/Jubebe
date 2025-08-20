namespace Jubebe.Web.Pages;

using BLL.Services;
using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Database.DatabaseAccess;


public class AddSockModel : PageModel
{
    [BindProperty]
    public Sock Sock { get; set; }

    public SockService _sockService;

    public AddSockModel(SockService sockService)
    {
        _sockService = sockService;
    }

    public async Task<IActionResult> OnPost()
    {
        _sockService.createSock(Sock);
        return Redirect("/Index");
    }
}
