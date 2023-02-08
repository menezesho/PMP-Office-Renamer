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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
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
            this.checkEnviados = new System.Windows.Forms.CheckBox();
            this.checkRecebidos = new System.Windows.Forms.CheckBox();
            this.btAbrirArquivo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btRenomear
            // 
            this.btRenomear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btRenomear.BackColor = System.Drawing.Color.White;
            this.btRenomear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRenomear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRenomear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRenomear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btRenomear.Location = new System.Drawing.Point(185, 614);
            this.btRenomear.Name = "btRenomear";
            this.btRenomear.Size = new System.Drawing.Size(179, 35);
            this.btRenomear.TabIndex = 5;
            this.btRenomear.Text = "&RENOMEAR";
            this.ttInfo.SetToolTip(this.btRenomear, "Renomear arquivo");
            this.btRenomear.UseVisualStyleBackColor = false;
            this.btRenomear.Click += new System.EventHandler(this.btRenomear_Click);
            // 
            // tbArquivoSelecionado
            // 
            this.tbArquivoSelecionado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbArquivoSelecionado.BackColor = System.Drawing.Color.White;
            this.tbArquivoSelecionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbArquivoSelecionado.Enabled = false;
            this.tbArquivoSelecionado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArquivoSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.tbArquivoSelecionado.Location = new System.Drawing.Point(66, 326);
            this.tbArquivoSelecionado.MaxLength = 100;
            this.tbArquivoSelecionado.Name = "tbArquivoSelecionado";
            this.tbArquivoSelecionado.Size = new System.Drawing.Size(416, 29);
            this.tbArquivoSelecionado.TabIndex = 0;
            this.tbArquivoSelecionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbArquivo
            // 
            this.lbArquivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbArquivo.AutoSize = true;
            this.lbArquivo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lbArquivo.Location = new System.Drawing.Point(188, 298);
            this.lbArquivo.Name = "lbArquivo";
            this.lbArquivo.Size = new System.Drawing.Size(172, 23);
            this.lbArquivo.TabIndex = 4;
            this.lbArquivo.Text = "Arquivo selecionado:";
            // 
            // lbNumSeq
            // 
            this.lbNumSeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNumSeq.AutoSize = true;
            this.lbNumSeq.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumSeq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lbNumSeq.Location = new System.Drawing.Point(62, 401);
            this.lbNumSeq.Name = "lbNumSeq";
            this.lbNumSeq.Size = new System.Drawing.Size(141, 23);
            this.lbNumSeq.TabIndex = 5;
            this.lbNumSeq.Text = "Num. sequencial:";
            // 
            // tbSetor
            // 
            this.tbSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSetor.BackColor = System.Drawing.Color.White;
            this.tbSetor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSetor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.tbSetor.Location = new System.Drawing.Point(224, 471);
            this.tbSetor.MaxLength = 70;
            this.tbSetor.Name = "tbSetor";
            this.tbSetor.Size = new System.Drawing.Size(258, 29);
            this.tbSetor.TabIndex = 3;
            this.tbSetor.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // lbSetor
            // 
            this.lbSetor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbSetor.AutoSize = true;
            this.lbSetor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lbSetor.Location = new System.Drawing.Point(148, 471);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(55, 23);
            this.lbSetor.TabIndex = 9;
            this.lbSetor.Text = "Setor:";
            // 
            // lbNumOficio
            // 
            this.lbNumOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbNumOficio.AutoSize = true;
            this.lbNumOficio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumOficio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lbNumOficio.Location = new System.Drawing.Point(103, 436);
            this.lbNumOficio.Name = "lbNumOficio";
            this.lbNumOficio.Size = new System.Drawing.Size(100, 23);
            this.lbNumOficio.TabIndex = 10;
            this.lbNumOficio.Text = "Núm. ofício:";
            // 
            // lbResultado
            // 
            this.lbResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.lbResultado.Location = new System.Drawing.Point(228, 541);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(92, 23);
            this.lbResultado.TabIndex = 12;
            this.lbResultado.Text = "Resultado:";
            // 
            // tbResultado
            // 
            this.tbResultado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbResultado.BackColor = System.Drawing.Color.White;
            this.tbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResultado.Enabled = false;
            this.tbResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.tbResultado.Location = new System.Drawing.Point(66, 569);
            this.tbResultado.MaxLength = 100;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(416, 29);
            this.tbResultado.TabIndex = 4;
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pdf
            // 
            this.pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdf.BackColor = System.Drawing.SystemColors.Control;
            this.pdf.Location = new System.Drawing.Point(536, -1);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(663, 675);
            this.pdf.TabIndex = 13;
            this.pdf.TabStop = false;
            this.pdf.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
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
            this.mtbNumOficio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbNumOficio.BackColor = System.Drawing.Color.White;
            this.mtbNumOficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumOficio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumOficio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.mtbNumOficio.HidePromptOnLeave = true;
            this.mtbNumOficio.Location = new System.Drawing.Point(224, 436);
            this.mtbNumOficio.Mask = "0000";
            this.mtbNumOficio.Name = "mtbNumOficio";
            this.mtbNumOficio.Size = new System.Drawing.Size(59, 29);
            this.mtbNumOficio.TabIndex = 2;
            this.mtbNumOficio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumOficio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumOficio.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // mtbNumSeq
            // 
            this.mtbNumSeq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbNumSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbNumSeq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumSeq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(80)))), ((int)(((byte)(97)))));
            this.mtbNumSeq.HidePromptOnLeave = true;
            this.mtbNumSeq.Location = new System.Drawing.Point(224, 401);
            this.mtbNumSeq.Mask = "0000";
            this.mtbNumSeq.Name = "mtbNumSeq";
            this.mtbNumSeq.Size = new System.Drawing.Size(59, 29);
            this.mtbNumSeq.TabIndex = 1;
            this.mtbNumSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNumSeq.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbNumSeq.TextChanged += new System.EventHandler(this.allTextBox_TextChanged);
            // 
            // checkEnviados
            // 
            this.checkEnviados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkEnviados.AutoSize = true;
            this.checkEnviados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkEnviados.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnviados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.checkEnviados.Location = new System.Drawing.Point(296, 230);
            this.checkEnviados.Name = "checkEnviados";
            this.checkEnviados.Size = new System.Drawing.Size(97, 27);
            this.checkEnviados.TabIndex = 17;
            this.checkEnviados.Text = "Enviados";
            this.checkEnviados.UseVisualStyleBackColor = true;
            this.checkEnviados.Click += new System.EventHandler(this.checkEnviados_Click);
            // 
            // checkRecebidos
            // 
            this.checkRecebidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkRecebidos.AutoSize = true;
            this.checkRecebidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkRecebidos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRecebidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.checkRecebidos.Location = new System.Drawing.Point(154, 230);
            this.checkRecebidos.Name = "checkRecebidos";
            this.checkRecebidos.Size = new System.Drawing.Size(107, 27);
            this.checkRecebidos.TabIndex = 18;
            this.checkRecebidos.Text = "Recebidos";
            this.checkRecebidos.UseVisualStyleBackColor = true;
            this.checkRecebidos.Click += new System.EventHandler(this.checkRecebidos_Click);
            // 
            // btAbrirArquivo
            // 
            this.btAbrirArquivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAbrirArquivo.BackColor = System.Drawing.Color.White;
            this.btAbrirArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAbrirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbrirArquivo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbrirArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btAbrirArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btAbrirArquivo.Image")));
            this.btAbrirArquivo.Location = new System.Drawing.Point(447, 326);
            this.btAbrirArquivo.Name = "btAbrirArquivo";
            this.btAbrirArquivo.Size = new System.Drawing.Size(35, 29);
            this.btAbrirArquivo.TabIndex = 19;
            this.ttInfo.SetToolTip(this.btAbrirArquivo, "Abrir arquivo");
            this.btAbrirArquivo.UseVisualStyleBackColor = false;
            this.btAbrirArquivo.Click += new System.EventHandler(this.btAbrirArquivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pictureBox2.Location = new System.Drawing.Point(536, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 675);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AcceptButton = this.btRenomear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1199, 674);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAbrirArquivo);
            this.Controls.Add(this.checkRecebidos);
            this.Controls.Add(this.checkEnviados);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1215, 713);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renomear Ofícios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.MaskedTextBox mtbNumOficio;
        private System.Windows.Forms.MaskedTextBox mtbNumSeq;
        private System.Windows.Forms.CheckBox checkEnviados;
        private System.Windows.Forms.CheckBox checkRecebidos;
        private System.Windows.Forms.Button btAbrirArquivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}

