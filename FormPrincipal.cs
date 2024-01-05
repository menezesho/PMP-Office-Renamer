using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace Renomeador_de_Oficios
{
    public partial class FormPrincipal : Form
    {
        List<Oficio> oficios = new List<Oficio>(); // Lista de ofícios
        Oficio oficioSelecionado = null;
        int? numSequencial = null; // Armazena o número sequencial do ofício

        string diretorioEnviados = $@"\\192.168.0.250\secretarias\Seplan\DPD\DOCUMENTOS DIGITALIZADOS\Ofícios\Ofícios Enviados {DateTime.Now.Year.ToString()}"; // Armazena o diretório de ofícios enviados
        string diretorioRecebidos = $@"\\192.168.0.250\secretarias\Seplan\DPD\DOCUMENTOS DIGITALIZADOS\Ofícios\Ofícios Recebidos {DateTime.Now.Year.ToString()}"; // Armazena o diretório de ofícios recebidos
        string arqDestino; // Armazena o nome do arquivo de destino

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

            string auxNumOficio = mtbNumOficio.Text.Trim(); ; // Variável auxiliar que armazena o valor do campo de numeração do ofício
            string auxNumControle = mtbNumControle.Text.Trim(); ; // Variável auxiliar que armazena o valor do campo de numeração sequencial

            // Este evento ocorre em todas as TextBox e MaskedTextBox do formulário para atualizar o campo de resultado
            if (mtbNumOficio.Text.Trim().Length == 2) // Verifica se o campo de numeração do ofício possui menos de 3 caracteres, são os zeros a esquerda
            {
                auxNumOficio = "0" + mtbNumOficio.Text.Trim();
            }
            else if (mtbNumOficio.Text.Trim().Length == 1)
            {
                auxNumOficio = "00" + mtbNumOficio.Text.Trim();
            }

            if (mtbNumControle.Enabled)
            {
                if (mtbNumControle.Text.Trim().Length == 2) // Verifica se o campo de numeração sequencial possui menos de 3 caracteres, são os zeros a esquerda
                {
                    auxNumControle = "0" + mtbNumControle.Text.Trim();
                }
                else if (mtbNumControle.Text.Trim().Length == 1)
                {
                    auxNumControle = "00" + mtbNumControle.Text.Trim();
                }
            }

            if (rbtEnviados.Checked == true)
                txtResultado.Text = $"{auxNumOficio} - {txtSetor.Text}";
            else
                txtResultado.Text = $"{auxNumControle} - {auxNumOficio} {txtSetor.Text}";
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

                    if (rbtRecebidos.Checked)
                        pegarNumeroSequencialDoOficio();// Chama a função que pega o número sequencial dos oficios recebidos


                    //desabilitarCampos();
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
            
            string arqOrigem = Path.GetFileName(oficioSelecionado.Caminho); // Armazena o nome do arquivo selecionado
            arqDestino = null; // Variável que armazena o nome do arquivo de destino

            if (mtbNumOficio.Text.Trim().Length == 2 ) // Verifica se o campo de numeração do ofício possui menos de 3 caracteres, são os zeros a esquerda
            {
                mtbNumOficio.Text = "0" + mtbNumOficio.Text.Trim();
            }
            else if (mtbNumOficio.Text.Trim().Length == 1)
            {
                mtbNumOficio.Text = "00" + mtbNumOficio.Text.Trim();
            }


            if(mtbNumControle.Text.Trim().Length == 2 && mtbNumControle.Enabled)
            {
                mtbNumControle.Text = "0" + mtbNumControle.Text.Trim();
            }
            else if (mtbNumControle.Text.Trim().Length == 1 && mtbNumControle.Enabled)
            {
                mtbNumControle.Text = "00" + mtbNumControle.Text.Trim();
            }

            arqDestino = Path.GetFileName(txtResultado.Text);

            // Verifica se o arquivo de destino já existe
            if (arqDestino == arqOrigem)
            {
                MessageBox.Show("O novo nome deve ser diferente do anterior!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                moverArquivo();// Chama a função que move o arquivo para a pasta de enviados ou recebidos e o renomeia

                MessageBox.Show("Arquivo renomeado com sucesso!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                incrementarNumeracao(); // Chama a função que incrementa a numeração sequencial caso seja um ofício "Enviado"

                removerOficioRenomeado(); // Chama a função que remove o ofício da lista de ofícios

                mtbNumOficio.Clear();
                txtSetor.Clear();
                mtbNumOficio.Focus();

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
            if (rbtRecebidos.Checked)
            {
                int auxNumSeq = int.Parse(mtbNumControle.Text.Trim()); // Variável auxiliar que armazena o valor do campo de numeração sequencial
                auxNumSeq += 1; // Incrementa o valor da variável auxiliar

                // Se o numero tiver 3 digitos não adiciona o zero a esquerda
                if (mtbNumControle.Text.Trim().Length == 3)
                    mtbNumControle.Text = auxNumSeq.ToString();
                else // Caso contrário, adiciona o zero a esquerda
                {
                    if(mtbNumControle.Text.Trim().Length == 2)
                        mtbNumControle.Text = "0" + auxNumSeq.ToString();
                    else if (mtbNumControle.Text.Trim().Length == 1)
                        mtbNumControle.Text = "00" + auxNumSeq.ToString();
                }
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

        private void moverArquivo()
        {
            try
            {
                if (rbtEnviados.Checked == true) // Verifica se o checkbox "Enviados" está marcado
                {
                    if (!Directory.Exists(diretorioEnviados)) // Verifica se o diretório de enviados existe, se não, cria o diretório
                    {
                        Directory.CreateDirectory(diretorioEnviados);// Cria o diretório de enviados
                    }

                    File.Move(oficioSelecionado.Caminho, $@"{diretorioEnviados}\{Path.GetFileName(arqDestino)}.pdf"); //renomeia e move o arquivo para a pasta de enviados
                }

                if (rbtRecebidos.Checked == true) // Verifica se o checkbox "Recebidos" está marcado
                {
                    if (!Directory.Exists(diretorioRecebidos))// Verifica se o diretório de recebidos existe, se não, cria o diretório
                    {
                        Directory.CreateDirectory(diretorioRecebidos);// Cria o diretório de recebidos
                    }

                    File.Move(oficioSelecionado.Caminho, $@"{diretorioRecebidos}\{Path.GetFileName(arqDestino)}.pdf");//renomeia e move o arquivo para a pasta de recebidos
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                MessageBox.Show("Erro ao mover o arquivo para o servidor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pegarNumeroSequencialDoOficio()
        {
            try
            {
                string[] arquivos = Directory.GetFiles(diretorioRecebidos, "*.pdf"); // Pega todos os arquivos PDF do diretório de recebidos

                numSequencial = arquivos.Length + 1; // Pega o número sequencial do ofício

                if (numSequencial != null) //formata o número sequencial do ofício para ter 3 digitos
                {
                    if (numSequencial.ToString().Length == 3)
                        mtbNumControle.Text = numSequencial.ToString();
                    else if (numSequencial.ToString().Length == 2)
                        mtbNumControle.Text = "0" + numSequencial.ToString();
                    else if (numSequencial.ToString().Length == 1)
                        mtbNumControle.Text = "00" + numSequencial.ToString();
                }

                //mtbNumControle.Enabled = false; 

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                MessageBox.Show("Erro ao pegar o número sequencial do ofício!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void ListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            
            var listBox = (ListBox)sender; // Obtém a ListBox associada ao evento
            
            var item = (Oficio)listBox.Items[e.Index]; // Obtém o item associado ao índice

            Font fonte = e.Font; // Obtém a fonte padrão da ListBox
            Color corFundo = e.BackColor; // Obtém a cor de fundo padrão
            Color corTexto = e.ForeColor; // Obtém a cor do texto padrão

            // Verifica se o item está selecionado
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                corFundo = Color.FromArgb(63, 80, 97); // Altera a cor de fundo do item selecionado
                corTexto = Color.White; // Altera a cor do texto do item selecionado
            }

            // Cria um pincel para a cor de fundo
            using (var pincelFundo = new SolidBrush(corFundo))
            {
                e.Graphics.FillRectangle(pincelFundo, e.Bounds);// Pinta o fundo do item
            }

            // Cria um pincel para a cor do texto
            using (var pincelTexto = new SolidBrush(corTexto))
            {
                e.Graphics.DrawString(item.Nome, fonte, pincelTexto, e.Bounds, StringFormat.GenericDefault); // Desenha o texto do item
            }

            e.DrawFocusRectangle(); // Desenha a borda ao redor do item
        }
    }
}
