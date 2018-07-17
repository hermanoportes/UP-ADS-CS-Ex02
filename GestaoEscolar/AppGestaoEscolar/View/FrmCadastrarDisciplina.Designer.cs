namespace AppGestaoEscolar.View
{
    partial class FrmCadastrarDisciplina
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
            this.components = new System.ComponentModel.Container();
            this.labelCadastrarDisciplina = new System.Windows.Forms.Label();
            this.groupSetAluno = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.comboProfessorId = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoEscolarDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);            
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtCH = new System.Windows.Forms.TextBox();
            this.labelNomeDisc = new System.Windows.Forms.Label();
            this.labelCHoraria = new System.Windows.Forms.Label();
            this.txtNomeDisc = new System.Windows.Forms.TextBox();
            this.fKProfessorinheritsUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKProfessorDisciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupSetAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProfessorinheritsUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProfessorDisciplinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastrarDisciplina
            // 
            this.labelCadastrarDisciplina.AutoSize = true;
            this.labelCadastrarDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarDisciplina.Location = new System.Drawing.Point(12, 35);
            this.labelCadastrarDisciplina.Name = "labelCadastrarDisciplina";
            this.labelCadastrarDisciplina.Size = new System.Drawing.Size(149, 16);
            this.labelCadastrarDisciplina.TabIndex = 0;
            this.labelCadastrarDisciplina.Text = "Cadastrar Disciplina";
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.btnCadastrar);
            this.groupSetAluno.Controls.Add(this.comboProfessorId);
            this.groupSetAluno.Controls.Add(this.labelEmail);
            this.groupSetAluno.Controls.Add(this.txtCH);
            this.groupSetAluno.Controls.Add(this.labelNomeDisc);
            this.groupSetAluno.Controls.Add(this.labelCHoraria);
            this.groupSetAluno.Controls.Add(this.txtNomeDisc);
            this.groupSetAluno.Location = new System.Drawing.Point(19, 54);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 107);
            this.groupSetAluno.TabIndex = 29;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Dados Pessoais";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(586, 75);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 28);
            this.btnCadastrar.TabIndex = 32;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // comboProfessorId
            // 
            this.comboProfessorId.DataSource = this.fKProfessorDisciplinaBindingSource;
            this.comboProfessorId.FormattingEnabled = true;
            this.comboProfessorId.Location = new System.Drawing.Point(200, 72);
            this.comboProfessorId.Name = "comboProfessorId";
            this.comboProfessorId.Size = new System.Drawing.Size(272, 21);
            this.comboProfessorId.TabIndex = 31;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.gestaoEscolarDBDataSetBindingSource;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(87, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Docente:";
            // 
            // txtCH
            // 
            this.txtCH.Location = new System.Drawing.Point(200, 46);
            this.txtCH.Name = "txtCH";
            this.txtCH.Size = new System.Drawing.Size(58, 20);
            this.txtCH.TabIndex = 29;
            // 
            // labelNomeDisc
            // 
            this.labelNomeDisc.AutoSize = true;
            this.labelNomeDisc.Location = new System.Drawing.Point(87, 23);
            this.labelNomeDisc.Name = "labelNomeDisc";
            this.labelNomeDisc.Size = new System.Drawing.Size(55, 13);
            this.labelNomeDisc.TabIndex = 2;
            this.labelNomeDisc.Text = "Disciplina:";
            // 
            // labelCHoraria
            // 
            this.labelCHoraria.AutoSize = true;
            this.labelCHoraria.Location = new System.Drawing.Point(87, 49);
            this.labelCHoraria.Name = "labelCHoraria";
            this.labelCHoraria.Size = new System.Drawing.Size(75, 13);
            this.labelCHoraria.TabIndex = 1;
            this.labelCHoraria.Text = "Carga Horária:";
            // 
            // txtNomeDisc
            // 
            this.txtNomeDisc.Location = new System.Drawing.Point(200, 20);
            this.txtNomeDisc.Name = "txtNomeDisc";
            this.txtNomeDisc.Size = new System.Drawing.Size(272, 20);
            this.txtNomeDisc.TabIndex = 8;
            // 
            // fKProfessorinheritsUsuarioBindingSource
            // 
            this.fKProfessorinheritsUsuarioBindingSource.DataMember = "FK_Professor_inherits_Usuario";
            this.fKProfessorinheritsUsuarioBindingSource.DataSource = this.usuariosBindingSource;
            // 
            // fKProfessorDisciplinaBindingSource
            // 
            this.fKProfessorDisciplinaBindingSource.DataMember = "FK_ProfessorDisciplina";
            this.fKProfessorDisciplinaBindingSource.DataSource = this.fKProfessorinheritsUsuarioBindingSource;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.gestaoEscolarDBDataSetBindingSource;
            // 
            // FrmCadastrarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.groupSetAluno);
            this.Controls.Add(this.labelCadastrarDisciplina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarDisciplina";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCadastrarDisciplina";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;            
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();            
            ((System.ComponentModel.ISupportInitialize)(this.fKProfessorinheritsUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProfessorDisciplinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastrarDisciplina;
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtCH;
        private System.Windows.Forms.Label labelNomeDisc;
        private System.Windows.Forms.Label labelCHoraria;
        private System.Windows.Forms.TextBox txtNomeDisc;
        private System.Windows.Forms.ComboBox comboProfessorId;
        private System.Windows.Forms.BindingSource gestaoEscolarDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource fKProfessorinheritsUsuarioBindingSource;
        private System.Windows.Forms.BindingSource fKProfessorDisciplinaBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.Button btnCadastrar;
    }
}