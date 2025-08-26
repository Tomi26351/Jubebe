using Core;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
namespace Database.DatabaseAccess;

public class SockDatabaseAccess : ISockDatabaseAccess
{
    private Database _connection;

    public SockDatabaseAccess()
    {
        _connection = new Database();
    }

    public void createSock(Sock sock)
    {
        string query = @"INSERT INTO [Jubebe].[dbo].[Socks](SerialNumber, PricePerPair, QuantityPerSack, SackQuantity, OverallPrice, dateTime)
                        VALUES(@SerialNumber, @PricePerPair, @QuantityPerSack, @SackQuantity, @OverallPrice, @dateTime)";

        _connection.Connection.Open();

        using (SqlCommand command = new SqlCommand(query, _connection.Connection))
        {
            command.Parameters.AddWithValue("@SerialNumber", sock.SerialNumber);
            command.Parameters.AddWithValue("@PricePerPair", sock.PricePerPair);
            command.Parameters.AddWithValue("@QuantityPerSack", sock.QuantityPerSack);
            command.Parameters.AddWithValue("@SackQuantity", sock.SackQuantity);
            command.Parameters.AddWithValue("@OverallPrice", sock.OverallPrice);
            command.Parameters.AddWithValue("@dateTime", sock.dateTime);

            command.ExecuteNonQuery();
            _connection.Connection.Close();
        }

    }

    public List<Sock> getAllSocks()
    {
        string query = @"SELECT SerialNumber, PricePerPair, QuantityPerSack, SackQuantity, OverallPrice, dateTime FROM [Jubebe].[dbo].[Socks]";
        List<Sock> allSocks = new List<Sock>();

        _connection.Connection.Open();

        using (SqlCommand command = new SqlCommand(query, _connection.Connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Sock sock = new Sock
                    {
                        SerialNumber = reader.GetString(reader.GetOrdinal("SerialNumber")),
                        PricePerPair = reader.GetDouble(reader.GetOrdinal("PricePerPair")),
                        QuantityPerSack = reader.GetInt32(reader.GetOrdinal("QuantityPerSack")),
                        SackQuantity = reader.GetInt32(reader.GetOrdinal("SackQuantity")),
                        OverallPrice = reader.GetDouble(reader.GetOrdinal("OverallPrice")),
                        dateTime = reader.GetDateTime(reader.GetOrdinal("dateTime"))
                    };
                    allSocks.Add(sock);
                }
            }
        }
        
        _connection.Connection.Close();
        return allSocks;
    }
}