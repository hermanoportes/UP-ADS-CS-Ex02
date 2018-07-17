namespace AppGestaoEscolar.View
{
    partial class FrmAlterarAluno
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
            this.labelCadastrarAluno = new System.Windows.Forms.Label();
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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gestaoEscolarDBDataSet = new AppGestaoEscolar.GestaoEscolarDBDataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new AppGestaoEscolar.GestaoEscolarDBDataSetTableAdapters.AlunosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.alunosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoEscolarDBDataSet1 = new AppGestaoEscolar.GestaoEscolarDBDataSet1();
            this.alunosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter1 = new AppGestaoEscolar.GestaoEscolarDBDataSet1TableAdapters.AlunosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSetAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCadastrarAluno
            // 
            this.labelCadastrarAluno.AutoSize = true;
            this.labelCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarAluno.Location = new System.Drawing.Point(19, 54);
            this.labelCadastrarAluno.Name = "labelCadastrarAluno";
            this.labelCadastrarAluno.Size = new System.Drawing.Size(119, 16);
            this.labelCadastrarAluno.TabIndex = 32;
            this.labelCadastrarAluno.Text = "Cadastrar Aluno";
            this.labelCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.txtNome);
            this.groupSetAluno.Controls.Add(this.labelMatricula);
            this.groupSetAluno.Controls.Add(this.labelNome);
            this.groupSetAluno.Controls.Add(this.btnAlterar);
            this.groupSetAluno.Controls.Add(this.labelDataNasc);
            this.groupSetAluno.Controls.Add(this.labelSexo);
            this.groupSetAluno.Controls.Add(this.txtMatricula);
            this.groupSetAluno.Controls.Add(this.rdBtnMasc);
            this.groupSetAluno.Controls.Add(this.rdBtnFem);
            this.groupSetAluno.Controls.Add(this.maskTxtDataNasc);
            this.groupSetAluno.Location = new System.Drawing.Point(22, 267);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 133);
            this.groupSetAluno.TabIndex = 30;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Alterar Dados";
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
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(586, 100);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 28);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gestaoEscolarDBDataSet
            // 
            this.gestaoEscolarDBDataSet.DataSetName = "GestaoEscolarDBDataSet";
            this.gestaoEscolarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.gestaoEscolarDBDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(22, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 188);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // alunosBindingSource1
            // 
            this.alunosBindingSource1.DataMember = "Alunos";
            this.alunosBindingSource1.DataSource = this.gestaoEscolarDBDataSet;
            // 
            // gestaoEscolarDBDataSet1
            // 
            this.gestaoEscolarDBDataSet1.DataSetName = "GestaoEscolarDBDataSet1";
            this.gestaoEscolarDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource2
            // 
            this.alunosBindingSource2.DataMember = "Alunos";
            this.alunosBindingSource2.DataSource = this.gestaoEscolarDBDataSet1;
            // 
            // alunosTableAdapter1
            // 
            this.alunosTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // FrmAlterarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCadastrarAluno);
            this.Controls.Add(this.groupSetAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlterarAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Alterar Dados do Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlterarAluno_Load);
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoEscolarDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadastrarAluno;
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.RadioButton rdBtnFem;
        private System.Windows.Forms.MaskedTextBox maskTxtDataNasc;
        private System.Windows.Forms.Button btnAlterar;
        private GestaoEscolarDBDataSet gestaoEscolarDBDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private GestaoEscolarDBDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource alunosBindingSource1;
        private GestaoEscolarDBDataSet1 gestaoEscolarDBDataSet1;
        private System.Windows.Forms.BindingSource alunosBindingSource2;
        private GestaoEscolarDBDataSet1TableAdapters.AlunosTableAdapter alunosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    }
}