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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosDataSet = new AppGestaoEscolar.AlunosDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dGVAlunosMatriculados = new System.Windows.Forms.DataGridView();
            this.alunosTableAdapter = new AppGestaoEscolar.AlunosDataSetTableAdapters.AlunosTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunosMatriculados)).BeginInit();
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(217, 73);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "<< Excluir";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(409, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 41);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAlunosDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dGVAlunosMatriculados);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dGVListaAlunos);
            this.Name = "FrmAlunosDisciplina";
            this.Text = "Disciplinas - Adicionar Excluir Alunos";
            this.Load += new System.EventHandler(this.FrmAlunosDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAlunosMatriculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListaAlunos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dGVAlunosMatriculados;
        private AlunosDataSet alunosDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private AlunosDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnOk;
    }
}