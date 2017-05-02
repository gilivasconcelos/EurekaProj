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
    public partial class FrmResetarSenha : Form
    {
        public FrmResetarSenha()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmApresentacao frmLogin = new FrmApresentacao();

                //Mostre o segundo form
                frmLogin.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
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
