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
    public partial class FrmTelaInicio : Form
    {
        public FrmTelaInicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmAlterarCadPessoa frmAlterarCadPessoa = new FrmAlterarCadPessoa();

                //Mostre o segundo form
                frmAlterarCadPessoa.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

        private void FrmTelaInico_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmConfig frmConfig = new FrmConfig();

                //Mostre o segundo form
                frmConfig.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmEscolherNivel frmEscolherNivel = new FrmEscolherNivel();

                //Mostre o segundo form
                frmEscolherNivel.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmIndices frmIndices = new FrmIndices();

                //Mostre o segundo form
                frmIndices.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                 try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmCadQuestao frmCadQuestao = new FrmCadQuestao();

                //Mostre o segundo form
                frmCadQuestao.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

   // Display a message box asking users if they
   // want to exit the application.
   if (MessageBox.Show ("Deseja realmente sair?", "Eureka Quiz",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes) 
   {
      Application.Exit();
   }

        }
    }
}
