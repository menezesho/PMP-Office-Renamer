namespace oficios
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btRenomear = new System.Windows.Forms.Button();
            this.tbArquivoSelecionado = new System.Windows.Forms.TextBox();
            this.lbArquivo = new System.Windows.Forms.Label();
            this.lbNumSeq = new System.Windows.Forms.Label();
            this.tbSetor = new System.Windows.Forms.TextBox();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbNumOficio = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.pdf = new PdfiumViewer.PdfViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNumOficio = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumSeq = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ofícioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 29);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            this.arquivoToolStripMenuItem.MouseEnter += new System.EventHandler(this.allToolStripMenuItem_MouseEnter);
            this.arquivoToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            this.abrirToolStripMenuItem.MouseEnter += new System.EventHandler(this.allToolStripMenuItem_MouseEnter);
            this.abrirToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            this.sairToolStripMenuItem.MouseEnter += new System.EventHandler(this.allToolStripMenuItem_MouseEnter);
            this.sairToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // ofícioToolStripMenuItem
            // 
            this.ofícioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recebidosToolStripMenuItem,
            this.enviadosToolStripMenuItem});
            this.ofícioToolStripMenuItem.Name = "ofícioToolStripMenuItem";
            this.ofícioToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.ofícioToolStripMenuItem.Text = "&Ofício";
            this.ofícioToolStripMenuItem.MouseEnter += new System.EventHandler(this.allToolStripMenuItem_MouseEnter);
            this.ofícioToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // recebidosToolStripMenuItem
            // 
            this.recebidosToolStripMenuItem.Checked = true;
            this.recebidosToolStripMenuItem.CheckOnClick = true;
            this.recebidosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recebidosToolStripMenuItem.Name = "recebidosToolStripMenuItem";
            this.recebidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.recebidosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.recebidosToolStripMenuItem.Text = "Recebidos";
            this.recebidosToolStripMenuItem.Click += new System.EventHandler(this.recebidosToolStripMenuItem_Click);
            // 
            // enviadosToolStripMenuItem
            // 
            this.enviadosToolStripMenuItem.CheckOnClick = true;
            this.enviadosToolStripMenuItem.Name = "enviadosToolStripMenuItem";
            this.enviadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.enviadosToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.enviadosToolStripMenuItem.Text = "Enviados";
            this.enviadosToolStripMenuItem.Click += new System.EventHandler(this.enviadosToolStripMenuItem_Click);
            this.enviadosToolStripMenuItem.MouseEnter += new System.EventHandler(this.allToolStripMenuItem_MouseEnter);
            this.enviadosToolStripMenuItem.MouseLeave += new System.EventHandler(this.allToolStripMenuItem_MouseLeave);
            // 
            // btRenomear
            // 
            this.btRenomear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btRenomear.BackColor = System.Drawing.Color.Gainsboro;
            this.btRenomear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRenomear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRenomear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenomear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btRenomear.Location = new System.Drawing.Point(204, 499);
            this.btRenomear.Name = "btRenomear";
            this.btRenomear.Size = new System.Drawing.Size(179, 35);
            this.btRenomear.TabIndex = 5;
            this.btRenomear.Text = "&RENOMEAR";
            this.btRenomear.UseVisualStyleBackColor = false;
            this.btRenomear.Click += new System.EventHandler(this.btRenomear_Click);
            // 
            // tbArquivoSelecionado
            // 
            this.tbArquivoSelecionado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbArquivoSelecionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArquivoSelecionado.Enabled = false;
            this.tbArquivoSelecionado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArquivoSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbArquivoSelecionado.Location = new System.Drawing.Point(85, 170);
            this.tbArquivoSelecionado.MaxLength = 100;
            this.tbArquivoSelecionado.Name = "tbArquivoSelecionado";
            this.tbArquivoSelecionado.Size = new System.Drawing.Size(416, 33);
            this.tbArquivoSelecionado.TabIndex = 0;
            this.tbArquivoSelecionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbArquivo
            // 
            this.lbArquivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbArquivo.AutoSize = true;
            this.lbArquivo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbArquivo.Location = new System.Drawing.Point(197, 142);
            this.lbArquivo.Name = "lbArquivo";
            this.lbArquivo.Size = new System.Drawing.Size(192, 25);
            this.lbArquivo.TabIndex = 4;
            this.lbArquivo.Text = "Arquivo selecionado:";
            // 
            // lbNumSeq
            // 
            this.lbNumSeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNumSeq.AutoSize = true;
            this.lbNumSeq.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumSeq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbNumSeq.Location = new System.Drawing.Point(80, 262);
            this.lbNumSeq.Name = "lbNumSeq";
            this.lbNumSeq.Size = new System.Drawing.Size(161, 25);
            this.lbNumSeq.TabIndex = 5;
            this.lbNumSeq.Text = "Num. sequencial:";
            // 
            // tbSetor
            // 
            this.tbSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSetor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSetor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbSetor.Location = new System.Drawing.Point(252, 338);
            this.tbSetor.MaxLength = 70;
            this.tbSetor.Name = "tbSetor";
            this.tbSetor.Size = new System.Drawing.Size(249, 33);
            this.tbSetor.TabIndex = 3;
            this.tbSetor.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // lbSetor
            // 
            this.lbSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSetor.AutoSize = true;
            this.lbSetor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbSetor.Location = new System.Drawing.Point(179, 340);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(62, 25);
            this.lbSetor.TabIndex = 9;
            this.lbSetor.Text = "Setor:";
            // 
            // lbNumOficio
            // 
            this.lbNumOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNumOficio.AutoSize = true;
            this.lbNumOficio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOficio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbNumOficio.Location = new System.Drawing.Point(121, 301);
            this.lbNumOficio.Name = "lbNumOficio";
            this.lbNumOficio.Size = new System.Drawing.Size(117, 25);
            this.lbNumOficio.TabIndex = 10;
            this.lbNumOficio.Text = "Núm. ofício:";
            // 
            // lbResultado
            // 
            this.lbResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lbResultado.Location = new System.Drawing.Point(242, 427);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(103, 25);
            this.lbResultado.TabIndex = 12;
            this.lbResultado.Text = "Resultado:";
            // 
            // tbResultado
            // 
            this.tbResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultado.Enabled = false;
            this.tbResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tbResultado.Location = new System.Drawing.Point(85, 455);
            this.tbResultado.MaxLength = 100;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(416, 33);
            this.tbResultado.TabIndex = 4;
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pdf
            // 
            this.pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pdf.Location = new System.Drawing.Point(615, 28);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(584, 634);
            this.pdf.TabIndex = 13;
            this.pdf.TabStop = false;
            this.pdf.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitBest;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(612, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "      ";
            // 
            // mtbNumOficio
            // 
            this.mtbNumOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbNumOficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumOficio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumOficio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbNumOficio.HidePromptOnLeave = true;
            this.mtbNumOficio.Location = new System.Drawing.Point(252, 299);
            this.mtbNumOficio.Mask = "000";
            this.mtbNumOficio.Name = "mtbNumOficio";
            this.mtbNumOficio.Size = new System.Drawing.Size(59, 33);
            this.mtbNumOficio.TabIndex = 2;
            this.mtbNumOficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumOficio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumOficio.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // mtbNumSeq
            // 
            this.mtbNumSeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbNumSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumSeq.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumSeq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.mtbNumSeq.HidePromptOnLeave = true;
            this.mtbNumSeq.Location = new System.Drawing.Point(252, 260);
            this.mtbNumSeq.Mask = "000";
            this.mtbNumSeq.Name = "mtbNumSeq";
            this.mtbNumSeq.Size = new System.Drawing.Size(59, 33);
            this.mtbNumSeq.TabIndex = 1;
            this.mtbNumSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumSeq.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumSeq.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.btRenomear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 674);
            this.Controls.Add(this.mtbNumSeq);
            this.Controls.Add(this.mtbNumOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.lbNumOficio);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.tbSetor);
            this.Controls.Add(this.lbNumSeq);
            this.Controls.Add(this.lbArquivo);
            this.Controls.Add(this.tbArquivoSelecionado);
            this.Controls.Add(this.btRenomear);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1215, 713);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomear Ofícios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btRenomear;
        private System.Windows.Forms.TextBox tbArquivoSelecionado;
        private System.Windows.Forms.Label lbArquivo;
        private System.Windows.Forms.Label lbNumSeq;
        private System.Windows.Forms.TextBox tbSetor;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbNumOficio;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox tbResultado;
        private PdfiumViewer.PdfViewer pdf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem ofícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recebidosToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mtbNumOficio;
        private System.Windows.Forms.MaskedTextBox mtbNumSeq;
    }
}

