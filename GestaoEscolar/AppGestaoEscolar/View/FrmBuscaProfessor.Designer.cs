namespace AppGestaoEscolar.View
{
    partial class FrmBuscaProfessor
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
            this.dGVListaProfessores = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professoresDataSet = new AppGestaoEscolar.ProfessoresDataSet();
            this.professoresTableAdapter = new AppGestaoEscolar.ProfessoresDataSetTableAdapters.ProfessoresTableAdapter();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVListaProfessores
            // 
            this.dGVListaProfessores.AllowUserToAddRows = false;
            this.dGVListaProfessores.AllowUserToDeleteRows = false;
            this.dGVListaProfessores.AllowUserToResizeRows = false;
            this.dGVListaProfessores.AutoGenerateColumns = false;
            this.dGVListaProfessores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVListaProfessores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dGVListaProfessores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGVListaProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListaProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.formacaoDataGridViewTextBoxColumn});
            this.dGVListaProfessores.DataSource = this.professoresBindingSource;
            this.dGVListaProfessores.EnableHeadersVisualStyles = false;
            this.dGVListaProfessores.Location = new System.Drawing.Point(12, 12);
            this.dGVListaProfessores.MultiSelect = false;
            this.dGVListaProfessores.Name = "dGVListaProfessores";
            this.dGVListaProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVListaProfessores.Size = new System.Drawing.Size(486, 205);
            this.dGVListaProfessores.TabIndex = 6;
            this.dGVListaProfessores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListaProfessores_CellContentClick);
            this.dGVListaProfessores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListaProfessores_CellContentClick);
            this.dGVListaProfessores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListaProfessores_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 41.6524F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.FillWeight = 106.0633F;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // formacaoDataGridViewTextBoxColumn
            // 
            this.formacaoDataGridViewTextBoxColumn.DataPropertyName = "Formacao";
            this.formacaoDataGridViewTextBoxColumn.FillWeight = 152.2843F;
            this.formacaoDataGridViewTextBoxColumn.HeaderText = "Formacao";
            this.formacaoDataGridViewTextBoxColumn.Name = "formacaoDataGridViewTextBoxColumn";
            this.formacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formacaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(423, 223);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmBuscaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dGVListaProfessores);
            this.Name = "FrmBuscaProfessor";
            this.Text = "Buscar Professor";
            this.Load += new System.EventHandler(this.FrmBuscaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListaProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVListaProfessores;
        private ProfessoresDataSet professoresDataSet;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private ProfessoresDataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOK;
    }
}