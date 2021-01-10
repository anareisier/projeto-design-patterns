using cursoDesignPatterns.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            Impostos calculadora = new Impostos();

            calculadora.Calculo(orcamento, iss);

            //Conexão banco de dados

            /* Código antes de ser criada uma classe para a conexão com o banco de dados
            
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Server=localhost;Database=bancoDPtt";
            conexao.Open();
            */

            IDbConnection conexao = new ConnectionFactory().GetConnection(); // Linha que representa  o código acima

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";
        }
    }
}
