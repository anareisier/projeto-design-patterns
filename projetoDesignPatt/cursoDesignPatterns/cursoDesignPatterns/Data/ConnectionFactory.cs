using System.Data;
using System.Data.SqlClient;

namespace cursoDesignPatterns.Data
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Server=localhost;Database=bancoDPtt";
            conexao.Open();

            return conexao;
        }
    }
}
