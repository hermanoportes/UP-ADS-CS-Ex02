namespace AppGestaoEscolar.View
{
    partial class FrmCadastrarProfessor
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
            this.labelCadastrarAluno = new System.Windows.Forms.Label();
            this.groupSetAluno = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelFormacao = new System.Windows.Forms.Label();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupAcademico = new System.Windows.Forms.GroupBox();
            this.groupFuncional = new System.Windows.Forms.GroupBox();
            this.labelDataInic = new System.Windows.Forms.Label();
            this.maskDataInic = new System.Windows.Forms.MaskedTextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupSetAluno.SuspendLayout();
            this.groupAcademico.SuspendLayout();
            this.groupFuncional.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCadastrarAluno
            // 
            this.labelCadastrarAluno.AutoSize = true;
            this.labelCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarAluno.Location = new System.Drawing.Point(12, 35);
            this.labelCadastrarAluno.Name = "labelCadastrarAluno";
            this.labelCadastrarAluno.Size = new System.Drawing.Size(147, 16);
            this.labelCadastrarAluno.TabIndex = 32;
            this.labelCadastrarAluno.Text = "Cadastrar Professor";
            this.labelCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.txtNome);
            this.groupSetAluno.Controls.Add(this.labelNome);
            this.groupSetAluno.Location = new System.Drawing.Point(19, 54);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 53);
            this.groupSetAluno.TabIndex = 30;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Dados Pessoais";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 29;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(87, 23);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // labelFormacao
            // 
            this.labelFormacao.AutoSize = true;
            this.labelFormacao.Location = new System.Drawing.Point(87, 16);
            this.labelFormacao.Name = "labelFormacao";
            this.labelFormacao.Size = new System.Drawing.Size(57, 13);
            this.labelFormacao.TabIndex = 2;
            this.labelFormacao.Text = "Formação:";
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(200, 13);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(298, 20);
            this.txtFormacao.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(611, 210);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 31;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupAcademico
            // 
            this.groupAcademico.Controls.Add(this.labelFormacao);
            this.groupAcademico.Controls.Add(this.txtFormacao);
            this.groupAcademico.Location = new System.Drawing.Point(19, 113);
            this.groupAcademico.Name = "groupAcademico";
            this.groupAcademico.Size = new System.Drawing.Size(677, 45);
            this.groupAcademico.TabIndex = 33;
            this.groupAcademico.TabStop = false;
            this.groupAcademico.Text = "Acadêmico";
            // 
            // groupFuncional
            // 
            this.groupFuncional.Controls.Add(this.labelDataInic);
            this.groupFuncional.Controls.Add(this.maskDataInic);
            this.groupFuncional.Controls.Add(this.labelSalario);
            this.groupFuncional.Controls.Add(this.txtSalario);
            this.groupFuncional.Location = new System.Drawing.Point(19, 164);
            this.groupFuncional.Name = "groupFuncional";
            this.groupFuncional.Size = new System.Drawing.Size(677, 40);
            this.groupFuncional.TabIndex = 34;
            this.groupFuncional.TabStop = false;
            this.groupFuncional.Text = "Dados Funcionais";
            // 
            // labelDataInic
            // 
            this.labelDataInic.AutoSize = true;
            this.labelDataInic.Location = new System.Drawing.Point(349, 17);
            this.labelDataInic.Name = "labelDataInic";
            this.labelDataInic.Size = new System.Drawing.Size(78, 13);
            this.labelDataInic.TabIndex = 31;
            this.labelDataInic.Text = "Data de Início:";
            // 
            // maskDataInic
            // 
            this.maskDataInic.Location = new System.Drawing.Point(431, 14);
            this.maskDataInic.Mask = "00/00/0000";
            this.maskDataInic.Name = "maskDataInic";
            this.maskDataInic.Size = new System.Drawing.Size(67, 20);
            this.maskDataInic.TabIndex = 32;
            this.maskDataInic.ValidatingType = typeof(System.DateTime);
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(87, 17);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(70, 13);
            this.labelSalario.TabIndex = 9;
            this.labelSalario.Text = "Salário Bruto:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(200, 14);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(84, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // FrmCadastrarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.groupFuncional);
            this.Controls.Add(this.groupAcademico);
            this.Controls.Add(this.labelCadastrarAluno);
            this.Controls.Add(this.groupSetAluno);
            this.Controls.Add(this.btnEnviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarProfessor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Professor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            this.groupAcademico.ResumeLayout(false);
            this.groupAcademico.PerformLayout();
            this.groupFuncional.ResumeLayout(false);
            this.groupFuncional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastrarAluno;
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelFormacao;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupAcademico;
        private System.Windows.Forms.GroupBox groupFuncional;
        private System.Windows.Forms.Label labelDataInic;
        private System.Windows.Forms.MaskedTextBox maskDataInic;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox txtSalario;
    }
}