namespace AppGestaoEscolar.View
{
    partial class FrmDisciplinas
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
            this.labelDisciplinas = new System.Windows.Forms.Label();
            this.groupSetAluno = new System.Windows.Forms.GroupBox();
            this.comboDocente = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.professoresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresDataSet = new AppGestaoEscolar.ProfessoresDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelCH = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelProfessorId = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.professoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dGVDisciplinas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.disciplinasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinasDataSet = new AppGestaoEscolar.DisciplinasDataSet();
            this.disciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresTableAdapter = new AppGestaoEscolar.ProfessoresDataSetTableAdapters.ProfessoresTableAdapter();
            this.disciplinasTableAdapter = new AppGestaoEscolar.DisciplinasDataSetTableAdapters.DisciplinasTableAdapter();
            this.professoresBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupSetAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDisciplinas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDisciplinas
            // 
            this.labelDisciplinas.AutoSize = true;
            this.labelDisciplinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisciplinas.Location = new System.Drawing.Point(54, 12);
            this.labelDisciplinas.Name = "labelDisciplinas";
            this.labelDisciplinas.Size = new System.Drawing.Size(85, 16);
            this.labelDisciplinas.TabIndex = 34;
            this.labelDisciplinas.Text = "Disciplinas";
            this.labelDisciplinas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.comboDocente);
            this.groupSetAluno.Controls.Add(this.textBox1);
            this.groupSetAluno.Controls.Add(this.txtId);
            this.groupSetAluno.Controls.Add(this.labelCH);
            this.groupSetAluno.Controls.Add(this.btnEnviar);
            this.groupSetAluno.Controls.Add(this.labelNome);
            this.groupSetAluno.Controls.Add(this.labelProfessorId);
            this.groupSetAluno.Controls.Add(this.txtMatricula);
            this.groupSetAluno.Location = new System.Drawing.Point(57, 31);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 133);
            this.groupSetAluno.TabIndex = 33;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Cadastrar/Alterar";
            // 
            // comboDocente
            // 
            this.comboDocente.DataSource = this.professoresBindingSource2;
            this.comboDocente.DisplayMember = "Nome";
            this.comboDocente.FormattingEnabled = true;
            this.comboDocente.Location = new System.Drawing.Point(200, 72);
            this.comboDocente.Name = "comboDocente";
            this.comboDocente.Size = new System.Drawing.Size(298, 21);
            this.comboDocente.TabIndex = 3;
            this.comboDocente.TabStop = false;
            // 
            // professoresBindingSource2
            // 
            this.professoresBindingSource2.DataMember = "Professores";
            this.professoresBindingSource2.DataSource = this.professoresDataSetBindingSource;
            // 
            // professoresDataSetBindingSource
            // 
            this.professoresDataSetBindingSource.DataSource = this.professoresDataSet;
            this.professoresDataSetBindingSource.Position = 0;
            // 
            // professoresDataSet
            // 
            this.professoresDataSet.DataSetName = "ProfessoresDataSet";
            this.professoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 2;
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
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.Location = new System.Drawing.Point(87, 49);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(75, 13);
            this.labelCH.TabIndex = 2;
            this.labelCH.Text = "Carga Horária:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(586, 99);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
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
            // labelProfessorId
            // 
            this.labelProfessorId.AutoSize = true;
            this.labelProfessorId.Location = new System.Drawing.Point(87, 75);
            this.labelProfessorId.Name = "labelProfessorId";
            this.labelProfessorId.Size = new System.Drawing.Size(51, 13);
            this.labelProfessorId.TabIndex = 3;
            this.labelProfessorId.Text = "Docente:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(200, 20);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(298, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // professoresBindingSource1
            // 
            this.professoresBindingSource1.DataMember = "Professores";
            this.professoresBindingSource1.DataSource = this.professoresDataSet;
            // 
            // dGVDisciplinas
            // 
            this.dGVDisciplinas.AllowUserToAddRows = false;
            this.dGVDisciplinas.AllowUserToDeleteRows = false;
            this.dGVDisciplinas.AllowUserToResizeRows = false;
            this.dGVDisciplinas.AutoGenerateColumns = false;
            this.dGVDisciplinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDisciplinas.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGVDisciplinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGVDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Alterar,
            this.Excluir});
            this.dGVDisciplinas.DataSource = this.disciplinasBindingSource1;
            this.dGVDisciplinas.EnableHeadersVisualStyles = false;
            this.dGVDisciplinas.Location = new System.Drawing.Point(57, 170);
            this.dGVDisciplinas.MultiSelect = false;
            this.dGVDisciplinas.Name = "dGVDisciplinas";
            this.dGVDisciplinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVDisciplinas.Size = new System.Drawing.Size(677, 380);
            this.dGVDisciplinas.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CargaHoraria";
            this.dataGridViewTextBoxColumn3.HeaderText = "CargaHoraria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProfessorId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProfessorId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
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
            // disciplinasBindingSource1
            // 
            this.disciplinasBindingSource1.DataMember = "Disciplinas";
            this.disciplinasBindingSource1.DataSource = this.disciplinasDataSet;
            // 
            // disciplinasDataSet
            // 
            this.disciplinasDataSet.DataSetName = "DisciplinasDataSet";
            this.disciplinasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.professoresDataSetBindingSource;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // disciplinasTableAdapter
            // 
            this.disciplinasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dGVDisciplinas);
            this.Controls.Add(this.labelDisciplinas);
            this.Controls.Add(this.groupSetAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisciplinas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Disciplinas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDisciplinas_Load);
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDisciplinas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisciplinas;
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelCH;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelProfessorId;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGVDisciplinas;
        private System.Windows.Forms.BindingSource disciplinasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargaHorariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboDocente;
        private System.Windows.Forms.BindingSource professoresDataSetBindingSource;
        private ProfessoresDataSet professoresDataSet;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private ProfessoresDataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource professoresBindingSource1;
        private System.Windows.Forms.BindingSource professoresBindingSource2;
        private DisciplinasDataSet disciplinasDataSet;
        private System.Windows.Forms.BindingSource disciplinasBindingSource1;
        private DisciplinasDataSetTableAdapters.DisciplinasTableAdapter disciplinasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.BindingSource professoresBindingSource3;
    }
}