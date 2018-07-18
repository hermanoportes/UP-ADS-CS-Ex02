namespace AppGestaoEscolar.View
{
    partial class FrmAlunosDisciplina
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
            this.dGVListaAlunos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dGVAlunosMatriculados = new System.Windows.Forms.DataGridView();
            this.alunosDataSet = new AppGestaoEscolar.AlunosDataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new AppGestaoEscolar.AlunosDataSetTableAdapters.AlunosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunosMatriculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVListaAlunos
            // 
            this.dGVListaAlunos.AllowUserToAddRows = false;
            this.dGVListaAlunos.AllowUserToDeleteRows = false;
            this.dGVListaAlunos.AllowUserToResizeRows = false;
            this.dGVListaAlunos.AutoGenerateColumns = false;
            this.dGVListaAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListaAlunos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGVListaAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGVListaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListaAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn});
            this.dGVListaAlunos.DataSource = this.alunosBindingSource;
            this.dGVListaAlunos.EnableHeadersVisualStyles = false;
            this.dGVListaAlunos.Location = new System.Drawing.Point(12, 12);
            this.dGVListaAlunos.MultiSelect = false;
            this.dGVListaAlunos.Name = "dGVListaAlunos";
            this.dGVListaAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVListaAlunos.Size = new System.Drawing.Size(200, 205);
            this.dGVListaAlunos.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dGVAlunosMatriculados
            // 
            this.dGVAlunosMatriculados.AllowUserToAddRows = false;
            this.dGVAlunosMatriculados.AllowUserToDeleteRows = false;
            this.dGVAlunosMatriculados.AllowUserToResizeRows = false;
            this.dGVAlunosMatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVAlunosMatriculados.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGVAlunosMatriculados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGVAlunosMatriculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAlunosMatriculados.EnableHeadersVisualStyles = false;
            this.dGVAlunosMatriculados.Location = new System.Drawing.Point(298, 12);
            this.dGVAlunosMatriculados.MultiSelect = false;
            this.dGVAlunosMatriculados.Name = "dGVAlunosMatriculados";
            this.dGVAlunosMatriculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAlunosMatriculados.Size = new System.Drawing.Size(200, 205);
            this.dGVAlunosMatriculados.TabIndex = 9;
            // 
            // alunosDataSet
            // 
            this.alunosDataSet.DataSetName = "AlunosDataSet";
            this.alunosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.alunosDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
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
            this.matriculaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            this.matriculaDataGridViewTextBoxColumn.Width = 55;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 149.2386F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNascDataGridViewTextBoxColumn
            // 
            this.dataNascDataGridViewTextBoxColumn.DataPropertyName = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.HeaderText = "DataNasc";
            this.dataNascDataGridViewTextBoxColumn.Name = "dataNascDataGridViewTextBoxColumn";
            this.dataNascDataGridViewTextBoxColumn.Visible = false;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmAlunosDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.dGVAlunosMatriculados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGVListaAlunos);
            this.Name = "FrmAlunosDisciplina";
            this.Text = "Disciplinas - Adicionar Excluir Alunos";
            this.Load += new System.EventHandler(this.FrmAlunosDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunosMatriculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListaAlunos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dGVAlunosMatriculados;
        private AlunosDataSet alunosDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private AlunosDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
    }
}