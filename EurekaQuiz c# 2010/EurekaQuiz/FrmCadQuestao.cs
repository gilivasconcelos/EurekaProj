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
    public partial class FrmCadQuestao : Form
    {
        public FrmCadQuestao()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pergunta pergunta = new Pergunta();
            DaoPergunta dao = new DaoPergunta();
            int nivel = 0;

            pergunta.PergDescri = rTbQuestao.Text;
            pergunta.Opc_a = txtOpc_A.Text;
            pergunta.Opc_b = txtOpc_B.Text;
            pergunta.Opc_c = txtOpc_C.Text;
            pergunta.Opc_d = txtOpc_D.Text;
            pergunta.Opc_e = txtOpc_E.Text;


            if (rb_A.Checked == true)
            {
                pergunta.Opc_certa = "opc_a";
            }
            else if (rb_A.Checked == true)
            {
                pergunta.Opc_certa = "opc_b";
            }
            else if (rb_A.Checked == true)
            {
                pergunta.Opc_certa = "opc_c";
            }
            else if (rb_A.Checked == true)
            {
                pergunta.Opc_certa = "opc_d";
            }
            else
            {
                pergunta.Opc_certa = "opc_e";
            }

            

            if (rb_1.Checked == true)
            {
                nivel = 1;
            }
            else if (rb_2.Checked == true)
            {
                nivel = 2;
            }
            else
            {
                nivel = 3;
            }

            pergunta.IdNivel = nivel;

            dao.cadastroPergunta(pergunta);

            txtOpc_A.Clear();
            txtOpc_B.Clear();
            txtOpc_C.Clear();
            txtOpc_D.Clear();
            txtOpc_E.Clear();

            MessageBox.Show("Cadastrado com sucesso!", "Eureka Quiz",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
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

        
      
    }
}
