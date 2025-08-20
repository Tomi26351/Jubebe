using System.ComponentModel;
using BLL.Services;
using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace Jubebe.Web.Pages;

public class SocksOverviewModel : PageModel
{
    public SockService _sockService;

    [BindProperty]
    public List<Sock> allSocks { get; set; }

    public SocksOverviewModel(SockService sockService)
    {
        _sockService = sockService;
    }

    public void OnGet()
    {
        allSocks = _sockService.getAllSocks();
    }
}