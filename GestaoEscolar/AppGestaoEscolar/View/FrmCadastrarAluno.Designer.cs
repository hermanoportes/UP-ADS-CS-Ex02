namespace AppGestaoEscolar.View
{
    partial class FrmCadastrarAluno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.maskTxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.labelUF = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelLograd = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelComp = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.txtLograd = new System.Windows.Forms.TextBox();
            this.maskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.rdBtnMasc = new System.Windows.Forms.RadioButton();
            this.labelCPF = new System.Windows.Forms.Label();
            this.rdBtnFem = new System.Windows.Forms.RadioButton();
            this.maskTxtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.maskTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.menuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.MenuItemSair.Size = new System.Drawing.Size(97, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelMatricula);
            this.groupBox1.Controls.Add(this.maskTxtCEP);
            this.groupBox1.Controls.Add(this.labelNome);
            this.groupBox1.Controls.Add(this.comboUF);
            this.groupBox1.Controls.Add(this.labelDataNasc);
            this.groupBox1.Controls.Add(this.labelUF);
            this.groupBox1.Controls.Add(this.labelSexo);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.labelTelefone);
            this.groupBox1.Controls.Add(this.labelCidade);
            this.groupBox1.Controls.Add(this.labelEndereco);
            this.groupBox1.Controls.Add(this.labelLograd);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.labelComp);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.labelNumero);
            this.groupBox1.Controls.Add(this.txtLograd);
            this.groupBox1.Controls.Add(this.maskTxtTelefone);
            this.groupBox1.Controls.Add(this.txtComp);
            this.groupBox1.Controls.Add(this.labelCEP);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.rdBtnMasc);
            this.groupBox1.Controls.Add(this.labelCPF);
            this.groupBox1.Controls.Add(this.rdBtnFem);
            this.groupBox1.Controls.Add(this.maskTxtDataNasc);
            this.groupBox1.Controls.Add(this.maskTxtCPF);
            this.groupBox1.Location = new System.Drawing.Point(12, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 223);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar/Alterar";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(87, 45);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 20);
            this.txtNome.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(402, 71);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(55, 13);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // maskTxtCEP
            // 
            this.maskTxtCEP.Location = new System.Drawing.Point(438, 170);
            this.maskTxtCEP.Mask = "00000-000";
            this.maskTxtCEP.Name = "maskTxtCEP";
            this.maskTxtCEP.Size = new System.Drawing.Size(60, 20);
            this.maskTxtCEP.TabIndex = 27;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(87, 19);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // comboUF
            // 
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.comboUF.Location = new System.Drawing.Point(388, 170);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(41, 21);
            this.comboUF.TabIndex = 26;
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Location = new System.Drawing.Point(87, 71);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(107, 13);
            this.labelDataNasc.TabIndex = 3;
            this.labelDataNasc.Text = "Data de Nascimento:";
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(377, 154);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(21, 13);
            this.labelUF.TabIndex = 25;
            this.labelUF.Text = "UF";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(87, 95);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 4;
            this.labelSexo.Text = "Sexo:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(200, 170);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(174, 20);
            this.txtCidade.TabIndex = 24;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(87, 197);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(52, 13);
            this.labelTelefone.TabIndex = 5;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(197, 154);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 23;
            this.labelCidade.Text = "Cidade";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(87, 134);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 6;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelLograd
            // 
            this.labelLograd.AutoSize = true;
            this.labelLograd.Location = new System.Drawing.Point(197, 115);
            this.labelLograd.Name = "labelLograd";
            this.labelLograd.Size = new System.Drawing.Size(61, 13);
            this.labelLograd.TabIndex = 22;
            this.labelLograd.Text = "Logradouro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(427, 115);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(71, 13);
            this.labelComp.TabIndex = 21;
            this.labelComp.Text = "Complemento";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(463, 68);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(377, 115);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 20;
            this.labelNumero.Text = "Número";
            // 
            // txtLograd
            // 
            this.txtLograd.Location = new System.Drawing.Point(200, 131);
            this.txtLograd.Name = "txtLograd";
            this.txtLograd.Size = new System.Drawing.Size(174, 20);
            this.txtLograd.TabIndex = 10;
            // 
            // maskTxtTelefone
            // 
            this.maskTxtTelefone.Location = new System.Drawing.Point(200, 194);
            this.maskTxtTelefone.Mask = "(00) 0000-0000";
            this.maskTxtTelefone.Name = "maskTxtTelefone";
            this.maskTxtTelefone.Size = new System.Drawing.Size(84, 20);
            this.maskTxtTelefone.TabIndex = 19;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(429, 131);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(69, 20);
            this.txtComp.TabIndex = 11;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(435, 154);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(28, 13);
            this.labelCEP.TabIndex = 18;
            this.labelCEP.Text = "CEP";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(380, 131);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(273, 95);
            this.rdBtnMasc.Name = "rdBtnMasc";
            this.rdBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasc.TabIndex = 17;
            this.rdBtnMasc.TabStop = true;
            this.rdBtnMasc.Text = "Masculino";
            this.rdBtnMasc.UseVisualStyleBackColor = true;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(273, 71);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 13;
            this.labelCPF.Text = "CPF:";
            // 
            // rdBtnFem
            // 
            this.rdBtnFem.AutoSize = true;
            this.rdBtnFem.Location = new System.Drawing.Point(200, 95);
            this.rdBtnFem.Name = "rdBtnFem";
            this.rdBtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFem.TabIndex = 16;
            this.rdBtnFem.TabStop = true;
            this.rdBtnFem.Text = "Feminino";
            this.rdBtnFem.UseVisualStyleBackColor = true;
            // 
            // maskTxtDataNasc
            // 
            this.maskTxtDataNasc.Location = new System.Drawing.Point(200, 68);
            this.maskTxtDataNasc.Mask = "00/00/0000";
            this.maskTxtDataNasc.Name = "maskTxtDataNasc";
            this.maskTxtDataNasc.Size = new System.Drawing.Size(67, 20);
            this.maskTxtDataNasc.TabIndex = 14;
            this.maskTxtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // maskTxtCPF
            // 
            this.maskTxtCPF.Location = new System.Drawing.Point(309, 68);
            this.maskTxtCPF.Mask = "000.000.000/00";
            this.maskTxtCPF.Name = "maskTxtCPF";
            this.maskTxtCPF.Size = new System.Drawing.Size(87, 20);
            this.maskTxtCPF.TabIndex = 15;
            // 
            // FrmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarAluno";
            this.Text = "Cadastrar Aluno";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.MaskedTextBox maskTxtCEP;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelLograd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox txtLograd;
        private System.Windows.Forms.MaskedTextBox maskTxtTelefone;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.RadioButton rdBtnFem;
        private System.Windows.Forms.MaskedTextBox maskTxtDataNasc;
        private System.Windows.Forms.MaskedTextBox maskTxtCPF;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStripMenuItem MenuArquivo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSair;
    }
}