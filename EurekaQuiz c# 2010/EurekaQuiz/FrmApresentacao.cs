using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//using MySql.Data;
//using MySql.Data.MySqlClient;
//using System.Data.SqlClient;

namespace EurekaQuiz
{
    public partial class FrmApresentacao : Form
    {
        public FrmApresentacao()
        {
            InitializeComponent();
        }

        Boolean opcSom = true, playStop = true;

        public  void tocaMusica(Boolean playStop)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = "C:/Users/Gili/Documents/Visual Studio 2010/Projects/EurekaQuiz c# 2010/audio/Fooling Mode-Naruto.wav";

            if (playStop == true)
            {
                player.Play();
            }
            else
            {
                player.Stop();
            }
            
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            playStop = true;
            tocaMusica(playStop);
        }

        private void btnPular_Click(object sender, EventArgs e)
        {

            playStop = false;
            tocaMusica(playStop);

            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FrmLogin frmLogin = new FrmLogin();

                //Mostre o segundo form
                frmLogin.ShowDialog();
            }

        

            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            if  (opcSom ==true )
            {
            
            pictureBox3.Image= Image.FromFile("C:/Users/Gili/Documents/Visual Studio 2010/Projects/EurekaQuiz c# 2010/imagens/audioOff.png");
            playStop = false;
            opcSom = false;
            tocaMusica(playStop);
            }

            else
            {
                pictureBox3.Image = Image.FromFile("C:/Users/Gili/Documents/Visual Studio 2010/Projects/EurekaQuiz c# 2010/imagens/audioOn.png");
                playStop = true;
                opcSom = true;
                tocaMusica(playStop);

            }
        

           
        }
    }
}
