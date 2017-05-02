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
    public partial class FrmCadastroPessoa : Form
    {
        public FrmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmTelaInicio frmTelaInicio = new FrmTelaInicio();

                //Mostre o segundo form
                frmTelaInicio.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            DaoUsuario dao = new DaoUsuario();

            user.Login = txtUsuario.Text;
            user.Senha = txtSenha.Text;

            dao.cadastroUsuario(user);

           
        

            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
