namespace AppGestaoEscolar.View
{
    partial class FrmAlunos
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
            this.labelAlunos = new System.Windows.Forms.Label();
            this.groupSetAluno = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.rdBtnMasc = new System.Windows.Forms.RadioButton();
            this.rdBtnFem = new System.Windows.Forms.RadioButton();
            this.maskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.dGVAlunos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosDataSet = new AppGestaoEscolar.AlunosDataSet();
            this.alunosTableAdapter = new AppGestaoEscolar.AlunosDataSetTableAdapters.AlunosTableAdapter();
            this.groupSetAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlunos
            // 
            this.labelAlunos.AutoSize = true;
            this.labelAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlunos.Location = new System.Drawing.Point(54, 12);
            this.labelAlunos.Name = "labelAlunos";
            this.labelAlunos.Size = new System.Drawing.Size(55, 16);
            this.labelAlunos.TabIndex = 32;
            this.labelAlunos.Text = "Alunos";
            this.labelAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.txtId);
            this.groupSetAluno.Controls.Add(this.txtNome);
            this.groupSetAluno.Controls.Add(this.labelMatricula);
            this.groupSetAluno.Controls.Add(this.btnEnviar);
            this.groupSetAluno.Controls.Add(this.labelNome);
            this.groupSetAluno.Controls.Add(this.labelDataNasc);
            this.groupSetAluno.Controls.Add(this.labelSexo);
            this.groupSetAluno.Controls.Add(this.txtMatricula);
            this.groupSetAluno.Controls.Add(this.rdBtnMasc);
            this.groupSetAluno.Controls.Add(this.rdBtnFem);
            this.groupSetAluno.Controls.Add(this.maskDataNasc);
            this.groupSetAluno.Location = new System.Drawing.Point(57, 31);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 133);
            this.groupSetAluno.TabIndex = 30;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Cadastrar/Alterar";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(571, 20);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 32;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 2;
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
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(586, 99);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
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
            this.txtMatricula.TabIndex = 1;
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(273, 98);
            this.rdBtnMasc.Name = "rdBtnMasc";
            this.rdBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasc.TabIndex = 5;
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
            this.rdBtnFem.TabIndex = 4;
            this.rdBtnFem.TabStop = true;
            this.rdBtnFem.Text = "Feminino";
            this.rdBtnFem.UseVisualStyleBackColor = true;
            // 
            // maskDataNasc
            // 
            this.maskDataNasc.Location = new System.Drawing.Point(200, 72);
            this.maskDataNasc.Mask = "00/00/0000";
            this.maskDataNasc.Name = "maskDataNasc";
            this.maskDataNasc.Size = new System.Drawing.Size(67, 20);
            this.maskDataNasc.TabIndex = 3;
            this.maskDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // dGVAlunos
            // 
            this.dGVAlunos.AllowUserToAddRows = false;
            this.dGVAlunos.AllowUserToDeleteRows = false;
            this.dGVAlunos.AllowUserToResizeRows = false;
            this.dGVAlunos.AutoGenerateColumns = false;
            this.dGVAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVAlunos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGVAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGVAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.Alterar,
            this.Excluir});
            this.dGVAlunos.DataSource = this.alunosBindingSource;
            this.dGVAlunos.EnableHeadersVisualStyles = false;
            this.dGVAlunos.Location = new System.Drawing.Point(57, 170);
            this.dGVAlunos.MultiSelect = false;
            this.dGVAlunos.Name = "dGVAlunos";
            this.dGVAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVAlunos.Size = new System.Drawing.Size(677, 380);
            this.dGVAlunos.TabIndex = 7;
            this.dGVAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAlunos_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.FillWeight = 90.67753F;
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 90.67753F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.FillWeight = 90.67753F;
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.FillWeight = 90.67753F;
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // Alterar
            // 
            this.Alterar.FillWeight = 46.3F;
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            this.Alterar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Alterar.Text = "Alterar";
            this.Alterar.ToolTipText = "Alterar";
            this.Alterar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            this.Excluir.FillWeight = 46.3F;
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.alunosDataSet;
            // 
            // alunosDataSet
            // 
            this.alunosDataSet.DataSetName = "AlunosDataSet";
            this.alunosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dGVAlunos);
            this.Controls.Add(this.labelAlunos);
            this.Controls.Add(this.groupSetAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Alunos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlunos;
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.RadioButton rdBtnFem;
        private System.Windows.Forms.MaskedTextBox maskDataNasc;
        private System.Windows.Forms.DataGridView dGVAlunos;
        private AlunosDataSet alunosDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private AlunosDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.TextBox txtId;
    }
}