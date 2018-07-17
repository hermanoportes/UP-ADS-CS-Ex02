namespace AppGestaoEscolar.View
{
    partial class FrmCadastrarAluno
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
            this.groupSetAluno = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.rdBtnMasc = new System.Windows.Forms.RadioButton();
            this.rdBtnFem = new System.Windows.Forms.RadioButton();
            this.maskTxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelCadastrarAluno = new System.Windows.Forms.Label();
            this.groupSetAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.txtNome);
            this.groupSetAluno.Controls.Add(this.labelMatricula);
            this.groupSetAluno.Controls.Add(this.labelNome);
            this.groupSetAluno.Controls.Add(this.labelDataNasc);
            this.groupSetAluno.Controls.Add(this.labelSexo);
            this.groupSetAluno.Controls.Add(this.txtMatricula);
            this.groupSetAluno.Controls.Add(this.rdBtnMasc);
            this.groupSetAluno.Controls.Add(this.rdBtnFem);
            this.groupSetAluno.Controls.Add(this.maskTxtDataNasc);
            this.groupSetAluno.Location = new System.Drawing.Point(19, 54);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 133);
            this.groupSetAluno.TabIndex = 28;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Dados Pessoais";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 29;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(87, 23);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(87, 49);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Location = new System.Drawing.Point(87, 75);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(107, 13);
            this.labelDataNasc.TabIndex = 3;
            this.labelDataNasc.Text = "Data de Nascimento:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(87, 100);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 4;
            this.labelSexo.Text = "Sexo:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(200, 20);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(273, 98);
            this.rdBtnMasc.Name = "rdBtnMasc";
            this.rdBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasc.TabIndex = 17;
            this.rdBtnMasc.TabStop = true;
            this.rdBtnMasc.Text = "Masculino";
            this.rdBtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdBtnFem
            // 
            this.rdBtnFem.AutoSize = true;
            this.rdBtnFem.Location = new System.Drawing.Point(200, 98);
            this.rdBtnFem.Name = "rdBtnFem";
            this.rdBtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFem.TabIndex = 16;
            this.rdBtnFem.TabStop = true;
            this.rdBtnFem.Text = "Feminino";
            this.rdBtnFem.UseVisualStyleBackColor = true;
            // 
            // maskTxtDataNasc
            // 
            this.maskTxtDataNasc.Location = new System.Drawing.Point(200, 72);
            this.maskTxtDataNasc.Mask = "00/00/0000";
            this.maskTxtDataNasc.Name = "maskTxtDataNasc";
            this.maskTxtDataNasc.Size = new System.Drawing.Size(67, 20);
            this.maskTxtDataNasc.TabIndex = 14;
            this.maskTxtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(611, 193);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 28;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // labelCadastrarAluno
            // 
            this.labelCadastrarAluno.AutoSize = true;
            this.labelCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarAluno.Location = new System.Drawing.Point(12, 35);
            this.labelCadastrarAluno.Name = "labelCadastrarAluno";
            this.labelCadastrarAluno.Size = new System.Drawing.Size(119, 16);
            this.labelCadastrarAluno.TabIndex = 29;
            this.labelCadastrarAluno.Text = "Cadastrar Aluno";
            this.labelCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.labelCadastrarAluno);
            this.Controls.Add(this.groupSetAluno);
            this.Controls.Add(this.btnEnviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.RadioButton rdBtnFem;
        private System.Windows.Forms.MaskedTextBox maskTxtDataNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelCadastrarAluno;
    }
}