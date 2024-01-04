using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Renomeador_de_Oficios
{
    public partial class FormPrincipal : Form
    {
        List<Oficio> oficios = new List<Oficio>(); // Lista de ofícios
        Oficio oficioSelecionado = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            rbtRecebidos.Checked = true; // Inicia com o checkbox de recebidos marcado

            // Verifica se o checkbox de recebidos está marcado, se sim, desabilita o campo de numeração sequencial
            if (rbtEnviados.Checked)
                mtbNumControle.Enabled = false;

            desabilitarCampos();
        }

        #region Chenged

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Percorre todos os ofícios da lista
            if (lstOficios.SelectedValue != null)
            {
                foreach (var oficio in oficios)
                {
                    // Verifica se o ofício selecionado é igual ao ofício da lista
                    if (oficio.Id != 0)
                    {
                        if (oficio.Id == int.Parse(lstOficios.SelectedValue.ToString()))
                        {
                            openFile(oficio);

                            oficioSelecionado = new Oficio();
                            oficioSelecionado.Id = oficio.Id;
                            oficioSelecionado.Nome = txtArquivoSelecionado.Text = oficio.Nome;
                            oficioSelecionado.Caminho = oficio.Caminho;
                            break;
                        }
                    }
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            txtResultado.Clear();
            mtbNumControle.Clear();
            mtbNumOficio.Clear();
            txtSetor.Clear();

            if (oficioSelecionado != null)
            {
                if (rbtRecebidos.Checked)
                {
                    mtbNumControle.Enabled = true;
                }
                else if (rbtEnviados.Checked)
                {
                    mtbNumControle.Enabled = false;
                    mtbNumControle.Clear();
                }
            }
        }

        private void allTextBox_TextChanged(object sender, EventArgs e)
        {
            // Este evento ocorre em todas as TextBox e MaskedTextBox do formulário para atualizar o campo de resultado

            if (rbtEnviados.Checked == true)
                txtResultado.Text = $"{mtbNumOficio.Text} - {txtSetor.Text}";
            else
                txtResultado.Text = $"{mtbNumControle.Text} - {mtbNumOficio.Text} {txtSetor.Text}";
        }

        #endregion

        #region Botões

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // Abre a janela de seleção de arquivos
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione os ofícios";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";

            try
            {
                // Caso o usuário clique em OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    limparLista();

                    int indice = 0;

                    // Percorre todos os arquivos selecionados
                    foreach (var arquivo in openFileDialog.FileNames)
                    {
                        Oficio oficio = new Oficio();
                        oficio.Id = indice + 1;
                        oficio.Nome = Path.GetFileName(arquivo); // Pega o nome do arquivo
                        oficio.Caminho = arquivo;

                        oficios.Add(oficio); // Adiciona o ofício na lista
                        indice++;
                    }

                    lstOficios.DataSource = oficios; // Carrega a lista de ofícios no componente ListBox

                    desabilitarCampos();
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro);
                MessageBox.Show("Erro ao renomear os arquivos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparLista_Click(object sender, EventArgs e)
        {
            limparLista();
        }

        private void lbLimparArquivo_Click(object sender, EventArgs e)
        {
            lstOficios.ClearSelected();
            desabilitarCampos();
        }

        private void btRenomear_Click(object sender, EventArgs e)
        {
            #region Verificações

            // Caso a origem esteja vazia, exibe uma mensagem de erro
            if (oficioSelecionado == null)
            {
                MessageBox.Show("Nenhum ofício foi selecionado!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se todas as informações foram preenchidas
            if (string.IsNullOrEmpty(txtSetor.Text) || string.IsNullOrEmpty(mtbNumOficio.Text) || (mtbNumControle.Enabled && string.IsNullOrEmpty(mtbNumControle.Text)))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            try
            {
                // Verifica se os campos numéricos foram preenchidos corretamente
                int? testeNumOficio = string.IsNullOrEmpty(mtbNumOficio.Text) ? null : (int?)int.Parse(mtbNumOficio.Text);
                int? testeCodSeq = string.IsNullOrEmpty(mtbNumControle.Text) ? null : (int?)int.Parse(mtbNumControle.Text);
            }
            catch
            {
                MessageBox.Show("Verifique se os campos numéricos foram preenchidos corretamente!", "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string diretorio = Path.GetDirectoryName(oficioSelecionado.Caminho); // Armazena o diretório do arquivo selecionado
            string arqOrigem = Path.GetFileName(oficioSelecionado.Caminho); // Armazena o nome do arquivo selecionado
            string arqDestino = null; // Variável que armazena o nome do arquivo de destino

            // Caso o checkbox "Enviados" esteja marcado
            if (rbtEnviados.Checked)
                arqDestino = Path.GetFileName($"{mtbNumOficio.Text} - {txtSetor.Text}");

            // Caso o checkbox "Recebidos" esteja marcado
            else if (rbtRecebidos.Checked)
                arqDestino = Path.GetFileName($"{mtbNumControle.Text} - {mtbNumOficio.Text} - {txtSetor.Text}");

            // Verifica se o arquivo de destino já existe
            if (arqDestino == arqOrigem)
            {
                MessageBox.Show("O novo nome deve ser diferente do anterior!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                File.Move(oficioSelecionado.Caminho, $@"{diretorio}\{arqDestino}.pdf"); // Renomeia o arquivo

                MessageBox.Show("Arquivo renomeado com sucesso!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Information);

                incrementarNumeracao(); // Chama a função que incrementa a numeração sequencial caso seja um ofício "Enviado"

                removerOficioRenomeado(); // Chama a função que remove o ofício da lista de ofícios

                desabilitarCampos(); // Chama a função que desabilita os campos do formulário
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro);
                MessageBox.Show("Erro ao renomear ofício!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion

        #region Funções

        private void openFile(Oficio oficio)
        {
            try
            {
                string caminhoArquivo = oficio.Caminho; // Pega o caminho do arquivo
                byte[] bytes = System.IO.File.ReadAllBytes(caminhoArquivo); // Lê o arquivo selecionado e armazena em um array de bytes
                var stream = new System.IO.MemoryStream(bytes); // Cria um stream de memória para armazenar o array de bytes
                PdfDocument documentoPdf = PdfDocument.Load(stream); // Carrega o arquivo PDF no stream de memória
                pdfViewer.Document = documentoPdf; // Carrega o arquivo PDF no componente pdf

                habilitarCampos();
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro);
                MessageBox.Show("Erro ao abrir o arquivo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void incrementarNumeracao()
        {
            // Caso o checkbox "Enviados" esteja marcado
            if (rbtRecebidos.Checked)
            {
                int auxNumSeq = int.Parse(mtbNumControle.Text); // Variável auxiliar que armazena o valor do campo de numeração sequencial
                auxNumSeq += 1; // Incrementa o valor da variável auxiliar

                // Verifica se o valor da variável auxiliar é maior ou igual a 99, se sim, atribui o valor da variável auxiliar ao campo de numeração sequencial
                if (int.Parse(mtbNumControle.Text) >= 99)
                    mtbNumControle.Text = auxNumSeq.ToString();
                else
                    mtbNumControle.Text = "0" + auxNumSeq.ToString();
            }
        }

        private void removerOficioRenomeado()
        {
            foreach (var oficio in oficios)
            {
                if (oficio.Id == int.Parse(lstOficios.SelectedValue.ToString()))
                {
                    oficios.Remove(oficio);
                    break;
                }
            }

            lstOficios.DataSource = null; // Limpa o ListBox de ofícios

            lstOficios.DataSource = oficios; // Recarrega a lista de ofícios no componente ListBox
            lstOficios.DisplayMember = "Nome"; // Define o campo que será exibido no ListBox
            lstOficios.ValueMember = "Id"; // Define o campo que será usado para identificar o objeto selecionado
        }

        private void habilitarCampos()
        {
            pbxBrasao.Visible = false;
            pdfViewer.Visible = true;
            mtbNumOficio.Enabled = true;
            txtSetor.Enabled = true;

            if (rbtRecebidos.Checked)
                mtbNumControle.Enabled = true;
        }

        private void desabilitarCampos()
        {
            pdfViewer.Visible = false;
            pbxBrasao.Visible = true;
            mtbNumOficio.Enabled = false;
            txtSetor.Enabled = false;

            mtbNumControle.Enabled = false;

            mtbNumOficio.Clear();
            txtSetor.Clear();
            txtResultado.Clear();
            txtArquivoSelecionado.Clear();
            lstOficios.ClearSelected();

            if (!mtbNumControle.Enabled)
                mtbNumControle.Clear();

            oficioSelecionado = null;
        }

        private void limparLista()
        {
            lstOficios.DataSource = null; // Limpa o ListBox de ofícios
            lstOficios.DisplayMember = "Nome"; // Define o campo que será exibido no ListBox
            lstOficios.ValueMember = "Id"; // Define o campo que será usado para identificar o objeto selecionado

            oficios = new List<Oficio>(); // Limpa a lista de ofícios
            oficioSelecionado = null; // Limpa o objeto de ofício selecionado
            txtArquivoSelecionado.Clear();

            desabilitarCampos();
        }

        #endregion
    }
}
