using Core;
using Microsoft.Data.SqlClient;

namespace Database.DatabaseAccess;

public class SockDataBaseAccess
{
    private Database _connection;

    public SockDataBaseAccess()
    {
        _connection = new Database();
    }

    public void createSock(Sock sock)
    {
        string query = @"INSERT INTO [Jubebe].[dbo].[Sock](SerialNumber, PricePerPair, QuantityPerSack, SackQuantity, OverallPrice, dateTime)
                        VALUES(@SerialNumber, @PricePerPair, @QuantityPerSack, @SackQuantity, @OverallPrice, @dateTime)";

        _connection.Connection.Open();

        using (SqlCommand command = new SqlCommand(query, _connection.Connection))
        {
            command.Parameters.AddWithValue("@SerialNumber", sock.SerialNumber);
            command.Parameters.AddWithValue("@PricePerPair", sock.PricePerPair);
            command.Parameters.AddWithValue("@QuantityPerSack", sock.QuantityPerSack);
            command.Parameters.AddWithValue("@SackQuantity", sock.SackQuantity);
            command.Parameters.AddWithValue("@OverallPrice", sock);
            command.Parameters.AddWithValue("@dateTime", sock.dateTime);
        }

        
    }
}