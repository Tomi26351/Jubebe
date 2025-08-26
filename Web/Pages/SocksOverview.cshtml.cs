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
    public SearchFunctionality _searchService;

    [BindProperty]
    public List<Sock> allSocks { get; set; }
    [BindProperty]
    public Order order { get; set; }

    public SocksOverviewModel(SockService sockService, SearchFunctionality seachService)
    {
        _sockService = sockService;
        _searchService = seachService;
    }

    public void OnGet(string? query)
    {
        allSocks = string.IsNullOrWhiteSpace(query)
            ? _sockService.getAllSocks()
            : _searchService.SearchSocks(query);
    }

    public async Task<IActionResult> OnGetSearch(string query)
    {
        if (query != null)
        {
            allSocks = _searchService.SearchSocks(query);
        }

        return Page();
    }

    public void OnPostOrder()
    {

    }
}