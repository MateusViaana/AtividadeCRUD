using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtidadeEliasCRUD
{
    public partial class Cadastrar : Form
    {

        public Cadastrar()
        {
            InitializeComponent();


        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!txtNome.Text.Equals("") && !txtCidade.Text.Equals("") && !txtCpf.Text.Equals("") && !txtDataNascimento.Equals("")
                    && !txtEmail.Text.Equals("") && !txtEstado.Text.Equals("") && !txtSexo.Text.Equals("") && !txtTelefone.Text.Equals("")
                    && !CbSituacao.Items.Equals(""))
                {

                    Funcionarios f1 = new Funcionarios();

                    {
                        f1.nome = txtNome.Text;
                        f1.cpf = txtCpf.Text;
                        f1.email = txtEmail.Text;
                        f1.funcao = txtFuncao.Text;
                        f1.telefone = txtTelefone.Text;
                        f1.estado = txtEstado.Text;
                        f1.cidade = txtCidade.Text;
                        f1.dataNascimento = DateTime.Parse(txtDataNascimento.Text);
                        DaoFuncionario f1Dao = new DaoFuncionario();
                        f1Dao.Insert(f1);
                        MessageBox.Show("Cadastro realizado com Sucesso!", "POO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBox.Show("Preencher todos os campos!");
                    txtCidade.Clear();
                    txtCpf.Clear();
                    txtDataNascimento.Clear();
                    txtEmail.Clear();
                    txtEstado.Clear();
                    txtNome.Clear();
                    txtSexo.Clear();
                    txtTelefone.Clear();
                    CbSituacao.Items.Clear();
                    txtNome.Focus();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO AO CADASTRAR O FUNCIONÁRIO" + ex.Message);
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            txtCidade.Clear();
            txtCpf.Clear();
            txtDataNascimento.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtNome.Clear();
            txtSexo.Clear();
            txtTelefone.Clear();
            CbSituacao.Items.Clear();
            txtNome.Focus();
        }

       
    }
}
