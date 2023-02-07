using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oficios
{
    public partial class FormPrincipal : Form
    {
        //PdfiumViewer.PdfViewer pdf;
        string origem = "";

        public FormPrincipal()
        {
            InitializeComponent();
            //pdf = new PdfViewer();
            //this.Controls.Add(pdf);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if(enviadosToolStripMenuItem.Checked == true)
                mtbNumSeq.Enabled = false;
        }

        #region Funções
        public void renomearArquivo(string origem)
        {
            if (origem == "")
            {
                MessageBox.Show("Selecione o arquivo que deseja renomear!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                #region Verificação de espaços

                try
                {
                    if (mtbNumOficio.Text != "")
                    {
                        int testeNumOficio = int.Parse(mtbNumOficio.Text);
                    }
                    if (mtbNumSeq.Text != "")
                    {
                        int testeCodSeq = int.Parse(mtbNumSeq.Text);
                    }
                }
                catch
                {
                    MessageBox.Show("Verifique se os campos numéricos foram preenchidos corretamente!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                #endregion

                var diretorio = Path.GetDirectoryName(origem);
                var arqOrigem = Path.GetFileName(origem);
                var arqDestino = "";
                if (enviadosToolStripMenuItem.Checked == true)
                {
                    arqDestino = Path.GetFileName(mtbNumOficio.Text + " - " + tbSetor.Text);
                }
                else
                {
                    arqDestino = Path.GetFileName(mtbNumSeq.Text + " - " + mtbNumOficio.Text + " " + tbSetor.Text);
                }

                if (mtbNumOficio.Text == "" || mtbNumOficio.Text == "" || (mtbNumSeq.Enabled == true && mtbNumSeq.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos para renomear o arquivo!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (arqDestino == arqOrigem)
                {
                    MessageBox.Show("O novo nome deve ser diferente do anterior!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        File.Move(origem, diretorio + "\\" + arqDestino + ".pdf");
                        MessageBox.Show("Arquivo renomeado com sucesso!", "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtbNumSeq.Clear();
                        mtbNumOficio.Clear();
                        tbSetor.Clear();
                        tbResultado.Clear();
                        tbArquivoSelecionado.Clear();
                        mtbNumSeq.Focus();
                        this.origem = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex, "Renomear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void openFile(string filepath)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new System.IO.MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

        #endregion

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {//abrirClick
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                openFile(ofd.FileName);
            origem = ofd.FileName;
            tbArquivoSelecionado.Text = Path.GetFileName(origem);

        }

        private void btRenomear_Click(object sender, EventArgs e)
        {//btRenomear
            renomearArquivo(origem);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//btSair
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void allTextBox_TextChanged(object sender, EventArgs e)
        {
            if (enviadosToolStripMenuItem.Checked == true)
                tbResultado.Text = mtbNumOficio.Text + " - " + tbSetor.Text;
            else
                tbResultado.Text = mtbNumSeq.Text + " - " + mtbNumOficio.Text + " " + tbSetor.Text;
        }

        private void enviadosToolStripMenuItem_Click(object sender, EventArgs e)
        {//enviadosClick
            recebidosToolStripMenuItem.Checked = false;
            mtbNumSeq.Enabled = false;
            mtbNumSeq.Clear();
        }

        private void recebidosToolStripMenuItem_Click(object sender, EventArgs e)
        {//recebidosClick
            enviadosToolStripMenuItem.Checked = false;
            mtbNumSeq.Enabled = true;
        }

        #region Cursor

        private void allToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void allToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        #endregion

    }
}
