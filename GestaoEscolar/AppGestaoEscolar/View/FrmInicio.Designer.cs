namespace AppGestaoEscolar
{
    partial class FrmInicio
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlterarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExcluirAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListarAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlterarProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluirProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuListarProfessores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuscarProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarDisciplina = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultarDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuArquivo,
            this.MenuAlunos,
            this.MenuProfessores,
            this.MenuDisciplinas});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(704, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuPrincipal";
            // 
            // MenuArquivo
            // 
            this.MenuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSair});
            this.MenuArquivo.Name = "MenuArquivo";
            this.MenuArquivo.Size = new System.Drawing.Size(61, 20);
            this.MenuArquivo.Text = "Arquivo";
            // 
            // MenuItemSair
            // 
            this.MenuItemSair.Name = "MenuItemSair";
            this.MenuItemSair.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSair.Text = "Sair";
            this.MenuItemSair.Click += new System.EventHandler(this.MenuItemSair_Click);
            // 
            // MenuAlunos
            // 
            this.MenuAlunos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarAluno,
            this.menuAlterarAluno,
            this.menuExcluirAluno,
            this.menuListarAlunos,
            this.menuBuscarAluno});
            this.MenuAlunos.Name = "MenuAlunos";
            this.MenuAlunos.Size = new System.Drawing.Size(59, 20);
            this.MenuAlunos.Text = "Alunos";
            // 
            // menuCadastrarAluno
            // 
            this.menuCadastrarAluno.Name = "menuCadastrarAluno";
            this.menuCadastrarAluno.Size = new System.Drawing.Size(130, 22);
            this.menuCadastrarAluno.Text = "Cadastrar";
            this.menuCadastrarAluno.Click += new System.EventHandler(this.menuCadastrarAluno_Click);
            // 
            // menuAlterarAluno
            // 
            this.menuAlterarAluno.Name = "menuAlterarAluno";
            this.menuAlterarAluno.Size = new System.Drawing.Size(130, 22);
            this.menuAlterarAluno.Text = "Alterar";
            this.menuAlterarAluno.Click += new System.EventHandler(this.menuAlterarAluno_Click);
            // 
            // menuExcluirAluno
            // 
            this.menuExcluirAluno.Name = "menuExcluirAluno";
            this.menuExcluirAluno.Size = new System.Drawing.Size(130, 22);
            this.menuExcluirAluno.Text = "Excluir";
            this.menuExcluirAluno.Click += new System.EventHandler(this.menuExcluirAluno_Click);
            // 
            // menuListarAlunos
            // 
            this.menuListarAlunos.Name = "menuListarAlunos";
            this.menuListarAlunos.Size = new System.Drawing.Size(130, 22);
            this.menuListarAlunos.Text = "Listar";
            this.menuListarAlunos.Click += new System.EventHandler(this.menuListarAlunos_Click);
            // 
            // menuBuscarAluno
            // 
            this.menuBuscarAluno.Name = "menuBuscarAluno";
            this.menuBuscarAluno.Size = new System.Drawing.Size(130, 22);
            this.menuBuscarAluno.Text = "Buscar";
            this.menuBuscarAluno.Click += new System.EventHandler(this.menuBuscarAluno_Click);
            // 
            // MenuProfessores
            // 
            this.MenuProfessores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrarProfessor,
            this.MenuAlterarProfessor,
            this.MenuExcluirProfessor,
            this.MenuListarProfessores,
            this.MenuBuscarProfessor});
            this.MenuProfessores.Name = "MenuProfessores";
            this.MenuProfessores.Size = new System.Drawing.Size(88, 20);
            this.MenuProfessores.Text = "Professores";
            // 
            // MenuCadastrarProfessor
            // 
            this.MenuCadastrarProfessor.Name = "MenuCadastrarProfessor";
            this.MenuCadastrarProfessor.Size = new System.Drawing.Size(130, 22);
            this.MenuCadastrarProfessor.Text = "Cadastrar";
            this.MenuCadastrarProfessor.Click += new System.EventHandler(this.MenuCadastrarProfessor_Click);
            // 
            // MenuAlterarProfessor
            // 
            this.MenuAlterarProfessor.Name = "MenuAlterarProfessor";
            this.MenuAlterarProfessor.Size = new System.Drawing.Size(130, 22);
            this.MenuAlterarProfessor.Text = "Alterar";
            this.MenuAlterarProfessor.Click += new System.EventHandler(this.MenuAlterarProfessor_Click);
            // 
            // MenuExcluirProfessor
            // 
            this.MenuExcluirProfessor.Name = "MenuExcluirProfessor";
            this.MenuExcluirProfessor.Size = new System.Drawing.Size(130, 22);
            this.MenuExcluirProfessor.Text = "Excluir";
            this.MenuExcluirProfessor.Click += new System.EventHandler(this.MenuExcluirProfessor_Click);
            // 
            // MenuListarProfessores
            // 
            this.MenuListarProfessores.Name = "MenuListarProfessores";
            this.MenuListarProfessores.Size = new System.Drawing.Size(130, 22);
            this.MenuListarProfessores.Text = "Listar";
            this.MenuListarProfessores.Click += new System.EventHandler(this.MenuListarProfessores_Click);
            // 
            // MenuBuscarProfessor
            // 
            this.MenuBuscarProfessor.Name = "MenuBuscarProfessor";
            this.MenuBuscarProfessor.Size = new System.Drawing.Size(130, 22);
            this.MenuBuscarProfessor.Text = "Buscar";
            this.MenuBuscarProfessor.Click += new System.EventHandler(this.MenuBuscarProfessor_Click);
            // 
            // MenuDisciplinas
            // 
            this.MenuDisciplinas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrarDisciplina,
            this.MenuConsultarDisciplinas});
            this.MenuDisciplinas.Name = "MenuDisciplinas";
            this.MenuDisciplinas.Size = new System.Drawing.Size(82, 20);
            this.MenuDisciplinas.Text = "Disciplinas";
            // 
            // MenuCadastrarDisciplina
            // 
            this.MenuCadastrarDisciplina.Name = "MenuCadastrarDisciplina";
            this.MenuCadastrarDisciplina.Size = new System.Drawing.Size(196, 22);
            this.MenuCadastrarDisciplina.Text = "Cadastrar";
            this.MenuCadastrarDisciplina.Click += new System.EventHandler(this.MenuCadastrarDisciplina_Click);
            // 
            // MenuConsultarDisciplinas
            // 
            this.MenuConsultarDisciplinas.Name = "MenuConsultarDisciplinas";
            this.MenuConsultarDisciplinas.Size = new System.Drawing.Size(196, 22);
            this.MenuConsultarDisciplinas.Text = "Consultar Disciplinas";
            this.MenuConsultarDisciplinas.Click += new System.EventHandler(this.MenuConsultarDisciplinas_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.Text = "Sistema de Gestão Escolar";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuAlunos;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarAluno;
        private System.Windows.Forms.ToolStripMenuItem menuAlterarAluno;
        private System.Windows.Forms.ToolStripMenuItem menuExcluirAluno;
        private System.Windows.Forms.ToolStripMenuItem menuListarAlunos;
        private System.Windows.Forms.ToolStripMenuItem menuBuscarAluno;
        private System.Windows.Forms.ToolStripMenuItem MenuProfessores;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarProfessor;
        private System.Windows.Forms.ToolStripMenuItem MenuAlterarProfessor;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluirProfessor;
        private System.Windows.Forms.ToolStripMenuItem MenuListarProfessores;
        private System.Windows.Forms.ToolStripMenuItem MenuBuscarProfessor;
        private System.Windows.Forms.ToolStripMenuItem MenuDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarDisciplina;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultarDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
    }
}