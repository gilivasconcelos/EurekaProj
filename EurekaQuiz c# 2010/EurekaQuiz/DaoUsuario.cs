using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace EurekaQuiz
{
    class DaoUsuario
    { 
        
      
        public void login(Usuario user)
        {
            
            
          try
            {
                String caminho = "server=(local);database=eurekadb;integrated Security=SSPI;";
                
        
              SqlConnection   conexao = new SqlConnection(caminho);
                conexao.Open();

                String comparar = "SELECT COUNT(*) FROM usuarioLogin WHERE usuario ='" + user.Login + "' AND senha = '" + user.Senha + "'";

                SqlCommand comandos = new SqlCommand(comparar, conexao);

                int valor = int.Parse(comandos.ExecuteScalar().ToString());

                user.QtdUsuario = valor;
                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar." + ex.Message);
            }
        }

        public void cadastroUsuario(Usuario user)
        {
           
            try
            {
                String caminho = "server=(local);database=eurekadb;integrated Security=SSPI;";


                SqlConnection conexao = new SqlConnection(caminho);
                conexao.Open();

                String comparar = "SELECT COUNT(*) FROM usuarioLogin";



                SqlCommand comandos = new SqlCommand(comparar, conexao);

                int qtdUsuarios = int.Parse(comandos.ExecuteScalar().ToString());

                user.IdUsuario = qtdUsuarios + 1;


                string inserir = "INSERT INTO usuarioLogin (usuario, senha) values ('" + user.IdUsuario + "','" + user.Login + "', '" + user.Senha + "')";

                comandos = new SqlCommand(inserir, conexao);
                comandos.ExecuteNonQuery();
                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos: " + ex.Message);
            }
        }
    }
    }