namespace Imobiliaria
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle estiloCabecalho = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelulas = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblLogoSub = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnMenuNovo = new System.Windows.Forms.Button();
            this.btnMenuSobre = new System.Windows.Forms.Button();
            this.lblArmazenamento = new System.Windows.Forms.Label();
            this.picIlustracao = new System.Windows.Forms.PictureBox();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlLista = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInteresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlListaTopo = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblTotalLista = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.pnlCorTotal = new System.Windows.Forms.Panel();
            this.lblNumTotal = new System.Windows.Forms.Label();
            this.lblDescTotal = new System.Windows.Forms.Label();
            this.picIconeTotal = new System.Windows.Forms.PictureBox();
            this.pnlCardCompra = new System.Windows.Forms.Panel();
            this.pnlCorCompra = new System.Windows.Forms.Panel();
            this.lblNumCompra = new System.Windows.Forms.Label();
            this.lblDescCompra = new System.Windows.Forms.Label();
            this.picIconeCompra = new System.Windows.Forms.PictureBox();
            this.pnlCardAluguel = new System.Windows.Forms.Panel();
            this.pnlCorAluguel = new System.Windows.Forms.Panel();
            this.lblNumAluguel = new System.Windows.Forms.Label();
            this.lblDescAluguel = new System.Windows.Forms.Label();
            this.picIconeAluguel = new System.Windows.Forms.PictureBox();
            this.pnlCardVenda = new System.Windows.Forms.Panel();
            this.pnlCorVenda = new System.Windows.Forms.Panel();
            this.lblNumVenda = new System.Windows.Forms.Label();
            this.lblDescVenda = new System.Windows.Forms.Label();
            this.picIconeVenda = new System.Windows.Forms.PictureBox();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustracao)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.pnlListaTopo.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeTotal)).BeginInit();
            this.pnlCardCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeCompra)).BeginInit();
            this.pnlCardAluguel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeAluguel)).BeginInit();
            this.pnlCardVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeVenda)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlMenu
            //
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Controls.Add(this.lblLogo);
            this.pnlMenu.Controls.Add(this.lblLogoSub);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Controls.Add(this.btnMenuClientes);
            this.pnlMenu.Controls.Add(this.btnMenuNovo);
            this.pnlMenu.Controls.Add(this.btnMenuSobre);
            this.pnlMenu.Controls.Add(this.lblArmazenamento);
            this.pnlMenu.Controls.Add(this.picIlustracao);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(230, 740);
            this.pnlMenu.TabIndex = 1;
            //
            // picLogo
            //
            this.picLogo.Location = new System.Drawing.Point(22, 24);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            //
            // lblLogo
            //
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblLogo.Location = new System.Drawing.Point(76, 24);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(130, 25);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Horizonte";
            //
            // lblLogoSub
            //
            this.lblLogoSub.AutoSize = true;
            this.lblLogoSub.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblLogoSub.ForeColor = System.Drawing.Color.FromArgb(196, 190, 214);
            this.lblLogoSub.Location = new System.Drawing.Point(79, 54);
            this.lblLogoSub.Name = "lblLogoSub";
            this.lblLogoSub.Size = new System.Drawing.Size(80, 13);
            this.lblLogoSub.TabIndex = 2;
            this.lblLogoSub.Text = "I M Ó V E I S";
            //
            // lblMenu
            //
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(124, 116, 148);
            this.lblMenu.Location = new System.Drawing.Point(24, 100);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(36, 13);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "MENU";
            //
            // btnMenuClientes
            //
            this.btnMenuClientes.BackColor = System.Drawing.Color.FromArgb(40, 30, 62);
            this.btnMenuClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 40, 80);
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientes.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuClientes.ForeColor = System.Drawing.Color.White;
            this.btnMenuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.Location = new System.Drawing.Point(12, 124);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMenuClientes.Size = new System.Drawing.Size(206, 46);
            this.btnMenuClientes.TabIndex = 4;
            this.btnMenuClientes.Text = "   Clientes";
            this.btnMenuClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuClientes.UseVisualStyleBackColor = false;
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            //
            // btnMenuNovo
            //
            this.btnMenuNovo.BackColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.btnMenuNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuNovo.FlatAppearance.BorderSize = 0;
            this.btnMenuNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 40, 80);
            this.btnMenuNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuNovo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuNovo.ForeColor = System.Drawing.Color.FromArgb(196, 190, 214);
            this.btnMenuNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNovo.Location = new System.Drawing.Point(12, 176);
            this.btnMenuNovo.Name = "btnMenuNovo";
            this.btnMenuNovo.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMenuNovo.Size = new System.Drawing.Size(206, 46);
            this.btnMenuNovo.TabIndex = 5;
            this.btnMenuNovo.Text = "   Novo cliente";
            this.btnMenuNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuNovo.UseVisualStyleBackColor = false;
            this.btnMenuNovo.Click += new System.EventHandler(this.btnNovo_Click);
            //
            // btnMenuSobre
            //
            this.btnMenuSobre.BackColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.btnMenuSobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSobre.FlatAppearance.BorderSize = 0;
            this.btnMenuSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(52, 40, 80);
            this.btnMenuSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSobre.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMenuSobre.ForeColor = System.Drawing.Color.FromArgb(196, 190, 214);
            this.btnMenuSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSobre.Location = new System.Drawing.Point(12, 228);
            this.btnMenuSobre.Name = "btnMenuSobre";
            this.btnMenuSobre.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMenuSobre.Size = new System.Drawing.Size(206, 46);
            this.btnMenuSobre.TabIndex = 6;
            this.btnMenuSobre.Text = "   Sobre o sistema";
            this.btnMenuSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSobre.UseVisualStyleBackColor = false;
            this.btnMenuSobre.Click += new System.EventHandler(this.btnMenuSobre_Click);
            //
            // lblArmazenamento
            //
            this.lblArmazenamento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblArmazenamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArmazenamento.ForeColor = System.Drawing.Color.FromArgb(167, 139, 250);
            this.lblArmazenamento.Location = new System.Drawing.Point(0, 382);
            this.lblArmazenamento.Name = "lblArmazenamento";
            this.lblArmazenamento.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.lblArmazenamento.Size = new System.Drawing.Size(230, 54);
            this.lblArmazenamento.TabIndex = 7;
            this.lblArmazenamento.Text = "ARMAZENAMENTO";
            this.lblArmazenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // picIlustracao
            //
            this.picIlustracao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picIlustracao.Location = new System.Drawing.Point(0, 436);
            this.picIlustracao.Name = "picIlustracao";
            this.picIlustracao.Size = new System.Drawing.Size(230, 304);
            this.picIlustracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIlustracao.TabIndex = 8;
            this.picIlustracao.TabStop = false;
            //
            // pnlConteudo
            //
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            this.pnlConteudo.Controls.Add(this.pnlLista);
            this.pnlConteudo.Controls.Add(this.pnlCards);
            this.pnlConteudo.Controls.Add(this.pnlTopo);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(230, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Padding = new System.Windows.Forms.Padding(28, 22, 28, 24);
            this.pnlConteudo.Size = new System.Drawing.Size(1010, 740);
            this.pnlConteudo.TabIndex = 0;
            //
            // pnlTopo
            //
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(this.lblSubtitulo);
            this.pnlTopo.Controls.Add(this.txtBusca);
            this.pnlTopo.Controls.Add(this.btnNovo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(28, 22);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(954, 84);
            this.pnlTopo.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Clientes";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblSubtitulo.Location = new System.Drawing.Point(2, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(300, 19);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gerencie a carteira de clientes da imobiliária";
            //
            // txtBusca
            //
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.txtBusca.Location = new System.Drawing.Point(440, 24);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Buscar por nome, CPF ou cidade...";
            this.txtBusca.Size = new System.Drawing.Size(326, 28);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            //
            // btnNovo
            //
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 40, 217);
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(784, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(170, 44);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = " Novo cliente";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            //
            // pnlCards
            //
            this.pnlCards.Controls.Add(this.pnlCardTotal);
            this.pnlCards.Controls.Add(this.pnlCardCompra);
            this.pnlCards.Controls.Add(this.pnlCardAluguel);
            this.pnlCards.Controls.Add(this.pnlCardVenda);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(28, 106);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(954, 122);
            this.pnlCards.TabIndex = 1;
            //
            // pnlCardTotal
            //
            this.pnlCardTotal.BackColor = System.Drawing.Color.White;
            this.pnlCardTotal.Controls.Add(this.picIconeTotal);
            this.pnlCardTotal.Controls.Add(this.lblNumTotal);
            this.pnlCardTotal.Controls.Add(this.lblDescTotal);
            this.pnlCardTotal.Controls.Add(this.pnlCorTotal);
            this.pnlCardTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(219, 100);
            this.pnlCardTotal.TabIndex = 0;
            //
            // pnlCorTotal
            //
            this.pnlCorTotal.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.pnlCorTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCorTotal.Location = new System.Drawing.Point(0, 0);
            this.pnlCorTotal.Name = "pnlCorTotal";
            this.pnlCorTotal.Size = new System.Drawing.Size(5, 100);
            this.pnlCorTotal.TabIndex = 0;
            //
            // lblNumTotal
            //
            this.lblNumTotal.AutoSize = true;
            this.lblNumTotal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F);
            this.lblNumTotal.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblNumTotal.Location = new System.Drawing.Point(20, 14);
            this.lblNumTotal.Name = "lblNumTotal";
            this.lblNumTotal.Size = new System.Drawing.Size(32, 34);
            this.lblNumTotal.TabIndex = 1;
            this.lblNumTotal.Text = "0";
            //
            // lblDescTotal
            //
            this.lblDescTotal.AutoSize = true;
            this.lblDescTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescTotal.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblDescTotal.Location = new System.Drawing.Point(22, 62);
            this.lblDescTotal.Name = "lblDescTotal";
            this.lblDescTotal.Size = new System.Drawing.Size(130, 17);
            this.lblDescTotal.TabIndex = 2;
            this.lblDescTotal.Text = "Clientes cadastrados";
            //
            // picIconeTotal
            //
            this.picIconeTotal.Location = new System.Drawing.Point(165, 20);
            this.picIconeTotal.Name = "picIconeTotal";
            this.picIconeTotal.Size = new System.Drawing.Size(34, 34);
            this.picIconeTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconeTotal.TabIndex = 3;
            this.picIconeTotal.TabStop = false;
            //
            // pnlCardCompra
            //
            this.pnlCardCompra.BackColor = System.Drawing.Color.White;
            this.pnlCardCompra.Controls.Add(this.picIconeCompra);
            this.pnlCardCompra.Controls.Add(this.lblNumCompra);
            this.pnlCardCompra.Controls.Add(this.lblDescCompra);
            this.pnlCardCompra.Controls.Add(this.pnlCorCompra);
            this.pnlCardCompra.Location = new System.Drawing.Point(245, 0);
            this.pnlCardCompra.Name = "pnlCardCompra";
            this.pnlCardCompra.Size = new System.Drawing.Size(219, 100);
            this.pnlCardCompra.TabIndex = 1;
            //
            // pnlCorCompra
            //
            this.pnlCorCompra.BackColor = System.Drawing.Color.FromArgb(22, 150, 90);
            this.pnlCorCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCorCompra.Location = new System.Drawing.Point(0, 0);
            this.pnlCorCompra.Name = "pnlCorCompra";
            this.pnlCorCompra.Size = new System.Drawing.Size(5, 100);
            this.pnlCorCompra.TabIndex = 0;
            //
            // lblNumCompra
            //
            this.lblNumCompra.AutoSize = true;
            this.lblNumCompra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F);
            this.lblNumCompra.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblNumCompra.Location = new System.Drawing.Point(20, 14);
            this.lblNumCompra.Name = "lblNumCompra";
            this.lblNumCompra.Size = new System.Drawing.Size(32, 34);
            this.lblNumCompra.TabIndex = 1;
            this.lblNumCompra.Text = "0";
            //
            // lblDescCompra
            //
            this.lblDescCompra.AutoSize = true;
            this.lblDescCompra.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescCompra.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblDescCompra.Location = new System.Drawing.Point(22, 62);
            this.lblDescCompra.Name = "lblDescCompra";
            this.lblDescCompra.Size = new System.Drawing.Size(105, 17);
            this.lblDescCompra.TabIndex = 2;
            this.lblDescCompra.Text = "Querem comprar";
            //
            // picIconeCompra
            //
            this.picIconeCompra.Location = new System.Drawing.Point(165, 20);
            this.picIconeCompra.Name = "picIconeCompra";
            this.picIconeCompra.Size = new System.Drawing.Size(34, 34);
            this.picIconeCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconeCompra.TabIndex = 3;
            this.picIconeCompra.TabStop = false;
            //
            // pnlCardAluguel
            //
            this.pnlCardAluguel.BackColor = System.Drawing.Color.White;
            this.pnlCardAluguel.Controls.Add(this.picIconeAluguel);
            this.pnlCardAluguel.Controls.Add(this.lblNumAluguel);
            this.pnlCardAluguel.Controls.Add(this.lblDescAluguel);
            this.pnlCardAluguel.Controls.Add(this.pnlCorAluguel);
            this.pnlCardAluguel.Location = new System.Drawing.Point(490, 0);
            this.pnlCardAluguel.Name = "pnlCardAluguel";
            this.pnlCardAluguel.Size = new System.Drawing.Size(219, 100);
            this.pnlCardAluguel.TabIndex = 2;
            //
            // pnlCorAluguel
            //
            this.pnlCorAluguel.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlCorAluguel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCorAluguel.Location = new System.Drawing.Point(0, 0);
            this.pnlCorAluguel.Name = "pnlCorAluguel";
            this.pnlCorAluguel.Size = new System.Drawing.Size(5, 100);
            this.pnlCorAluguel.TabIndex = 0;
            //
            // lblNumAluguel
            //
            this.lblNumAluguel.AutoSize = true;
            this.lblNumAluguel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F);
            this.lblNumAluguel.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblNumAluguel.Location = new System.Drawing.Point(20, 14);
            this.lblNumAluguel.Name = "lblNumAluguel";
            this.lblNumAluguel.Size = new System.Drawing.Size(32, 34);
            this.lblNumAluguel.TabIndex = 1;
            this.lblNumAluguel.Text = "0";
            //
            // lblDescAluguel
            //
            this.lblDescAluguel.AutoSize = true;
            this.lblDescAluguel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescAluguel.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblDescAluguel.Location = new System.Drawing.Point(22, 62);
            this.lblDescAluguel.Name = "lblDescAluguel";
            this.lblDescAluguel.Size = new System.Drawing.Size(95, 17);
            this.lblDescAluguel.TabIndex = 2;
            this.lblDescAluguel.Text = "Querem alugar";
            //
            // picIconeAluguel
            //
            this.picIconeAluguel.Location = new System.Drawing.Point(165, 20);
            this.picIconeAluguel.Name = "picIconeAluguel";
            this.picIconeAluguel.Size = new System.Drawing.Size(34, 34);
            this.picIconeAluguel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconeAluguel.TabIndex = 3;
            this.picIconeAluguel.TabStop = false;
            //
            // pnlCardVenda
            //
            this.pnlCardVenda.BackColor = System.Drawing.Color.White;
            this.pnlCardVenda.Controls.Add(this.picIconeVenda);
            this.pnlCardVenda.Controls.Add(this.lblNumVenda);
            this.pnlCardVenda.Controls.Add(this.lblDescVenda);
            this.pnlCardVenda.Controls.Add(this.pnlCorVenda);
            this.pnlCardVenda.Location = new System.Drawing.Point(735, 0);
            this.pnlCardVenda.Name = "pnlCardVenda";
            this.pnlCardVenda.Size = new System.Drawing.Size(219, 100);
            this.pnlCardVenda.TabIndex = 3;
            //
            // pnlCorVenda
            //
            this.pnlCorVenda.BackColor = System.Drawing.Color.FromArgb(192, 38, 211);
            this.pnlCorVenda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCorVenda.Location = new System.Drawing.Point(0, 0);
            this.pnlCorVenda.Name = "pnlCorVenda";
            this.pnlCorVenda.Size = new System.Drawing.Size(5, 100);
            this.pnlCorVenda.TabIndex = 0;
            //
            // lblNumVenda
            //
            this.lblNumVenda.AutoSize = true;
            this.lblNumVenda.Font = new System.Drawing.Font("Bahnschrift SemiBold", 22F);
            this.lblNumVenda.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblNumVenda.Location = new System.Drawing.Point(20, 14);
            this.lblNumVenda.Name = "lblNumVenda";
            this.lblNumVenda.Size = new System.Drawing.Size(32, 34);
            this.lblNumVenda.TabIndex = 1;
            this.lblNumVenda.Text = "0";
            //
            // lblDescVenda
            //
            this.lblDescVenda.AutoSize = true;
            this.lblDescVenda.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDescVenda.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblDescVenda.Location = new System.Drawing.Point(22, 62);
            this.lblDescVenda.Name = "lblDescVenda";
            this.lblDescVenda.Size = new System.Drawing.Size(95, 17);
            this.lblDescVenda.TabIndex = 2;
            this.lblDescVenda.Text = "Querem vender";
            //
            // picIconeVenda
            //
            this.picIconeVenda.Location = new System.Drawing.Point(165, 20);
            this.picIconeVenda.Name = "picIconeVenda";
            this.picIconeVenda.Size = new System.Drawing.Size(34, 34);
            this.picIconeVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconeVenda.TabIndex = 3;
            this.picIconeVenda.TabStop = false;
            //
            // pnlLista
            //
            this.pnlLista.BackColor = System.Drawing.Color.White;
            this.pnlLista.Controls.Add(this.dgvClientes);
            this.pnlLista.Controls.Add(this.pnlListaTopo);
            this.pnlLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLista.Location = new System.Drawing.Point(28, 228);
            this.pnlLista.Name = "pnlLista";
            this.pnlLista.Padding = new System.Windows.Forms.Padding(18);
            this.pnlLista.Size = new System.Drawing.Size(954, 488);
            this.pnlLista.TabIndex = 2;
            //
            // pnlListaTopo
            //
            this.pnlListaTopo.Controls.Add(this.lblLista);
            this.pnlListaTopo.Controls.Add(this.lblTotalLista);
            this.pnlListaTopo.Controls.Add(this.btnEditar);
            this.pnlListaTopo.Controls.Add(this.btnExcluir);
            this.pnlListaTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListaTopo.Location = new System.Drawing.Point(18, 18);
            this.pnlListaTopo.Name = "pnlListaTopo";
            this.pnlListaTopo.Size = new System.Drawing.Size(918, 60);
            this.pnlListaTopo.TabIndex = 0;
            //
            // lblLista
            //
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F);
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblLista.Location = new System.Drawing.Point(0, 4);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(150, 21);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista de clientes";
            //
            // lblTotalLista
            //
            this.lblTotalLista.AutoSize = true;
            this.lblTotalLista.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLista.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblTotalLista.Location = new System.Drawing.Point(2, 32);
            this.lblTotalLista.Name = "lblTotalLista";
            this.lblTotalLista.Size = new System.Drawing.Size(120, 15);
            this.lblTotalLista.TabIndex = 1;
            this.lblTotalLista.Text = "0 cliente(s)";
            //
            // btnEditar
            //
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 223, 236);
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.btnEditar.Location = new System.Drawing.Point(678, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 40);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = " Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            //
            // btnExcluir
            //
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(240, 205, 200);
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(252, 237, 235);
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnExcluir.Location = new System.Drawing.Point(808, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 40);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = " Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            //
            // dgvClientes
            //
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            estiloCabecalho.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloCabecalho.BackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            estiloCabecalho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            estiloCabecalho.ForeColor = System.Drawing.Color.FromArgb(109, 40, 217);
            estiloCabecalho.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            estiloCabecalho.SelectionBackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            estiloCabecalho.SelectionForeColor = System.Drawing.Color.FromArgb(109, 40, 217);
            estiloCabecalho.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = estiloCabecalho;
            this.dgvClientes.ColumnHeadersHeight = 42;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNome,
            this.colCpf,
            this.colTelefone,
            this.colInteresse,
            this.colImovel,
            this.colCidade,
            this.colValor,
            this.colCadastro});
            estiloCelulas.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloCelulas.BackColor = System.Drawing.Color.White;
            estiloCelulas.Font = new System.Drawing.Font("Segoe UI", 10F);
            estiloCelulas.ForeColor = System.Drawing.Color.FromArgb(24, 24, 32);
            estiloCelulas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            estiloCelulas.SelectionBackColor = System.Drawing.Color.FromArgb(237, 233, 254);
            estiloCelulas.SelectionForeColor = System.Drawing.Color.FromArgb(24, 24, 32);
            estiloCelulas.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = estiloCelulas;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.FromArgb(234, 232, 241);
            this.dgvClientes.Location = new System.Drawing.Point(18, 78);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowTemplate.Height = 46;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(918, 392);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            //
            // colId
            //
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            //
            // colNome
            //
            this.colNome.FillWeight = 190F;
            this.colNome.HeaderText = "NOME";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            //
            // colCpf
            //
            this.colCpf.FillWeight = 120F;
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            //
            // colTelefone
            //
            this.colTelefone.FillWeight = 125F;
            this.colTelefone.HeaderText = "TELEFONE";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            //
            // colInteresse
            //
            this.colInteresse.FillWeight = 90F;
            this.colInteresse.HeaderText = "INTERESSE";
            this.colInteresse.Name = "colInteresse";
            this.colInteresse.ReadOnly = true;
            //
            // colImovel
            //
            this.colImovel.FillWeight = 115F;
            this.colImovel.HeaderText = "IMÓVEL";
            this.colImovel.Name = "colImovel";
            this.colImovel.ReadOnly = true;
            //
            // colCidade
            //
            this.colCidade.FillWeight = 120F;
            this.colCidade.HeaderText = "CIDADE";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            //
            // colValor
            //
            this.colValor.FillWeight = 120F;
            this.colValor.HeaderText = "VALOR";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            //
            // colCadastro
            //
            this.colCadastro.FillWeight = 95F;
            this.colCadastro.HeaderText = "CADASTRO";
            this.colCadastro.Name = "colCadastro";
            this.colCadastro.ReadOnly = true;
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            this.ClientSize = new System.Drawing.Size(1240, 740);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1150, 720);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horizonte Imóveis · Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustracao)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.pnlListaTopo.ResumeLayout(false);
            this.pnlListaTopo.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeTotal)).EndInit();
            this.pnlCardCompra.ResumeLayout(false);
            this.pnlCardCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeCompra)).EndInit();
            this.pnlCardAluguel.ResumeLayout(false);
            this.pnlCardAluguel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeAluguel)).EndInit();
            this.pnlCardVenda.ResumeLayout(false);
            this.pnlCardVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconeVenda)).EndInit();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnMenuNovo;
        private System.Windows.Forms.Button btnMenuSobre;
        private System.Windows.Forms.Label lblArmazenamento;
        private System.Windows.Forms.PictureBox picIlustracao;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Panel pnlCorTotal;
        private System.Windows.Forms.Label lblNumTotal;
        private System.Windows.Forms.Label lblDescTotal;
        private System.Windows.Forms.PictureBox picIconeTotal;
        private System.Windows.Forms.Panel pnlCardCompra;
        private System.Windows.Forms.Panel pnlCorCompra;
        private System.Windows.Forms.Label lblNumCompra;
        private System.Windows.Forms.Label lblDescCompra;
        private System.Windows.Forms.PictureBox picIconeCompra;
        private System.Windows.Forms.Panel pnlCardAluguel;
        private System.Windows.Forms.Panel pnlCorAluguel;
        private System.Windows.Forms.Label lblNumAluguel;
        private System.Windows.Forms.Label lblDescAluguel;
        private System.Windows.Forms.PictureBox picIconeAluguel;
        private System.Windows.Forms.Panel pnlCardVenda;
        private System.Windows.Forms.Panel pnlCorVenda;
        private System.Windows.Forms.Label lblNumVenda;
        private System.Windows.Forms.Label lblDescVenda;
        private System.Windows.Forms.PictureBox picIconeVenda;
        private System.Windows.Forms.Panel pnlLista;
        private System.Windows.Forms.Panel pnlListaTopo;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblTotalLista;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInteresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCadastro;
    }
}
