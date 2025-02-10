using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

public class Conexao
{
    static MySqlConnection conexao;
    public static MySqlConnection Conectar()
    {
        try
        {
            string strconexao = "server=localhost; uid=root; pwd=mateus; database=AtividadeElias";
            conexao = new MySqlConnection(strconexao);
            conexao.Open();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao realizar a conexão com a base de dados!");
        }
        return conexao;
    }
    public static void FecharConexao()
    {
        conexao.Close();
    }
}








