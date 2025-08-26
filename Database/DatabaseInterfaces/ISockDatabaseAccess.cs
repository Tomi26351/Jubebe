namespace Database.DatabaseAccess;
using Core;

public interface ISockDatabaseAccess
{
    public void createSock(Sock sock);
    public List<Sock> getAllSocks();
}