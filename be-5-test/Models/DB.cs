using Microsoft.Data.SqlClient;

namespace be_5_test.Models
{
    public class DB
    {
        public static string connectionString = "server=DESKTOP-O9F15V0\\SQLEXPRESS; Initial Catalog=PoliziaMunicipale; Integrated Security=true; TrustServerCertificate=true";
        public static SqlConnection conn = new SqlConnection(connectionString);
    }
}

