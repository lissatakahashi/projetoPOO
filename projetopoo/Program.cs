using projetopoo.Models;
using projetopoo.Persistence.DAL;
using System.Configuration;
using System.Data.SqlClient;

namespace projetopoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["POO_2022_1"].ConnectionString; // String de conexão
            Fisica fisica = new Fisica("Maria", 20, "mariaeduarda", "daldkdkl", 1050015351);
            FisicaDAL dal = new FisicaDAL(new SqlConnection(connectionString));
            dal.Inserir(fisica);
            Console.WriteLine("Registro realizado.");
            Console.ReadKey();
        }
    }
}
