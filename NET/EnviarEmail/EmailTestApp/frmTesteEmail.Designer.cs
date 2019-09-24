namespace SHF.TesteEmail
{
    partial class frmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.svfdlg1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtAssuntoTitulo = new System.Windows.Forms.TextBox();
            this.txtEnviadoPor = new System.Windows.Forms.TextBox();
            this.txtEnviarPara = new System.Windows.Forms.TextBox();
            this.lblSubjectLine = new System.Windows.Forms.Label();
            this.lblRemetente = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnexos = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.cmdCarregar = new System.Windows.Forms.Button();
            this.cmdIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMesAno = new System.Windows.Forms.ComboBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmdGravaContador = new System.Windows.Forms.Button();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkTLS = new System.Windows.Forms.CheckBox();
            this.chkSSl = new System.Windows.Forms.CheckBox();
            this.chkAutentica = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Add Attachment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 479);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMensagem);
            this.tabPage1.Controls.Add(this.txtAssuntoTitulo);
            this.tabPage1.Controls.Add(this.txtEnviadoPor);
            this.tabPage1.Controls.Add(this.txtEnviarPara);
            this.tabPage1.Controls.Add(this.lblSubjectLine);
            this.tabPage1.Controls.Add(this.lblRemetente);
            this.tabPage1.Controls.Add(this.lblDestinatario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAnexos);
            this.tabPage1.Controls.Add(this.txtLocal);
            this.tabPage1.Controls.Add(this.cmdCarregar);
            this.tabPage1.Controls.Add(this.cmdIncluir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbMesAno);
            this.tabPage1.Controls.Add(this.cmdCancelar);
            this.tabPage1.Controls.Add(this.cmdEnviar);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enviar email";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(75, 110);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(531, 77);
            this.txtMensagem.TabIndex = 35;
            this.txtMensagem.Text = "Bom dia. Segue anexo arquivos XML";
            // 
            // txtAssuntoTitulo
            // 
            this.txtAssuntoTitulo.Location = new System.Drawing.Point(75, 80);
            this.txtAssuntoTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssuntoTitulo.Name = "txtAssuntoTitulo";
            this.txtAssuntoTitulo.Size = new System.Drawing.Size(531, 26);
            this.txtAssuntoTitulo.TabIndex = 33;
            this.txtAssuntoTitulo.Text = "XML";
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.Location = new System.Drawing.Point(75, 51);
            this.txtEnviadoPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(531, 26);
            this.txtEnviadoPor.TabIndex = 31;
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.Location = new System.Drawing.Point(75, 21);
            this.txtEnviarPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(531, 26);
            this.txtEnviarPara.TabIndex = 29;
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(9, 80);
            this.lblSubjectLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(80, 19);
            this.lblSubjectLine.TabIndex = 34;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(38, 51);
            this.lblRemetente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(36, 19);
            this.lblRemetente.TabIndex = 32;
            this.lblRemetente.Text = "De:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(28, 21);
            this.lblDestinatario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(51, 19);
            this.lblDestinatario.TabIndex = 30;
            this.lblDestinatario.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Anexo(s):";
            // 
            // txtAnexos
            // 
            this.txtAnexos.Location = new System.Drawing.Point(197, 255);
            this.txtAnexos.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnexos.Name = "txtAnexos";
            this.txtAnexos.Size = new System.Drawing.Size(408, 26);
            this.txtAnexos.TabIndex = 27;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(325, 216);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(280, 26);
            this.txtLocal.TabIndex = 26;
            // 
            // cmdCarregar
            // 
            this.cmdCarregar.Location = new System.Drawing.Point(12, 213);
            this.cmdCarregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCarregar.Name = "cmdCarregar";
            this.cmdCarregar.Size = new System.Drawing.Size(100, 28);
            this.cmdCarregar.TabIndex = 20;
            this.cmdCarregar.Text = "Carregar";
            this.cmdCarregar.UseVisualStyleBackColor = true;
            this.cmdCarregar.Click += new System.EventHandler(this.cmdCarregar_Click);
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Location = new System.Drawing.Point(12, 249);
            this.cmdIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdIncluir.Name = "cmdIncluir";
            this.cmdIncluir.Size = new System.Drawing.Size(100, 28);
            this.cmdIncluir.TabIndex = 24;
            this.cmdIncluir.Text = "Incluir";
            this.cmdIncluir.UseVisualStyleBackColor = true;
            this.cmdIncluir.Visible = false;
            this.cmdIncluir.Click += new System.EventHandler(this.cmdIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "ANO/MÊS:";
            // 
            // cmbMesAno
            // 
            this.cmbMesAno.FormattingEnabled = true;
            this.cmbMesAno.Location = new System.Drawing.Point(197, 214);
            this.cmbMesAno.Name = "cmbMesAno";
            this.cmbMesAno.Size = new System.Drawing.Size(121, 27);
            this.cmbMesAno.TabIndex = 21;
            this.cmbMesAno.SelectedIndexChanged += new System.EventHandler(this.cmbMesAno_SelectedIndexChanged_1);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(505, 285);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(100, 28);
            this.cmdCancelar.TabIndex = 25;
            this.cmdCancelar.Text = "&Sair";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Location = new System.Drawing.Point(12, 285);
            this.cmdEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(100, 28);
            this.cmdEnviar.TabIndex = 23;
            this.cmdEnviar.Text = "Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdGravaContador);
            this.tabPage2.Controls.Add(this.txtContador);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.chkTLS);
            this.tabPage2.Controls.Add(this.chkSSl);
            this.tabPage2.Controls.Add(this.chkAutentica);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPorta);
            this.tabPage2.Controls.Add(this.txtSMTP);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSenha);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdGravaContador
            // 
            this.cmdGravaContador.Location = new System.Drawing.Point(236, 268);
            this.cmdGravaContador.Name = "cmdGravaContador";
            this.cmdGravaContador.Size = new System.Drawing.Size(116, 57);
            this.cmdGravaContador.TabIndex = 46;
            this.cmdGravaContador.Text = "Gravar";
            this.cmdGravaContador.UseVisualStyleBackColor = true;
            this.cmdGravaContador.Click += new System.EventHandler(this.cmdGravaContador_Click);
            // 
            // txtContador
            // 
            this.txtContador.Location = new System.Drawing.Point(125, 61);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(320, 26);
            this.txtContador.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "E-mail Conador:";
            // 
            // chkTLS
            // 
            this.chkTLS.AutoSize = true;
            this.chkTLS.Location = new System.Drawing.Point(86, 236);
            this.chkTLS.Name = "chkTLS";
            this.chkTLS.Size = new System.Drawing.Size(62, 23);
            this.chkTLS.TabIndex = 43;
            this.chkTLS.Text = "TLS";
            this.chkTLS.UseVisualStyleBackColor = true;
            // 
            // chkSSl
            // 
            this.chkSSl.AutoSize = true;
            this.chkSSl.Location = new System.Drawing.Point(86, 210);
            this.chkSSl.Name = "chkSSl";
            this.chkSSl.Size = new System.Drawing.Size(63, 23);
            this.chkSSl.TabIndex = 42;
            this.chkSSl.Text = "SSL";
            this.chkSSl.UseVisualStyleBackColor = true;
            // 
            // chkAutentica
            // 
            this.chkAutentica.AutoSize = true;
            this.chkAutentica.Location = new System.Drawing.Point(68, 184);
            this.chkAutentica.Name = "chkAutentica";
            this.chkAutentica.Size = new System.Drawing.Size(295, 23);
            this.chkAutentica.TabIndex = 41;
            this.chkAutentica.Text = "Meu servidor requer autenticação";
            this.chkAutentica.UseVisualStyleBackColor = true;
            this.chkAutentica.CheckedChanged += new System.EventHandler(this.chkAutentica_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Porta:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(514, 124);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(134, 26);
            this.txtPorta.TabIndex = 39;
            this.txtPorta.Text = "587";
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(125, 124);
            this.txtSMTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(320, 26);
            this.txtSMTP.TabIndex = 37;
            this.txtSMTP.Text = "smtp.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "SMTP:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(514, 22);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(135, 26);
            this.txtSenha.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 22);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 26);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.Text = "https://myaccount.google.com/lesssecureapps?pli=1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "E-mail:";
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(744, 471);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar email XML Contador";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.SaveFileDialog svfdlg1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtAssuntoTitulo;
        private System.Windows.Forms.TextBox txtEnviadoPor;
        private System.Windows.Forms.TextBox txtEnviarPara;
        private System.Windows.Forms.Label lblSubjectLine;
        private System.Windows.Forms.Label lblRemetente;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnexos;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Button cmdCarregar;
        private System.Windows.Forms.Button cmdIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMesAno;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.CheckBox chkAutentica;
        private System.Windows.Forms.CheckBox chkTLS;
        private System.Windows.Forms.CheckBox chkSSl;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdGravaContador;
    }
}

