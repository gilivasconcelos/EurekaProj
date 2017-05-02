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
    public partial class FrmAlterarCadPessoa : Form
    {
        public FrmAlterarCadPessoa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Deseja realmente sair?", "Eureka Quiz",
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
