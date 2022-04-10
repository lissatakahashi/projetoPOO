using projetopoo.Models;
using System.Data.SqlClient;

namespace projetopoo.Persistence.DAL
{
    public class FisicaDAL // Classe que tem acesso à base de dados.
    {
        private SqlConnection _sqlConnection;
        public FisicaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Fisica fisica)
        {
            _sqlConnection.Open(); // Abre a conexão.
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText =
                "insert into TB_Fisica(FisicaID, Nome, Idade, Login, Senha, Cpf) " +
                "values (@fisicaID, @nome, @idade, @login, @senha, @cpf)";
            command.Parameters.AddWithValue("@fisicaID", fisica.FisicaID);
            command.Parameters.AddWithValue("@nome", fisica.Nome);
            command.Parameters.AddWithValue("@idade", fisica.Idade);
            command.Parameters.AddWithValue("@login", fisica.Login);
            command.Parameters.AddWithValue("@senha", fisica.Senha);
            command.Parameters.AddWithValue("@cpf", fisica.Cpf);
           // command.Parameters.AddWithValue("@datadenascimento", fisica.DataDeNascimento);
            command.ExecuteNonQuery(); // É uma atualização, não uma consulta.
            _sqlConnection.Close(); // Fecha a conexão.
        }
    }
}
