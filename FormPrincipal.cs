using PdfiumViewer;
using System;
using System.IO;
using System.Windows.Forms;

namespace oficios
{
    public partial class FormPrincipal : Form
    {
        string origem = null; // Variável que armazena o caminho do arquivo selecionado

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            checkRecebidos.Checked = true; // Inicia com o checkbox de recebidos marcado

            // Verifica se o checkbox de recebidos está marcado, se sim, desabilita o campo de numeração sequencial
            if (checkEnviados.Checked)
                mtbNumSeq.Enabled = false;
        }

        #region Botões

        private void btAbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // Cria um objeto do tipo OpenFileDialog

            try
            {
                // Caso o usuário clique em OK, abre o arquivo selecionado
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    origem = ofd.FileName; // Armazena o caminho do arquivo selecionado na variável origem

                    // Verifica se o arquivo selecionado é um arquivo PDF
                    if (origem.Contains(".pdf"))
                    {
                        openFile(ofd.FileName); // Chama a função openFile passando o caminho do arquivo selecionado
                        tbArquivoSelecionado.Text = Path.GetFileName(origem);
                    }
                    else
                    {
                        MessageBox.Show("Formato de arquivo inválido!\nO arquivo selecionado deve ser do tipo PDF (.pdf).", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        origem = null;
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Formato de arquivo inválido!\nO arquivo selecionado deve ser do tipo PDF (.pdf).", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                origem = null;
                return;
            }
        }

        private void lbLimparArquivo_Click(object sender, EventArgs e)
        {
            tbArquivoSelecionado.Clear();
            origem = null;
        }

        private void btRenomear_Click(object sender, EventArgs e)
        {
            #region Verificações


            // Caso a origem esteja vazia, exibe uma mensagem de erro
            if (origem == null)
            {
                MessageBox.Show("Nenhum arquivo foi selecionado!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se todas as informações foram preenchidas
            if (string.IsNullOrEmpty(tbSetor.Text) || string.IsNullOrEmpty(mtbNumOficio.Text) || (mtbNumSeq.Enabled && string.IsNullOrEmpty(mtbNumSeq.Text)))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            try
            {
                // Verifica se os campos numéricos foram preenchidos corretamente
                int? testeNumOficio = string.IsNullOrEmpty(mtbNumOficio.Text) ? null : (int?)int.Parse(mtbNumOficio.Text);
                int? testeCodSeq = string.IsNullOrEmpty(mtbNumSeq.Text) ? null : (int?)int.Parse(mtbNumSeq.Text);

                //if (!string.IsNullOrEmpty(mtbNumOficio.Text))
                //{
                //    int testeNumOficio = int.Parse(mtbNumOficio.Text);
                //}
                //if (mtbNumSeq.Text != "")
                //{
                //    int testeCodSeq = int.Parse(mtbNumSeq.Text);
                //}
            }
            catch
            {
                MessageBox.Show("Verifique se os campos numéricos foram preenchidos corretamente!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string diretorio = Path.GetDirectoryName(origem); // Armazena o diretório do arquivo selecionado
            string arqOrigem = Path.GetFileName(origem); // Armazena o nome do arquivo selecionado
            string arqDestino = null; // Variável que armazena o nome do arquivo de destino

            // Caso o checkbox "Enviados" esteja marcado
            if (checkEnviados.Checked)
                arqDestino = Path.GetFileName($"{mtbNumOficio.Text} - {tbSetor.Text}");

            // Caso o checkbox "Recebidos" esteja marcado
            else if (checkRecebidos.Checked)
                arqDestino = Path.GetFileName($"{mtbNumSeq.Text} - {mtbNumOficio.Text} - {tbSetor.Text}");

            // Verifica se o arquivo de destino já existe
            if (arqDestino == arqOrigem)
            {
                MessageBox.Show("O novo nome deve ser diferente do anterior!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                File.Move(origem, $@"{diretorio}\{arqDestino}.pdf"); // Renomeia o arquivo
                MessageBox.Show("Arquivo renomeado com sucesso!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Caso o checkbox "Enviados" esteja marcado
                if (checkRecebidos.Checked)
                {
                    int auxNumSeq = int.Parse(mtbNumSeq.Text); // Variável auxiliar que armazena o valor do campo de numeração sequencial
                    auxNumSeq += 1; // Incrementa o valor da variável auxiliar

                    // Verifica se o valor da variável auxiliar é maior ou igual a 99, se sim, atribui o valor da variável auxiliar ao campo de numeração sequencial
                    if (int.Parse(mtbNumSeq.Text) >= 99)
                        mtbNumSeq.Text = auxNumSeq.ToString();
                    else 
                        mtbNumSeq.Text = "0" + auxNumSeq.ToString();
                }

                mtbNumOficio.Clear();
                tbSetor.Clear();
                tbResultado.Clear();
                tbArquivoSelecionado.Clear();
                origem = null;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro, "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Checkboxes

        private void checkEnviados_Click(object sender, EventArgs e)
        {
            checkRecebidos.Checked = false;
            checkEnviados.Checked = true;
            mtbNumSeq.Enabled = false;
            mtbNumSeq.Clear();
        }

        private void checkRecebidos_Click(object sender, EventArgs e)
        {
            checkEnviados.Checked = false;
            checkRecebidos.Checked = true;
            mtbNumSeq.Enabled = true;
        }
        
        #endregion

        #region Funções

        private void allTextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkEnviados.Checked == true)
                tbResultado.Text = $"{mtbNumOficio.Text} - {tbSetor.Text}";
            else
                tbResultado.Text = $"{mtbNumSeq.Text} - {mtbNumOficio.Text} {tbSetor.Text}";
        }

        public void openFile(string caminhoArquivo)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(caminhoArquivo); // Lê o arquivo selecionado e armazena em um array de bytes
            var stream = new System.IO.MemoryStream(bytes); // Cria um stream de memória para armazenar o array de bytes
            PdfDocument documentoPdf = PdfDocument.Load(stream); // Carrega o arquivo PDF no stream de memória
            pdf.Document = documentoPdf; // Carrega o arquivo PDF no componente pdf
        }

        #endregion
    }
}
