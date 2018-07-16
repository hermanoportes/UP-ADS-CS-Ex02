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
            this.groupSetAluno = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.maskTxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.labelDataNasc = new System.Windows.Forms.Label();
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labelCadastrarAluno = new System.Windows.Forms.Label();
            this.groupSetAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSetAluno
            // 
            this.groupSetAluno.Controls.Add(this.labelEmail);
            this.groupSetAluno.Controls.Add(this.txtNome);
            this.groupSetAluno.Controls.Add(this.labelUF);
            this.groupSetAluno.Controls.Add(this.labelMatricula);
            this.groupSetAluno.Controls.Add(this.maskTxtCEP);
            this.groupSetAluno.Controls.Add(this.labelNome);
            this.groupSetAluno.Controls.Add(this.comboUF);
            this.groupSetAluno.Controls.Add(this.labelDataNasc);
            this.groupSetAluno.Controls.Add(this.labelSexo);
            this.groupSetAluno.Controls.Add(this.txtCidade);
            this.groupSetAluno.Controls.Add(this.labelTelefone);
            this.groupSetAluno.Controls.Add(this.labelCidade);
            this.groupSetAluno.Controls.Add(this.labelEndereco);
            this.groupSetAluno.Controls.Add(this.labelLograd);
            this.groupSetAluno.Controls.Add(this.txtEmail);
            this.groupSetAluno.Controls.Add(this.labelComp);
            this.groupSetAluno.Controls.Add(this.txtMatricula);
            this.groupSetAluno.Controls.Add(this.labelNumero);
            this.groupSetAluno.Controls.Add(this.txtLograd);
            this.groupSetAluno.Controls.Add(this.maskTxtTelefone);
            this.groupSetAluno.Controls.Add(this.txtComp);
            this.groupSetAluno.Controls.Add(this.labelCEP);
            this.groupSetAluno.Controls.Add(this.txtNumero);
            this.groupSetAluno.Controls.Add(this.rdBtnMasc);
            this.groupSetAluno.Controls.Add(this.labelCPF);
            this.groupSetAluno.Controls.Add(this.rdBtnFem);
            this.groupSetAluno.Controls.Add(this.maskTxtDataNasc);
            this.groupSetAluno.Controls.Add(this.maskTxtCPF);
            this.groupSetAluno.Location = new System.Drawing.Point(19, 54);
            this.groupSetAluno.Name = "groupSetAluno";
            this.groupSetAluno.Size = new System.Drawing.Size(677, 271);
            this.groupSetAluno.TabIndex = 28;
            this.groupSetAluno.TabStop = false;
            this.groupSetAluno.Text = "Dados Pessoais";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(87, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 30;
            this.labelEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(200, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(298, 20);
            this.txtNome.TabIndex = 29;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(383, 184);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(21, 13);
            this.labelUF.TabIndex = 25;
            this.labelUF.Text = "UF";
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
            // maskTxtCEP
            // 
            this.maskTxtCEP.Location = new System.Drawing.Point(438, 200);
            this.maskTxtCEP.Mask = "00000-000";
            this.maskTxtCEP.Name = "maskTxtCEP";
            this.maskTxtCEP.Size = new System.Drawing.Size(60, 20);
            this.maskTxtCEP.TabIndex = 27;
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
            // comboUF
            // 
            this.comboUF.DropDownHeight = 110;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.IntegralHeight = false;
            this.comboUF.ItemHeight = 13;
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
            this.comboUF.Location = new System.Drawing.Point(386, 200);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(41, 21);
            this.comboUF.TabIndex = 26;
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Location = new System.Drawing.Point(87, 101);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(107, 13);
            this.labelDataNasc.TabIndex = 3;
            this.labelDataNasc.Text = "Data de Nascimento:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(87, 125);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(34, 13);
            this.labelSexo.TabIndex = 4;
            this.labelSexo.Text = "Sexo:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(200, 200);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(174, 20);
            this.txtCidade.TabIndex = 24;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(87, 227);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(52, 13);
            this.labelTelefone.TabIndex = 5;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(197, 184);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 23;
            this.labelCidade.Text = "Cidade";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(87, 164);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 6;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelLograd
            // 
            this.labelLograd.AutoSize = true;
            this.labelLograd.Location = new System.Drawing.Point(197, 145);
            this.labelLograd.Name = "labelLograd";
            this.labelLograd.Size = new System.Drawing.Size(61, 13);
            this.labelLograd.TabIndex = 22;
            this.labelLograd.Text = "Logradouro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(427, 145);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(71, 13);
            this.labelComp.TabIndex = 21;
            this.labelComp.Text = "Complemento";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(200, 20);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 8;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(377, 145);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 20;
            this.labelNumero.Text = "Número";
            // 
            // txtLograd
            // 
            this.txtLograd.Location = new System.Drawing.Point(200, 161);
            this.txtLograd.Name = "txtLograd";
            this.txtLograd.Size = new System.Drawing.Size(174, 20);
            this.txtLograd.TabIndex = 10;
            // 
            // maskTxtTelefone
            // 
            this.maskTxtTelefone.Location = new System.Drawing.Point(200, 224);
            this.maskTxtTelefone.Mask = "(00) 0000-0000";
            this.maskTxtTelefone.Name = "maskTxtTelefone";
            this.maskTxtTelefone.Size = new System.Drawing.Size(84, 20);
            this.maskTxtTelefone.TabIndex = 19;
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(429, 161);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(69, 20);
            this.txtComp.TabIndex = 11;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(435, 184);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(28, 13);
            this.labelCEP.TabIndex = 18;
            this.labelCEP.Text = "CEP";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(380, 161);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 20);
            this.txtNumero.TabIndex = 12;
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(273, 125);
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
            this.labelCPF.Location = new System.Drawing.Point(273, 101);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 13;
            this.labelCPF.Text = "CPF:";
            // 
            // rdBtnFem
            // 
            this.rdBtnFem.AutoSize = true;
            this.rdBtnFem.Location = new System.Drawing.Point(200, 125);
            this.rdBtnFem.Name = "rdBtnFem";
            this.rdBtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFem.TabIndex = 16;
            this.rdBtnFem.TabStop = true;
            this.rdBtnFem.Text = "Feminino";
            this.rdBtnFem.UseVisualStyleBackColor = true;
            // 
            // maskTxtDataNasc
            // 
            this.maskTxtDataNasc.Location = new System.Drawing.Point(200, 98);
            this.maskTxtDataNasc.Mask = "00/00/0000";
            this.maskTxtDataNasc.Name = "maskTxtDataNasc";
            this.maskTxtDataNasc.Size = new System.Drawing.Size(67, 20);
            this.maskTxtDataNasc.TabIndex = 14;
            this.maskTxtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // maskTxtCPF
            // 
            this.maskTxtCPF.Location = new System.Drawing.Point(309, 98);
            this.maskTxtCPF.Mask = "000.000.000/00";
            this.maskTxtCPF.Name = "maskTxtCPF";
            this.maskTxtCPF.Size = new System.Drawing.Size(87, 20);
            this.maskTxtCPF.TabIndex = 15;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(613, 331);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(85, 28);
            this.btnEnviar.TabIndex = 28;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCadastrarAluno
            // 
            this.labelCadastrarAluno.AutoSize = true;
            this.labelCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarAluno.Location = new System.Drawing.Point(12, 35);
            this.labelCadastrarAluno.Name = "labelCadastrarAluno";
            this.labelCadastrarAluno.Size = new System.Drawing.Size(119, 16);
            this.labelCadastrarAluno.TabIndex = 29;
            this.labelCadastrarAluno.Text = "Cadastrar Aluno";
            this.labelCadastrarAluno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.labelCadastrarAluno);
            this.Controls.Add(this.groupSetAluno);
            this.Controls.Add(this.btnEnviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarAluno";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Aluno";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupSetAluno.ResumeLayout(false);
            this.groupSetAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupSetAluno;
        private System.Windows.Forms.Button btnEnviar;
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
        private System.Windows.Forms.Label labelCadastrarAluno;
    }
}