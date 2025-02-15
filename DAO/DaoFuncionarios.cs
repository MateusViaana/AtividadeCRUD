using MySql.Data.MySqlClient;
using System;
public class DaoFuncionario
{
  
    public void Insert(Funcionarios funcionarios)
    {
        try
        {
            string sql = "Insert into alunos (cpfFuncionario, nome, funcao, email, cidade, estado, telefone, sexo, situacao, dataNascimento) " +
                "values (@cpfFuncionario, @nome, @funcao, @email, @cidade, @estado, @telefone, @sexo, situacao, @dataNascimento)";

            MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

            comando.Parameters.AddWithValue("@cpfFuncionario", funcionarios.cpf);
            comando.Parameters.AddWithValue("@nome", funcionarios.nome.);
            comando.Parameters.AddWithValue("@funcao", funcionarios.funcao);
            comando.Parameters.AddWithValue("@email", funcionarios.email);
            comando.Parameters.AddWithValue("@cidade", funcionarios.cidade);
            comando.Parameters.AddWithValue("@estado", funcionarios.estado);
            comando.Parameters.AddWithValue("@telefone", funcionarios.telefone);
            comando.Parameters.AddWithValue("@sexo", funcionarios.sexo);
            comando.Parameters.AddWithValue("@situacao", funcionarios.situacao);
            comando.Parameters.AddWithValue("@dataNascimento", funcionarios.dataNascimento);

            comando.ExecuteNonQuery();
        }
        catch (Exception ex) 
            {
                throw new Exception("Erro ao cadastrar! " + ex.Message); ;
            }
                              
    }
    public List<Funcionarios> List()
    {
        List<Funcionarios> funcionarios = new List<Funcionarios>();
        try
        {
            var sqll = "SELECT * FROM funcionarios order by nome";
            MySqlCommand comando = new MySqlCommand(sqll, Conexao.Conectar()) ;
            using (MySqlCommand dr = comando.ExecuteReader())
            {
                while (dr.ExecuteReader().Read())
                {
                    Funcionarios f1 = new Funcionarios();
                    f1.idFuncionario = dr.GetInt32("id_alu");

                }
            }
        }
        catch (Exception ex)
        {

            throw;
        }

        return funcionarios;
    }

}