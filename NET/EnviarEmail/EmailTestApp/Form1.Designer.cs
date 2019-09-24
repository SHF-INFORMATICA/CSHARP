namespace EmailTestApp
{
    partial class Form1
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 479);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(118, 161);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(531, 77);
            this.txtMensagem.TabIndex = 35;
            this.txtMensagem.Text = "Bom dia. Segue anexo arquivos XML";
            // 
            // txtAssuntoTitulo
            // 
            this.txtAssuntoTitulo.Location = new System.Drawing.Point(118, 131);
            this.txtAssuntoTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAssuntoTitulo.Name = "txtAssuntoTitulo";
            this.txtAssuntoTitulo.Size = new System.Drawing.Size(531, 20);
            this.txtAssuntoTitulo.TabIndex = 33;
            this.txtAssuntoTitulo.Text = "XML";
            // 
            // txtEnviadoPor
            // 
            this.txtEnviadoPor.Location = new System.Drawing.Point(118, 102);
            this.txtEnviadoPor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviadoPor.Name = "txtEnviadoPor";
            this.txtEnviadoPor.Size = new System.Drawing.Size(531, 20);
            this.txtEnviadoPor.TabIndex = 31;
            this.txtEnviadoPor.Text = "shfhoracio@gmail.com";
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.Location = new System.Drawing.Point(118, 72);
            this.txtEnviarPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(531, 20);
            this.txtEnviarPara.TabIndex = 29;
            this.txtEnviarPara.Text = "shfhoracio@gmail.com";
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(52, 131);
            this.lblSubjectLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(48, 13);
            this.lblSubjectLine.TabIndex = 34;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // lblRemetente
            // 
            this.lblRemetente.AutoSize = true;
            this.lblRemetente.Location = new System.Drawing.Point(81, 107);
            this.lblRemetente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemetente.Name = "lblRemetente";
            this.lblRemetente.Size = new System.Drawing.Size(24, 13);
            this.lblRemetente.TabIndex = 32;
            this.lblRemetente.Text = "De:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(71, 76);
            this.lblDestinatario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lblDestinatario.TabIndex = 30;
            this.lblDestinatario.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Anexo(s):";
            // 
            // txtAnexos
            // 
            this.txtAnexos.Location = new System.Drawing.Point(249, 337);
            this.txtAnexos.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnexos.Name = "txtAnexos";
            this.txtAnexos.Size = new System.Drawing.Size(408, 20);
            this.txtAnexos.TabIndex = 27;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(377, 298);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(280, 20);
            this.txtLocal.TabIndex = 26;
            // 
            // cmdCarregar
            // 
            this.cmdCarregar.Location = new System.Drawing.Point(64, 295);
            this.cmdCarregar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCarregar.Name = "cmdCarregar";
            this.cmdCarregar.Size = new System.Drawing.Size(100, 28);
            this.cmdCarregar.TabIndex = 20;
            this.cmdCarregar.Text = "Carregar";
            this.cmdCarregar.UseVisualStyleBackColor = true;
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Location = new System.Drawing.Point(64, 331);
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
            this.label1.Location = new System.Drawing.Point(170, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ANO/MÊS:";
            // 
            // cmbMesAno
            // 
            this.cmbMesAno.FormattingEnabled = true;
            this.cmbMesAno.Location = new System.Drawing.Point(249, 296);
            this.cmbMesAno.Name = "cmbMesAno";
            this.cmbMesAno.Size = new System.Drawing.Size(121, 21);
            this.cmbMesAno.TabIndex = 21;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(557, 367);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(100, 28);
            this.cmdCancelar.TabIndex = 25;
            this.cmdCancelar.Text = "&Sair";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdEnviar
            // 
            this.cmdEnviar.Location = new System.Drawing.Point(64, 367);
            this.cmdEnviar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(100, 28);
            this.cmdEnviar.TabIndex = 23;
            this.cmdEnviar.Text = "Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 494);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}