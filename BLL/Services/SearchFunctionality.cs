namespace BLL.Services;
using Core;
using Database.DatabaseAccess;
public class SearchFunctionality
{
    private readonly ISockDatabaseAccess _dbAccess;

    public SearchFunctionality(ISockDatabaseAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }

    public List<Sock> SearchSocks(string query)
    {
        var searchedSocks = _dbAccess.getAllSocks().Where(s => s.SerialNumber.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        return searchedSocks;
    }
}