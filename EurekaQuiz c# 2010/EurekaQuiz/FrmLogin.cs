using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EurekaQuiz
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmApresentacao_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            DaoUsuario dao = new DaoUsuario();

            user.Login = txtUsuario.Text;
            user.Senha = txtSenha.Text;

            dao.login(user);

            int resultado;
            resultado = user.QtdUsuario;

            if (resultado == 1)
            {
                FrmTelaInicio frmTelaInicio = new FrmTelaInicio();
                this.Hide();
                frmTelaInicio.ShowDialog();



            }

            else
            {
                MessageBox.Show("Login Inválido");

            }

            txtUsuario.Clear();
            txtSenha.Clear();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmResetarSenha frmResetarSenha = new FrmResetarSenha();

                //Mostre o segundo form
                frmResetarSenha.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Deseja realmente sair?", "Eureka Quiz",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnNovoCad_Click_1(object sender, EventArgs e)
        {

            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmCadastroPessoa frmCadastroPessoa = new FrmCadastroPessoa();

                //Mostre o segundo form
                frmCadastroPessoa.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmResetarSenha frmResetarSenha = new FrmResetarSenha();
                //Mostre o segundo form
                frmResetarSenha.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

       

      
    }
}
