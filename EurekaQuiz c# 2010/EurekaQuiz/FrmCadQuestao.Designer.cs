namespace EurekaQuiz
{
    partial class FrmCadQuestao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_A = new System.Windows.Forms.RadioButton();
            this.rb_B = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rTbQuestao = new System.Windows.Forms.RichTextBox();
            this.rb_C = new System.Windows.Forms.RadioButton();
            this.rb_D = new System.Windows.Forms.RadioButton();
            this.txtOpc_A = new System.Windows.Forms.TextBox();
            this.txtOpc_B = new System.Windows.Forms.TextBox();
            this.txtOpc_C = new System.Windows.Forms.TextBox();
            this.txtOpc_D = new System.Windows.Forms.TextBox();
            this.rb_E = new System.Windows.Forms.RadioButton();
            this.txtOpc_E = new System.Windows.Forms.TextBox();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(622, 372);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 32);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(25, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 32);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Controls.Add(this.txtOpc_E);
            this.groupBox1.Controls.Add(this.rb_1);
            this.groupBox1.Controls.Add(this.rb_E);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOpc_D);
            this.groupBox1.Controls.Add(this.txtOpc_C);
            this.groupBox1.Controls.Add(this.txtOpc_B);
            this.groupBox1.Controls.Add(this.txtOpc_A);
            this.groupBox1.Controls.Add(this.rb_D);
            this.groupBox1.Controls.Add(this.rb_C);
            this.groupBox1.Controls.Add(this.rTbQuestao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_B);
            this.groupBox1.Controls.Add(this.rb_A);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 421);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Questões";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Insira as opções e marque a correta:";
            // 
            // rb_A
            // 
            this.rb_A.AutoSize = true;
            this.rb_A.Checked = true;
            this.rb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_A.Location = new System.Drawing.Point(183, 165);
            this.rb_A.Name = "rb_A";
            this.rb_A.Size = new System.Drawing.Size(39, 24);
            this.rb_A.TabIndex = 13;
            this.rb_A.TabStop = true;
            this.rb_A.Text = "A";
            this.rb_A.UseVisualStyleBackColor = true;
            // 
            // rb_B
            // 
            this.rb_B.AutoSize = true;
            this.rb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_B.Location = new System.Drawing.Point(183, 200);
            this.rb_B.Name = "rb_B";
            this.rb_B.Size = new System.Drawing.Size(39, 24);
            this.rb_B.TabIndex = 14;
            this.rb_B.Text = "B";
            this.rb_B.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Insira a pergunta:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rTbQuestao
            // 
            this.rTbQuestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTbQuestao.Location = new System.Drawing.Point(183, 57);
            this.rTbQuestao.Name = "rTbQuestao";
            this.rTbQuestao.Size = new System.Drawing.Size(543, 78);
            this.rTbQuestao.TabIndex = 21;
            this.rTbQuestao.Text = "";
            this.rTbQuestao.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // rb_C
            // 
            this.rb_C.AutoSize = true;
            this.rb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_C.Location = new System.Drawing.Point(183, 235);
            this.rb_C.Name = "rb_C";
            this.rb_C.Size = new System.Drawing.Size(39, 24);
            this.rb_C.TabIndex = 22;
            this.rb_C.Text = "C";
            this.rb_C.UseVisualStyleBackColor = true;
            // 
            // rb_D
            // 
            this.rb_D.AutoSize = true;
            this.rb_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_D.Location = new System.Drawing.Point(184, 269);
            this.rb_D.Name = "rb_D";
            this.rb_D.Size = new System.Drawing.Size(40, 24);
            this.rb_D.TabIndex = 23;
            this.rb_D.Text = "D";
            this.rb_D.UseVisualStyleBackColor = true;
            // 
            // txtOpc_A
            // 
            this.txtOpc_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpc_A.Location = new System.Drawing.Point(230, 164);
            this.txtOpc_A.Name = "txtOpc_A";
            this.txtOpc_A.Size = new System.Drawing.Size(496, 26);
            this.txtOpc_A.TabIndex = 26;
            // 
            // txtOpc_B
            // 
            this.txtOpc_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpc_B.Location = new System.Drawing.Point(230, 199);
            this.txtOpc_B.Name = "txtOpc_B";
            this.txtOpc_B.Size = new System.Drawing.Size(496, 26);
            this.txtOpc_B.TabIndex = 27;
            this.txtOpc_B.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtOpc_C
            // 
            this.txtOpc_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpc_C.Location = new System.Drawing.Point(230, 234);
            this.txtOpc_C.Name = "txtOpc_C";
            this.txtOpc_C.Size = new System.Drawing.Size(496, 26);
            this.txtOpc_C.TabIndex = 28;
            // 
            // txtOpc_D
            // 
            this.txtOpc_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpc_D.Location = new System.Drawing.Point(230, 268);
            this.txtOpc_D.Name = "txtOpc_D";
            this.txtOpc_D.Size = new System.Drawing.Size(496, 26);
            this.txtOpc_D.TabIndex = 29;
            // 
            // rb_E
            // 
            this.rb_E.AutoSize = true;
            this.rb_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_E.Location = new System.Drawing.Point(184, 304);
            this.rb_E.Name = "rb_E";
            this.rb_E.Size = new System.Drawing.Size(39, 24);
            this.rb_E.TabIndex = 30;
            this.rb_E.Text = "E";
            this.rb_E.UseVisualStyleBackColor = true;
            // 
            // txtOpc_E
            // 
            this.txtOpc_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpc_E.Location = new System.Drawing.Point(230, 303);
            this.txtOpc_E.Name = "txtOpc_E";
            this.txtOpc_E.Size = new System.Drawing.Size(496, 26);
            this.txtOpc_E.TabIndex = 31;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_3.Location = new System.Drawing.Point(25, 127);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(37, 24);
            this.rb_3.TabIndex = 44;
            this.rb_3.Text = "3";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_2.Location = new System.Drawing.Point(25, 92);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(37, 24);
            this.rb_2.TabIndex = 43;
            this.rb_2.Text = "2";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Checked = true;
            this.rb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_1.Location = new System.Drawing.Point(25, 57);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(37, 24);
            this.rb_1.TabIndex = 42;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "1";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nível de dificuldade:";
            // 
            // FrmCadQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadQuestao";
            this.Text = "Eureka Quiz - Cadastro de Questões";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.TextBox txtOpc_E;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpc_D;
        private System.Windows.Forms.TextBox txtOpc_C;
        private System.Windows.Forms.TextBox txtOpc_B;
        private System.Windows.Forms.TextBox txtOpc_A;
        private System.Windows.Forms.RadioButton rb_D;
        private System.Windows.Forms.RadioButton rb_C;
        private System.Windows.Forms.RichTextBox rTbQuestao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_B;
        private System.Windows.Forms.RadioButton rb_A;
        private System.Windows.Forms.Label label7;


    }
}