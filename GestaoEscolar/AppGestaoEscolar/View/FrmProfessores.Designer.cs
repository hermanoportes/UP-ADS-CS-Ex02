namespace AppGestaoEscolar.View
{
    partial class FrmProfessores
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
            this.labelDataInic = new System.Windows.Forms.Label();
            this.maskDataInic = new System.Windows.Forms.MaskedTextBox();
            this.labelSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.labelFormacao = new System.Windows.Forms.Label();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.labelCadastrarAluno = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupSetProfessor = new System.Windows.Forms.GroupBox();
            this.dGVProfessores = new System.Windows.Forms.DataGridView();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresDataSet = new AppGestaoEscolar.ProfessoresDataSet();
            this.professoresTableAdapter = new AppGestaoEscolar.ProfessoresDataSetTableAdapters.ProfessoresTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.professoresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupSetProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDataInic
            // 
            this.labelDataInic.AutoSize = true;
            this.labelDataInic.Location = new System.Drawing.Point(349, 74);
            this.labelDataInic.Name = "labelDataInic";
            this.labelDataInic.Size = new System.Drawing.Size(78, 13);
            this.labelDataInic.TabIndex = 31;
            this.labelDataInic.Text = "Data de Início:";
            // 
            // maskDataInic
            // 
            this.maskDataInic.Location = new System.Drawing.Point(431, 71);
            this.maskDataInic.Mask = "00/00/0000";
            this.maskDataInic.Name = "maskDataInic";
            this.maskDataInic.Size = new System.Drawing.Size(67, 20);
            this.maskDataInic.TabIndex = 4;
            this.maskDataInic.ValidatingType = typeof(System.DateTime);
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(87, 74);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(70, 13);
            this.labelSalario.TabIndex = 9;
            this.labelSalario.Text = "Salário Bruto:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(200, 71);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(84, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // labelFormacao
            // 
            this.labelFormacao.AutoSize = true;
            this.labelFormacao.Location = new System.Drawing.Point(87, 48);
            this.labelFormacao.Name = "labelFormacao";
            this.labelFormacao.Size = new System.Drawing.Size(57, 13);
            this.labelFormacao.TabIndex = 2;
            this.labelFormacao.Text = "Formação:";
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(200, 45);
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(298, 20);
            this.txtFormacao.TabIndex = 2;
            // 
            // labelCadastrarAluno
            // 
            this.labelCadastrarAluno.AutoSize = true;
            this.labelCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarAluno.Location = new System.Drawing.Point(54, 12);
            this.labelCadastrarAluno.Name = "labelCadastrarAluno";
            this.labelCadastrarAluno.Size = new System.Drawing.Size(147, 16);
            this.labelCadastrarAluno.TabIndex = 37;
            this.labelCadastrarAluno.Text = "Cadastrar Professor";
            this.labelCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(87, 22);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(586, 99);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupSetProfessor
            // 
            this.groupSetProfessor.Controls.Add(this.txtId);
            this.groupSetProfessor.Controls.Add(this.labelDataInic);
            this.groupSetProfessor.Controls.Add(this.labelFormacao);
            this.groupSetProfessor.Controls.Add(this.btnEnviar);
            this.groupSetProfessor.Controls.Add(this.maskDataInic);
            this.groupSetProfessor.Controls.Add(this.txtNome);
            this.groupSetProfessor.Controls.Add(this.labelSalario);
            this.groupSetProfessor.Controls.Add(this.txtFormacao);
            this.groupSetProfessor.Controls.Add(this.txtSalario);
            this.groupSetProfessor.Controls.Add(this.labelNome);
            this.groupSetProfessor.Location = new System.Drawing.Point(57, 31);
            this.groupSetProfessor.Name = "groupSetProfessor";
            this.groupSetProfessor.Size = new System.Drawing.Size(677, 133);
            this.groupSetProfessor.TabIndex = 40;
            this.groupSetProfessor.TabStop = false;
            this.groupSetProfessor.Text = "Cadastrar/Alterar";
            // 
            // dGVProfessores
            // 
            this.dGVProfessores.AllowUserToAddRows = false;
            this.dGVProfessores.AllowUserToDeleteRows = false;
            this.dGVProfessores.AllowUserToResizeRows = false;
            this.dGVProfessores.AutoGenerateColumns = false;
            this.dGVProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVProfessores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGVProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.formacaoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.dataInicialDataGridViewTextBoxColumn,
            this.Alterar,
            this.Excluir});
            this.dGVProfessores.DataSource = this.professoresBindingSource;
            this.dGVProfessores.EnableHeadersVisualStyles = false;
            this.dGVProfessores.Location = new System.Drawing.Point(57, 170);
            this.dGVProfessores.Name = "dGVProfessores";
            this.dGVProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVProfessores.Size = new System.Drawing.Size(677, 380);
            this.dGVProfessores.TabIndex = 6;
            this.dGVProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Alterar
            // 
            this.Alterar.DataPropertyName = "Id";
            this.Alterar.FillWeight = 75.0966F;
            this.Alterar.HeaderText = "";
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            this.Alterar.Text = "Alterar";
            this.Alterar.ToolTipText = "Alterar";
            this.Alterar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            this.Excluir.DataPropertyName = "Id";
            this.Excluir.FillWeight = 71.06599F;
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir";
            this.Excluir.ToolTipText = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.professoresDataSet;
            // 
            // professoresDataSet
            // 
            this.professoresDataSet.DataSetName = "ProfessoresDataSet";
            this.professoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(571, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 32;
            this.txtId.Visible = false;
            // 
            // professoresDataSetBindingSource
            // 
            this.professoresDataSetBindingSource.DataSource = this.professoresDataSet;
            this.professoresDataSetBindingSource.Position = 0;
            // 
            // dataInicialDataGridViewTextBoxColumn
            // 
            this.dataInicialDataGridViewTextBoxColumn.DataPropertyName = "DataInicial";
            this.dataInicialDataGridViewTextBoxColumn.FillWeight = 110.7675F;
            this.dataInicialDataGridViewTextBoxColumn.HeaderText = "DataInicial";
            this.dataInicialDataGridViewTextBoxColumn.Name = "dataInicialDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.FillWeight = 110.7675F;
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // formacaoDataGridViewTextBoxColumn
            // 
            this.formacaoDataGridViewTextBoxColumn.DataPropertyName = "Formacao";
            this.formacaoDataGridViewTextBoxColumn.FillWeight = 110.7675F;
            this.formacaoDataGridViewTextBoxColumn.HeaderText = "Formacao";
            this.formacaoDataGridViewTextBoxColumn.Name = "formacaoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 110.7675F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 110.7675F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dGVProfessores);
            this.Controls.Add(this.groupSetProfessor);
            this.Controls.Add(this.labelCadastrarAluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfessores";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Professores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProfessores_Load);
            this.groupSetProfessor.ResumeLayout(false);
            this.groupSetProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDataInic;
        private System.Windows.Forms.MaskedTextBox maskDataInic;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label labelFormacao;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.Label labelCadastrarAluno;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupSetProfessor;
        private System.Windows.Forms.DataGridView dGVProfessores;
        private ProfessoresDataSet professoresDataSet;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private ProfessoresDataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource professoresDataSetBindingSource;
    }
}