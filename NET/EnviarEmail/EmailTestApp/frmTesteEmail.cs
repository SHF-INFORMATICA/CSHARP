using System;
using System.IO;
using System.IO.Compression;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SHF.TesteEmail
{
    public partial class frmEmail : Form
    {
        /// <summary>
        /// Um array lista contento todos os anexos
        /// </summary>
        ArrayList aAnexosEmail;
        private string CaminhoNFE_A;
        private int Cont_N = 0;
        private string Diretorio_Zip_A;
        private string Email_Contador_A;
        private string Email_Empresa_A;
        private string SERVIDOR_MEGASIM;
        private string NOME_BANCO_DADOS;
        private string SENHA_ADM_SQLSERVER = "ejsnenas";
        private string USUARIO_ADM_SQLSERVER = "sa";
        private int Empresa_Id_N = 1;
        private int Estabelecimento_Id_N = 1;

        /// <summary>
        /// O construtor padrão
        /// </summary>
        public frmEmail()
        {
            InitializeComponent();
        }
        
        private void frmEmail_Load(object sender, EventArgs e)
        {
            CarregaAnoMes();
            CarregaDados();
        }

        private void CarregaAnoMes()
        {
            CaminhoNFE_A = Application.StartupPath;
            CaminhoNFE_A = CaminhoNFE_A.Replace("'\'", "'\\'") + "\\megasim.ini";

            string[] linhas = File.ReadAllLines(CaminhoNFE_A);
            Cont_N = 1;

            foreach (string linha in linhas)
            {
                if (Cont_N == 1)
                {
                    SERVIDOR_MEGASIM = linha;
                }
                if (Cont_N == 2)
                {
                    NOME_BANCO_DADOS = linha;
                }

                if (Cont_N == 15) {
                    CaminhoNFE_A = linha;
                }

                Cont_N = Cont_N + 1;
            }

            CaminhoNFE_A = CaminhoNFE_A.Replace("'\\\\'", "'\\'");

            string[] filePaths = Directory.GetDirectories(CaminhoNFE_A);

            txtLocal.Text = CaminhoNFE_A;
            cmbMesAno.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(CaminhoNFE_A);
            DirectoryInfo[] directories = di.GetDirectories("*", SearchOption.TopDirectoryOnly);

            foreach (var _file in directories)
            {
                //pega o nome do arquivo
                cmbMesAno.Items.Add(_file.Name.ToString());
            }
        }
        private void CarregaDados()
        {
            //=========================
            string Conexao_DB = "Data Source = " + SERVIDOR_MEGASIM + " ;Initial Catalog = " + NOME_BANCO_DADOS + " ; user id = " + USUARIO_ADM_SQLSERVER + " ; password = " + SENHA_ADM_SQLSERVER + " ; MultipleActiveResultSets=True;";
            string strSql;

            SqlConnection sqlConn = new SqlConnection(Conexao_DB);
            sqlConn.Open();

            strSql = "SELECT EMAIL.EMAIL FROM EMPRESA ";
            strSql = strSql + " INNER JOIN EMAIL ";
            strSql = strSql + " ON EMPRESA.PESSOA_ID = EMAIL.PESSOA_ID ";
            strSql = strSql + " where empresa_id = " + Empresa_Id_N;

            SqlCommand cmd = new SqlCommand(strSql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.FieldCount > 0)
            {
                Email_Empresa_A = dr["email"].ToString();
            }
            cmd.Dispose();
            //while (dr.Read())
            //{
            //Email_Empresa_A = dr["email"].ToString(); 
            //}

            txtEmail.Text = Email_Empresa_A;
            txtEnviadoPor.Text = txtEmail.Text;

            //MessageBox.Show(txtEmail.Text, "vaca");

            //trazer email do contador do banco MEGASIM
            strSql = "SELECT * from EMAILCONFIG ";
            strSql = strSql + " where estabelecimento_id = " + Estabelecimento_Id_N;

            SqlCommand cmd2 = new SqlCommand(strSql, sqlConn);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            dr2.Read();
            if (dr2.HasRows)
            {
                Email_Empresa_A = dr2["REMETENTE_A"].ToString();
                Email_Contador_A = dr2["DESTINATARIO_A"].ToString();
                txtSMTP.Text = dr2["SMTP"].ToString();
                txtPorta.Text = dr2["porta"].ToString();
                txtSenha.Text = dr2["SENHA_EMAIL"].ToString();
            }
            txtEnviarPara.Text = Email_Contador_A;
            txtEmail.Text = Email_Empresa_A;
            txtContador.Text = Email_Contador_A;

            dr2.Close();
            cmd2.Dispose();
            sqlConn.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdCarregar_Click(object sender, EventArgs e)
        {
            CarregaAnoMes();
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] arr = ofd1.FileNames;
                    aAnexosEmail = new ArrayList();
                    txtAnexos.Text = string.Empty;
                    aAnexosEmail.AddRange(arr);

                    foreach (string s in aAnexosEmail)
                    {
                        txtAnexos.Text += s + "; ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void cmdEnviar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtEnviarPara.Text))
            {
                MessageBox.Show("Endereço de email do destinatário inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtEnviadoPor.Text))
            {
                MessageBox.Show("Endereço de email do remetente inválido.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtAssuntoTitulo.Text))
            {
                MessageBox.Show("Definição do assunto inválida.", "Erro ");
                return;
            }
            if (String.IsNullOrEmpty(txtMensagem.Text))
            {
                MessageBox.Show("Mensagem inválida.", "Erro ");
                return;
            }

            //separa os anexos em um array de string
            string[] arr = txtAnexos.Text.Split(';');

            //cria um novo arraylist
            aAnexosEmail = new ArrayList();
            //percorre o array de string e inclui os anexos
            for (int i = 0; i < arr.Length; i++)
            {
                if (!String.IsNullOrEmpty(arr[i].ToString().Trim()))
                {
                    aAnexosEmail.Add(arr[i].ToString().Trim());
                }
            }

            // Se existirem anexos , envia a mensagem com 
            // a chamada a EnviaMensagemComAnexos senão
            // usa o método enviaMensagemEmail
            if (aAnexosEmail.Count > 0)
            {
                string resultado = EnviaEmail.EnviaEmail.EnviaMensagemComAnexos(
                    txtEnviarPara.Text,
                    txtEnviadoPor.Text, 
                    txtAssuntoTitulo.Text, 
                    txtMensagem.Text,
                    aAnexosEmail,
                    txtSenha.Text,
                    txtSMTP.Text,
                    Convert.ToInt16(txtPorta.Text),
                    chkAutentica.Checked,
                    chkSSl.Checked,
                    chkTLS.Checked);

                MessageBox.Show(resultado, "Email enviado com sucesso");
            }
            else
            {
                string resultado = EnviaEmail.EnviaEmail.EnviaMensagemEmail(
                    txtEnviarPara.Text,
                    txtEnviadoPor.Text, 
                    txtAssuntoTitulo.Text, 
                    txtMensagem.Text,
                    txtSenha.Text,
                    txtSMTP.Text,
                    Convert.ToInt16(txtPorta.Text),
                    chkAutentica.Checked,
                    chkSSl.Checked,
                    chkTLS.Checked);

                MessageBox.Show(resultado, "Email enviado com sucesso");
            }
        }

        private void cmbMesAno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMesAno.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Selecione um Ano e Mês", "MEGASIM", System.Windows.Forms.MessageBoxButtons.OK, 
                                System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            try
            {
                txtAnexos.Text = txtLocal.Text + cmbMesAno.Text + ".zip";
                Diretorio_Zip_A = txtLocal.Text;
                Diretorio_Zip_A = Diretorio_Zip_A.Substring(0, Diretorio_Zip_A.Length - 2);

                if (File.Exists(txtAnexos.Text))
                {
                    File.Delete(txtAnexos.Text);
                }

                ZipFile.CreateFromDirectory(txtLocal.Text + cmbMesAno.Text, txtLocal.Text + cmbMesAno.Text + ".zip");

                MessageBox.Show($"Compactação da pasta : <<{txtAnexos.Text}>> feita com sucesso...");
                //txtAnexos.Text = txtAnexos.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkAutentica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutentica.Checked)
            {
                chkSSl.Enabled = true;
                chkTLS.Enabled = true;
            }
            else
            {
                chkSSl.Enabled = false;
                chkTLS.Enabled = false;
            }
        }

        private void cmdGravaContador_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Informar email Emitente", "Atenção");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Informar senha Emitente", "Atenção");
            }
            else if (txtContador.Text == "")
            {
                MessageBox.Show("Informar Destinatário/Contador", "Atenção");
            }
            else if (txtSMTP.Text == "")
            {
                MessageBox.Show("Informar SMTP", "Atenção");
            }
            else if (txtPorta.Text == "")
            {
                MessageBox.Show("Informar Porta", "Atenção");
            }
            else
            {
                string Conexao_DB = "Data Source = " + SERVIDOR_MEGASIM + " ;Initial Catalog = " + NOME_BANCO_DADOS + " ; user id = " + USUARIO_ADM_SQLSERVER + " ; password = " + SENHA_ADM_SQLSERVER + " ; MultipleActiveResultSets=True;";
                string strSql;

                SqlConnection sqlConn = new SqlConnection(Conexao_DB);
                sqlConn.Open();

                strSql = "select emailconfig_id from EMAILCONFIG ";
                strSql = strSql + " where estabelecimento_id = " + Estabelecimento_Id_N;

                SqlCommand cmdLer = new SqlCommand(strSql, sqlConn);
                SqlDataReader drLer = cmdLer.ExecuteReader();

                drLer.Read();
                if (drLer.FieldCount > 0)
                {
                    strSql = " update EMAILCONFIG set ";
                        strSql = strSql + " REMETENTE_A = '" + txtEmail.Text + "'";
                        strSql = strSql + ",DESTINATARIO_A = '" + txtContador.Text + "'";
                        strSql = strSql + ",SENHA_EMAIL = '" + txtSenha.Text + "'";
                        strSql = strSql + ",SMTP = '" + txtSMTP.Text + "'";
                        strSql = strSql + ",PORTA = '" + txtPorta.Text + "'";
                        strSql = strSql + ",SSL = '" + chkSSl.Checked + "'";
                        strSql = strSql + ",TLS = '" + chkTLS.Checked + "'";
                    strSql = strSql + " where estabelecimento_id = " + Estabelecimento_Id_N;
                }
                else
                {
                    strSql = " insert into EMAILCONFIG ";
                    strSql = strSql + " (";
                        strSql = strSql + " EMAILCONFIG_ID,ESTABELECIMENTO_ID,REMETENTE_A,DESTINATARIO_A";
                        strSql = strSql + " SENHA_EMAIL,SMTP,PORTA,SSL,TLS";
                    strSql = strSql + " )";
                    strSql = strSql + " (values";
                        strSql = strSql + Estabelecimento_Id_N;
                        strSql = strSql + "," + 1;
                        strSql = strSql + ",'" + txtEmail.Text + "'";
                        strSql = strSql + ",'" + txtContador.Text + "'";
                        strSql = strSql + ",'" + txtSenha.Text + "'";
                        strSql = strSql + ",'" + txtSMTP.Text + "'";
                        strSql = strSql + ",'" + txtPorta.Text + "'";
                        strSql = strSql + ",'" + chkSSl.Checked + "'";
                        strSql = strSql + ",'" + chkTLS.Checked + "'";
                    strSql = strSql + " )";
                }
                drLer.Close();
                cmdLer.Dispose();

                //MessageBox.Show(strSql, "vaca");

                //SqlCommand cmd2 = new SqlCommand(strSql, sqlConn);
                //SqlDataReader dr2 = cmd2.ExecuteReader();

                //dr2.Read();
                //f (dr2.FieldCount > 0)

                SqlCommand cmdGravar = new SqlCommand(strSql,sqlConn);
                cmdGravar.ExecuteNonQuery();

                cmdGravar.Dispose();
                sqlConn.Close();
            }
        }
    }
}
