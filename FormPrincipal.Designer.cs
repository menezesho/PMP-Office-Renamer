namespace Renomeador_de_Oficios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btRenomear = new System.Windows.Forms.Button();
            this.txtArquivoSelecionado = new System.Windows.Forms.TextBox();
            this.lblArquivoSelecionado = new System.Windows.Forms.Label();
            this.lblNumControle = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.lblNumOficio = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNumOficio = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumControle = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.lblLimparArquivo = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.rbtRecebidos = new System.Windows.Forms.RadioButton();
            this.rbtEnviados = new System.Windows.Forms.RadioButton();
            this.lstOficios = new System.Windows.Forms.ListBox();
            this.pbxBrasao = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrasao)).BeginInit();
            this.SuspendLayout();
            // 
            // btRenomear
            // 
            this.btRenomear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRenomear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btRenomear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRenomear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btRenomear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRenomear.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenomear.ForeColor = System.Drawing.Color.White;
            this.btRenomear.Location = new System.Drawing.Point(180, 521);
            this.btRenomear.Name = "btRenomear";
            this.btRenomear.Size = new System.Drawing.Size(179, 35);
            this.btRenomear.TabIndex = 11;
            this.btRenomear.Text = "&Renomear ✓";
            this.ttInfo.SetToolTip(this.btRenomear, "Renomear ofício");
            this.btRenomear.UseVisualStyleBackColor = false;
            this.btRenomear.Click += new System.EventHandler(this.btRenomear_Click);
            // 
            // txtArquivoSelecionado
            // 
            this.txtArquivoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtArquivoSelecionado.BackColor = System.Drawing.Color.White;
            this.txtArquivoSelecionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArquivoSelecionado.Enabled = false;
            this.txtArquivoSelecionado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivoSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.txtArquivoSelecionado.Location = new System.Drawing.Point(12, 256);
            this.txtArquivoSelecionado.MaxLength = 100;
            this.txtArquivoSelecionado.Name = "txtArquivoSelecionado";
            this.txtArquivoSelecionado.Size = new System.Drawing.Size(515, 29);
            this.txtArquivoSelecionado.TabIndex = 3;
            this.txtArquivoSelecionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblArquivoSelecionado
            // 
            this.lblArquivoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArquivoSelecionado.AutoSize = true;
            this.lblArquivoSelecionado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArquivoSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lblArquivoSelecionado.Location = new System.Drawing.Point(189, 232);
            this.lblArquivoSelecionado.Name = "lblArquivoSelecionado";
            this.lblArquivoSelecionado.Size = new System.Drawing.Size(160, 21);
            this.lblArquivoSelecionado.TabIndex = 4;
            this.lblArquivoSelecionado.Text = "Arquivo selecionado";
            this.lblArquivoSelecionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumControle
            // 
            this.lblNumControle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumControle.AutoSize = true;
            this.lblNumControle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumControle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lblNumControle.Location = new System.Drawing.Point(20, 386);
            this.lblNumControle.Name = "lblNumControle";
            this.lblNumControle.Size = new System.Drawing.Size(94, 21);
            this.lblNumControle.TabIndex = 5;
            this.lblNumControle.Text = "N° controle";
            // 
            // txtSetor
            // 
            this.txtSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSetor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSetor.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.txtSetor.Location = new System.Drawing.Point(244, 410);
            this.txtSetor.MaxLength = 70;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(283, 29);
            this.txtSetor.TabIndex = 9;
            this.txtSetor.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // lblSetor
            // 
            this.lblSetor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lblSetor.Location = new System.Drawing.Point(360, 386);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(50, 21);
            this.lblSetor.TabIndex = 9;
            this.lblSetor.Text = "Setor";
            // 
            // lblNumOficio
            // 
            this.lblNumOficio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumOficio.AutoSize = true;
            this.lblNumOficio.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOficio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lblNumOficio.Location = new System.Drawing.Point(146, 386);
            this.lblNumOficio.Name = "lblNumOficio";
            this.lblNumOficio.Size = new System.Drawing.Size(74, 21);
            this.lblNumOficio.TabIndex = 10;
            this.lblNumOficio.Text = "N° ofício";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lblResultado.Location = new System.Drawing.Point(228, 442);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(83, 21);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.txtResultado.Location = new System.Drawing.Point(12, 466);
            this.txtResultado.MaxLength = 100;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(515, 29);
            this.txtResultado.TabIndex = 10;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pdfViewer
            // 
            this.pdfViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer.Location = new System.Drawing.Point(536, -1);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(663, 572);
            this.pdfViewer.TabIndex = 12;
            this.pdfViewer.TabStop = false;
            this.pdfViewer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(533, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "      ";
            // 
            // mtbNumOficio
            // 
            this.mtbNumOficio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtbNumOficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumOficio.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumOficio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.mtbNumOficio.HidePromptOnLeave = true;
            this.mtbNumOficio.Location = new System.Drawing.Point(128, 410);
            this.mtbNumOficio.Mask = "000";
            this.mtbNumOficio.Name = "mtbNumOficio";
            this.mtbNumOficio.Size = new System.Drawing.Size(110, 29);
            this.mtbNumOficio.TabIndex = 8;
            this.mtbNumOficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumOficio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumOficio.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // mtbNumControle
            // 
            this.mtbNumControle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mtbNumControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumControle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumControle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.mtbNumControle.HidePromptOnLeave = true;
            this.mtbNumControle.Location = new System.Drawing.Point(12, 410);
            this.mtbNumControle.Mask = "000";
            this.mtbNumControle.Name = "mtbNumControle";
            this.mtbNumControle.Size = new System.Drawing.Size(110, 29);
            this.mtbNumControle.TabIndex = 7;
            this.mtbNumControle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumControle.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumControle.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.pictureBox2.Location = new System.Drawing.Point(536, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 572);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // lblLimparArquivo
            // 
            this.lblLimparArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLimparArquivo.BackColor = System.Drawing.SystemColors.Window;
            this.lblLimparArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLimparArquivo.Image = ((System.Drawing.Image)(resources.GetObject("lblLimparArquivo.Image")));
            this.lblLimparArquivo.Location = new System.Drawing.Point(503, 260);
            this.lblLimparArquivo.Name = "lblLimparArquivo";
            this.lblLimparArquivo.Size = new System.Drawing.Size(20, 20);
            this.lblLimparArquivo.TabIndex = 4;
            this.ttInfo.SetToolTip(this.lblLimparArquivo, "Fechar arquivo");
            this.lblLimparArquivo.Click += new System.EventHandler(this.lbLimparArquivo_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.Location = new System.Drawing.Point(12, 12);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(254, 35);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "&Selecionar";
            this.ttInfo.SetToolTip(this.btnSelecionar, "Selecionar ofícios");
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnLimparLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.btnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparLista.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparLista.ForeColor = System.Drawing.Color.White;
            this.btnLimparLista.Location = new System.Drawing.Point(273, 12);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(254, 35);
            this.btnLimparLista.TabIndex = 1;
            this.btnLimparLista.Text = "&Limpar";
            this.ttInfo.SetToolTip(this.btnLimparLista, "Limpar lista");
            this.btnLimparLista.UseVisualStyleBackColor = false;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // rbtRecebidos
            // 
            this.rbtRecebidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtRecebidos.AutoSize = true;
            this.rbtRecebidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtRecebidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtRecebidos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtRecebidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.rbtRecebidos.Location = new System.Drawing.Point(163, 322);
            this.rbtRecebidos.Name = "rbtRecebidos";
            this.rbtRecebidos.Size = new System.Drawing.Size(104, 25);
            this.rbtRecebidos.TabIndex = 5;
            this.rbtRecebidos.TabStop = true;
            this.rbtRecebidos.Text = "Recebidos";
            this.rbtRecebidos.UseVisualStyleBackColor = true;
            this.rbtRecebidos.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rbtEnviados
            // 
            this.rbtEnviados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtEnviados.AutoSize = true;
            this.rbtEnviados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtEnviados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtEnviados.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEnviados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.rbtEnviados.Location = new System.Drawing.Point(273, 322);
            this.rbtEnviados.Name = "rbtEnviados";
            this.rbtEnviados.Size = new System.Drawing.Size(91, 25);
            this.rbtEnviados.TabIndex = 6;
            this.rbtEnviados.TabStop = true;
            this.rbtEnviados.Text = "Enviados";
            this.rbtEnviados.UseVisualStyleBackColor = true;
            this.rbtEnviados.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lstOficios
            // 
            this.lstOficios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstOficios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstOficios.DisplayMember = "nome";
            this.lstOficios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstOficios.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOficios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lstOficios.FormattingEnabled = true;
            this.lstOficios.ItemHeight = 25;
            this.lstOficios.Location = new System.Drawing.Point(12, 53);
            this.lstOficios.Name = "lstOficios";
            this.lstOficios.Size = new System.Drawing.Size(515, 151);
            this.lstOficios.TabIndex = 2;
            this.lstOficios.ValueMember = "id";
            this.lstOficios.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_DrawItem);
            this.lstOficios.SelectedIndexChanged += new System.EventHandler(this.lstOficios_SelectedIndexChanged);
            // 
            // pbxBrasao
            // 
            this.pbxBrasao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxBrasao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.pbxBrasao.Image = ((System.Drawing.Image)(resources.GetObject("pbxBrasao.Image")));
            this.pbxBrasao.Location = new System.Drawing.Point(717, 135);
            this.pbxBrasao.Name = "pbxBrasao";
            this.pbxBrasao.Size = new System.Drawing.Size(300, 300);
            this.pbxBrasao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBrasao.TabIndex = 20;
            this.pbxBrasao.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.btRenomear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1199, 571);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.lstOficios);
            this.Controls.Add(this.rbtEnviados);
            this.Controls.Add(this.rbtRecebidos);
            this.Controls.Add(this.lblLimparArquivo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbxBrasao);
            this.Controls.Add(this.mtbNumControle);
            this.Controls.Add(this.mtbNumOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblNumOficio);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lblNumControle);
            this.Controls.Add(this.lblArquivoSelecionado);
            this.Controls.Add(this.txtArquivoSelecionado);
            this.Controls.Add(this.btRenomear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1215, 610);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomeador de Ofícios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBrasao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRenomear;
        private System.Windows.Forms.TextBox txtArquivoSelecionado;
        private System.Windows.Forms.Label lblArquivoSelecionado;
        private System.Windows.Forms.Label lblNumControle;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Label lblNumOficio;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNumOficio;
        private System.Windows.Forms.MaskedTextBox mtbNumControle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Label lblLimparArquivo;
        private System.Windows.Forms.RadioButton rbtRecebidos;
        private System.Windows.Forms.RadioButton rbtEnviados;
        private System.Windows.Forms.ListBox lstOficios;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.PictureBox pbxBrasao;
    }
}

