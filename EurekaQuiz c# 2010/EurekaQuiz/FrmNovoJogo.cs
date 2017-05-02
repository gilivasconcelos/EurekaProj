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
    public partial class FrmNovoJogo : Form
    {
        public FrmNovoJogo()
        {
            InitializeComponent();
        }

        public void buscaPergunta()
        {
            Pergunta pergunta = new Pergunta();
            DaoPergunta dao = new DaoPergunta();
            int valor=0;
            pergunta.IdNivel = dao.escolheNivel(valor);



            //  while(pergunta.IdNivel != nivel)
            pergunta = dao.retornaPergunta(pergunta);

            rtbDescri.Text = pergunta.PergDescri;

            pergunta = dao.retornaPergunta(pergunta);
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {

            buscaPergunta();


          
        }

        private void FrmNovoJogo_Load(object sender, EventArgs e)
        {
            buscaPergunta();
        }

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Deseja realmente desistir?", "Eureka Quiz",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
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


      
    }

