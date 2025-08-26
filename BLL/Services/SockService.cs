namespace BLL.Services;
using Database.DatabaseAccess;
using Core;

public class SockService
{
    public ISockDatabaseAccess _dbAccess;

    public SockService(ISockDatabaseAccess dbAccess)
    {
        _dbAccess = dbAccess;
    }

    public void createSock(Sock sock)
    {
        sock.OverallPrice = calcaulateOverallPrice(sock);
        _dbAccess.createSock(sock);
    }

    public double calcaulateOverallPrice(Sock sock)
    {
        return sock.PricePerPair * sock.QuantityPerSack * sock.SackQuantity;
    }

    public List<Sock> getAllSocks()
    {
        return _dbAccess.getAllSocks();
    }
}