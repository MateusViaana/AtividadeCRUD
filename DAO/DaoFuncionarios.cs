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
        return funcionarios;
    }


}