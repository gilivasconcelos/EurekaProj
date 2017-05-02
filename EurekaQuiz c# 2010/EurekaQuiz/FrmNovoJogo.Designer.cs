namespace EurekaQuiz
{
    partial class FrmNovoJogo
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
            this.btnDesistir = new System.Windows.Forms.Button();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOpcE = new System.Windows.Forms.TextBox();
            this.rbOpcE = new System.Windows.Forms.RadioButton();
            this.txtOpcD = new System.Windows.Forms.TextBox();
            this.txtOpcC = new System.Windows.Forms.TextBox();
            this.txtOpcB = new System.Windows.Forms.TextBox();
            this.txtOpcA = new System.Windows.Forms.TextBox();
            this.rbOpcD = new System.Windows.Forms.RadioButton();
            this.rbOpcC = new System.Windows.Forms.RadioButton();
            this.rtbDescri = new System.Windows.Forms.RichTextBox();
            this.lblResp = new System.Windows.Forms.Label();
            this.rbOpcB = new System.Windows.Forms.RadioButton();
            this.rbOpcA = new System.Windows.Forms.RadioButton();
            this.lblOpc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDesistir
            // 
            this.btnDesistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesistir.Location = new System.Drawing.Point(30, 372);
            this.btnDesistir.Name = "btnDesistir";
            this.btnDesistir.Size = new System.Drawing.Size(106, 32);
            this.btnDesistir.TabIndex = 33;
            this.btnDesistir.Text = "Desistir";
            this.btnDesistir.UseVisualStyleBackColor = true;
            this.btnDesistir.Click += new System.EventHandler(this.btnDesistir_Click);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.Location = new System.Drawing.Point(665, 372);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(104, 32);
            this.btnNovoJogo.TabIndex = 32;
            this.btnNovoJogo.Text = "Próximo";
            this.btnNovoJogo.UseVisualStyleBackColor = true;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesistir);
            this.groupBox1.Controls.Add(this.btnNovoJogo);
            this.groupBox1.Controls.Add(this.txtOpcE);
            this.groupBox1.Controls.Add(this.rbOpcE);
            this.groupBox1.Controls.Add(this.txtOpcD);
            this.groupBox1.Controls.Add(this.txtOpcC);
            this.groupBox1.Controls.Add(this.txtOpcB);
            this.groupBox1.Controls.Add(this.txtOpcA);
            this.groupBox1.Controls.Add(this.rbOpcD);
            this.groupBox1.Controls.Add(this.rbOpcC);
            this.groupBox1.Controls.Add(this.rtbDescri);
            this.groupBox1.Controls.Add(this.lblResp);
            this.groupBox1.Controls.Add(this.rbOpcB);
            this.groupBox1.Controls.Add(this.rbOpcA);
            this.groupBox1.Controls.Add(this.lblOpc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(46, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 421);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bem vindo";
            // 
            // txtOpcE
            // 
            this.txtOpcE.Enabled = false;
            this.txtOpcE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcE.Location = new System.Drawing.Point(230, 303);
            this.txtOpcE.Name = "txtOpcE";
            this.txtOpcE.Size = new System.Drawing.Size(496, 26);
            this.txtOpcE.TabIndex = 31;
            // 
            // rbOpcE
            // 
            this.rbOpcE.AutoSize = true;
            this.rbOpcE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcE.Location = new System.Drawing.Point(184, 304);
            this.rbOpcE.Name = "rbOpcE";
            this.rbOpcE.Size = new System.Drawing.Size(38, 24);
            this.rbOpcE.TabIndex = 30;
            this.rbOpcE.TabStop = true;
            this.rbOpcE.Text = "E";
            this.rbOpcE.UseVisualStyleBackColor = true;
            // 
            // txtOpcD
            // 
            this.txtOpcD.Enabled = false;
            this.txtOpcD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcD.Location = new System.Drawing.Point(230, 268);
            this.txtOpcD.Name = "txtOpcD";
            this.txtOpcD.Size = new System.Drawing.Size(496, 26);
            this.txtOpcD.TabIndex = 29;
            // 
            // txtOpcC
            // 
            this.txtOpcC.Enabled = false;
            this.txtOpcC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcC.Location = new System.Drawing.Point(230, 234);
            this.txtOpcC.Name = "txtOpcC";
            this.txtOpcC.Size = new System.Drawing.Size(496, 26);
            this.txtOpcC.TabIndex = 28;
            // 
            // txtOpcB
            // 
            this.txtOpcB.Enabled = false;
            this.txtOpcB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcB.Location = new System.Drawing.Point(230, 199);
            this.txtOpcB.Name = "txtOpcB";
            this.txtOpcB.Size = new System.Drawing.Size(496, 26);
            this.txtOpcB.TabIndex = 27;
            // 
            // txtOpcA
            // 
            this.txtOpcA.Enabled = false;
            this.txtOpcA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcA.Location = new System.Drawing.Point(230, 164);
            this.txtOpcA.Name = "txtOpcA";
            this.txtOpcA.Size = new System.Drawing.Size(496, 26);
            this.txtOpcA.TabIndex = 26;
            // 
            // rbOpcD
            // 
            this.rbOpcD.AutoSize = true;
            this.rbOpcD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcD.Location = new System.Drawing.Point(184, 269);
            this.rbOpcD.Name = "rbOpcD";
            this.rbOpcD.Size = new System.Drawing.Size(39, 24);
            this.rbOpcD.TabIndex = 23;
            this.rbOpcD.TabStop = true;
            this.rbOpcD.Text = "D";
            this.rbOpcD.UseVisualStyleBackColor = true;
            // 
            // rbOpcC
            // 
            this.rbOpcC.AutoSize = true;
            this.rbOpcC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcC.Location = new System.Drawing.Point(183, 235);
            this.rbOpcC.Name = "rbOpcC";
            this.rbOpcC.Size = new System.Drawing.Size(38, 24);
            this.rbOpcC.TabIndex = 22;
            this.rbOpcC.TabStop = true;
            this.rbOpcC.Text = "C";
            this.rbOpcC.UseVisualStyleBackColor = true;
            // 
            // rtbDescri
            // 
            this.rtbDescri.Enabled = false;
            this.rtbDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescri.Location = new System.Drawing.Point(183, 57);
            this.rtbDescri.Name = "rtbDescri";
            this.rtbDescri.Size = new System.Drawing.Size(543, 78);
            this.rtbDescri.TabIndex = 21;
            this.rtbDescri.Text = "";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(180, 34);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(87, 20);
            this.lblResp.TabIndex = 20;
            this.lblResp.Text = "Responda:";
            // 
            // rbOpcB
            // 
            this.rbOpcB.AutoSize = true;
            this.rbOpcB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcB.Location = new System.Drawing.Point(183, 200);
            this.rbOpcB.Name = "rbOpcB";
            this.rbOpcB.Size = new System.Drawing.Size(38, 24);
            this.rbOpcB.TabIndex = 14;
            this.rbOpcB.TabStop = true;
            this.rbOpcB.Text = "B";
            this.rbOpcB.UseVisualStyleBackColor = true;
            // 
            // rbOpcA
            // 
            this.rbOpcA.AutoSize = true;
            this.rbOpcA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpcA.Location = new System.Drawing.Point(183, 165);
            this.rbOpcA.Name = "rbOpcA";
            this.rbOpcA.Size = new System.Drawing.Size(38, 24);
            this.rbOpcA.TabIndex = 13;
            this.rbOpcA.TabStop = true;
            this.rbOpcA.Text = "A";
            this.rbOpcA.UseVisualStyleBackColor = true;
            // 
            // lblOpc
            // 
            this.lblOpc.AutoSize = true;
            this.lblOpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpc.Location = new System.Drawing.Point(179, 137);
            this.lblOpc.Name = "lblOpc";
            this.lblOpc.Size = new System.Drawing.Size(68, 20);
            this.lblOpc.TabIndex = 12;
            this.lblOpc.Text = "Opções:";
            // 
            // FrmNovoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(882, 456);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNovoJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eureka Quiz - Novo Jogo";
            this.Load += new System.EventHandler(this.FrmNovoJogo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesistir;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOpcE;
        private System.Windows.Forms.RadioButton rbOpcE;
        private System.Windows.Forms.TextBox txtOpcD;
        private System.Windows.Forms.TextBox txtOpcC;
        private System.Windows.Forms.TextBox txtOpcB;
        private System.Windows.Forms.TextBox txtOpcA;
        private System.Windows.Forms.RadioButton rbOpcD;
        private System.Windows.Forms.RadioButton rbOpcC;
        private System.Windows.Forms.RichTextBox rtbDescri;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.RadioButton rbOpcB;
        private System.Windows.Forms.RadioButton rbOpcA;
        private System.Windows.Forms.Label lblOpc;

    }
}