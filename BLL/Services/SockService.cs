namespace BLL.Services;
using Database.DatabaseAccess;
using Core;

public class SockService
{
    public readonly SockDataBaseAccess _dbAccess;

    public SockService(SockDataBaseAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }

    public void addSock(Sock sock)
    {
        
    }
}