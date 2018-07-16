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
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNomeDisc = new System.Windows.Forms.Label();
            this.labelCHoraria = new System.Windows.Forms.Label();
            this.txtNomeDisc = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gestaoEscolarDBDataSet = new AppGestaoEscolar.GestaoEscolarDBDataSet();
            this.gestaoEscolarDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new AppGestaoEscolar.GestaoEscolarDBDataSetTableAdapters.UsuariosTableAdapter();
            this.fKProfessorinheritsUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarios_ProfessorTableAdapter = new AppGestaoEscolar.GestaoEscolarDBDataSetTableAdapters.Usuarios_ProfessorTableAdapter();
            this.fKProfessorDisciplinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinasTableAdapter = new AppGestaoEscolar.GestaoEscolarDBDataSetTableAdapters.DisciplinasTableAdapter();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupSetAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
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
            this.groupSetAluno.Controls.Add(this.comboBox1);
            this.groupSetAluno.Controls.Add(this.labelEmail);
            this.groupSetAluno.Controls.Add(this.txtNome);
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
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(87, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "Docente:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(58, 20);
            this.txtNome.TabIndex = 29;
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
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usuariosBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // gestaoEscolarDBDataSet
            // 
            this.gestaoEscolarDBDataSet.DataSetName = "GestaoEscolarDBDataSet";
            this.gestaoEscolarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestaoEscolarDBDataSetBindingSource
            // 
            this.gestaoEscolarDBDataSetBindingSource.DataSource = this.gestaoEscolarDBDataSet;
            this.gestaoEscolarDBDataSetBindingSource.Position = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.gestaoEscolarDBDataSetBindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // fKProfessorinheritsUsuarioBindingSource
            // 
            this.fKProfessorinheritsUsuarioBindingSource.DataMember = "FK_Professor_inherits_Usuario";
            this.fKProfessorinheritsUsuarioBindingSource.DataSource = this.usuariosBindingSource;
            // 
            // usuarios_ProfessorTableAdapter
            // 
            this.usuarios_ProfessorTableAdapter.ClearBeforeFill = true;
            // 
            // fKProfessorDisciplinaBindingSource
            // 
            this.fKProfessorDisciplinaBindingSource.DataMember = "FK_ProfessorDisciplina";
            this.fKProfessorDisciplinaBindingSource.DataSource = this.fKProfessorinheritsUsuarioBindingSource;
            // 
            // disciplinasTableAdapter
            // 
            this.disciplinasTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.gestaoEscolarDBDataSetBindingSource;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(611, 167);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 32;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrarDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnviar);
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
            this.Load += new System.EventHandler(this.FrmCadastrarDisciplina_Load);
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNomeDisc;
        private System.Windows.Forms.Label labelCHoraria;
        private System.Windows.Forms.TextBox txtNomeDisc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gestaoEscolarDBDataSetBindingSource;
        private GestaoEscolarDBDataSet gestaoEscolarDBDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private GestaoEscolarDBDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource fKProfessorinheritsUsuarioBindingSource;
        private GestaoEscolarDBDataSetTableAdapters.Usuarios_ProfessorTableAdapter usuarios_ProfessorTableAdapter;
        private System.Windows.Forms.BindingSource fKProfessorDisciplinaBindingSource;
        private GestaoEscolarDBDataSetTableAdapters.DisciplinasTableAdapter disciplinasTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.Button btnEnviar;
    }
}