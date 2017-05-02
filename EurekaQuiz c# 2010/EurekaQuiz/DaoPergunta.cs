using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace EurekaQuiz
{
    class DaoPergunta
    {           

        public void cadastroPergunta(Pergunta pergunta)
        {
           
            try
            {
                String caminho = "server=(local);database=eurekadb;integrated Security=SSPI;";


                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();


                String comparar = "SELECT COUNT(*) FROM tb_pergunta";



                SqlCommand comandos = new SqlCommand(comparar, conexao);

                int qtdPerguntas = int.Parse(comandos.ExecuteScalar().ToString());

                pergunta.IdPergunta = qtdPerguntas + 1;

                string inserir = "INSERT INTO tb_pergunta (idPergunta, pergDescri, opc_a, opc_b, opc_c, opc_certa) values ('" + pergunta.IdPergunta + "', '" + pergunta.PergDescri + "', '" + pergunta.Opc_a + "','" + pergunta.Opc_b + "','" + pergunta.Opc_c + "','" + pergunta.Opc_c + "','" + pergunta.Opc_certa + "')";

                comandos = new SqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        public void sorteiaPergunta(Pergunta pergunta)
        {


            try
            {
                String caminho = "server=(local);database=eurekadb;integrated Security=SSPI;";


                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String comparar = "SELECT COUNT(*) FROM tb_pergunta";

                SqlCommand comandos = new SqlCommand(comparar, conexao);

                int qtdPerguntas = int.Parse(comandos.ExecuteScalar().ToString());

               
                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar." + ex.Message);
            }
        }
    }
    }