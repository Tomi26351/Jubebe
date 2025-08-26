namespace Database.DatabaseAccess;
using Microsoft.Data.SqlClient;

public class Database
{
    private SqlConnection connection = new SqlConnection(@"Server=MSI\SQLEXPRESS;Database=Jubebe;Trusted_Connection=True;TrustServerCertificate=True;");
    public Database() { }

        public SqlConnection Connection { get { return connection; } }
}
