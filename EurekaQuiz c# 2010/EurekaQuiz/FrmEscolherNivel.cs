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
    public partial class FrmEscolherNivel : Form
    {
        public FrmEscolherNivel()
        {
            InitializeComponent();
        }
      

        private void btnInicio_Click(object sender, EventArgs e)
        {

            int nivel =0;

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



            DaoPergunta dao = new DaoPergunta();
            dao.escolheNivel(nivel);
            
               
            

                 try
                 {
                     //Esconda o formulario atual
                     this.Hide();
                     // Crie apenas o segundo form
                     FrmNovoJogo frmNovoJogo = new FrmNovoJogo();

                     //Mostre o segundo form
                     frmNovoJogo.ShowDialog();
                 }
                 finally
                 {
                     // ao fechar, mostre novamente o inicial, ou feche this.Close();
                     this.Show();
                 }
            
            
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

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
