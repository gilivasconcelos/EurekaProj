using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace EurekaQuiz
{
    class DaoPergunta
    {
               

        public int escolheNivel(int valor)
        {

            return valor;

        }


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

                string inserir = "INSERT INTO tb_pergunta (idPergunta, idNivel, pergDescri, opc_a, opc_b, opc_c, opc_certa) values ('" + pergunta.IdPergunta + "', '" + pergunta.IdNivel + "', '" + pergunta.PergDescri + "', '" + pergunta.Opc_a + "','" + pergunta.Opc_b + "','" + pergunta.Opc_c + "','" + pergunta.Opc_certa + "')";

                comandos = new SqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }

        public Pergunta retornaPergunta(Pergunta pergunta)
        {


            try
            {
                String caminho = "server=(local);database=eurekadb;integrated Security=SSPI;";


                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String comparar = "SELECT COUNT(*) FROM tb_pergunta";

                SqlCommand comandos = new SqlCommand(comparar, conexao);

                int qtdPerguntas = int.Parse(comandos.ExecuteScalar().ToString());
                    //sorteia um numero de 0 até qtdPerguntas
                    Random random = new Random();
                    int idSorteado = random.Next(1, qtdPerguntas);
                 
                    String buscar = "SELECT * FROM tb_pergunta where idPergunta = " + idSorteado;
                                   

                //comandos = new SqlCommand(buscar, conexao);
                //comandos.ExecuteNonQuery();

                //object obj = comandos.ExecuteScalar();

                

                //string pergDescri = obj.ToString();
                
                //pergunta.PergDescri = pergDescri;


                //SqlDataReader rdr = comandos.ExecuteReader();
                
                    
                //        pergunta.Opc_certa = (String)rdr["Column1"];
                //        pergunta.PergDescri = (String)rdr["Column2"];


     using (SqlDataAdapter a = new SqlDataAdapter(buscar, conexao))
     {

         DataTable t = new DataTable();
        a.Fill(t);
        if(t.Rows.Count > 0)
         {
             
             pergunta.IdPergunta = Int32.Parse(t.Rows[0]["idPergunta"].ToString());
             pergunta.IdNivel = Int32.Parse(t.Rows[0]["idNivel"].ToString());
             pergunta.PergDescri = t.Rows[0]["pergDescri"].ToString();
             pergunta.Opc_a = t.Rows[0]["opc_a"].ToString();
             pergunta.Opc_b = t.Rows[0]["opc_b"].ToString();
             pergunta.Opc_c = t.Rows[0]["opc_c"].ToString();
             pergunta.Opc_d = t.Rows[0]["opc_d"].ToString();
             pergunta.Opc_e = t.Rows[0]["opc_e"].ToString();
             pergunta.Opc_certa = t.Rows[0]["opc_certa"].ToString();
            
         }    
    }

                conexao.Close();
                                  
                return pergunta;                

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar." + ex.Message);
            }
        }
    }
}