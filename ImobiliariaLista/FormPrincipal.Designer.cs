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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            picLogo = new PictureBox();
            lblLogo = new Label();
            lblLogoSub = new Label();
            lblMenu = new Label();
            btnMenuClientes = new Button();
            btnMenuNovo = new Button();
            btnMenuSobre = new Button();
            picIlustracao = new PictureBox();
            pnlConteudo = new Panel();
            pnlLista = new Panel();
            dgvClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCpf = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            colInteresse = new DataGridViewTextBoxColumn();
            colImovel = new DataGridViewTextBoxColumn();
            colCidade = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colCadastro = new DataGridViewTextBoxColumn();
            pnlListaTopo = new Panel();
            lblLista = new Label();
            lblTotalLista = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            pnlCards = new Panel();
            pnlCardTotal = new Panel();
            picIconeTotal = new PictureBox();
            lblNumTotal = new Label();
            lblDescTotal = new Label();
            pnlCorTotal = new Panel();
            pnlCardCompra = new Panel();
            picIconeCompra = new PictureBox();
            lblNumCompra = new Label();
            lblDescCompra = new Label();
            pnlCorCompra = new Panel();
            pnlCardAluguel = new Panel();
            picIconeAluguel = new PictureBox();
            lblNumAluguel = new Label();
            lblDescAluguel = new Label();
            pnlCorAluguel = new Panel();
            pnlCardVenda = new Panel();
            picIconeVenda = new PictureBox();
            lblNumVenda = new Label();
            lblDescVenda = new Label();
            pnlCorVenda = new Panel();
            pnlTopo = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtBusca = new TextBox();
            btnNovo = new Button();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIlustracao).BeginInit();
            pnlConteudo.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlListaTopo.SuspendLayout();
            pnlCards.SuspendLayout();
            pnlCardTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeTotal).BeginInit();
            pnlCardCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeCompra).BeginInit();
            pnlCardAluguel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeAluguel).BeginInit();
            pnlCardVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeVenda).BeginInit();
            pnlTopo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(18, 17, 24);
            pnlMenu.Controls.Add(picLogo);
            pnlMenu.Controls.Add(lblLogo);
            pnlMenu.Controls.Add(lblLogoSub);
            pnlMenu.Controls.Add(lblMenu);
            pnlMenu.Controls.Add(btnMenuClientes);
            pnlMenu.Controls.Add(btnMenuNovo);
            pnlMenu.Controls.Add(btnMenuSobre);
            pnlMenu.Controls.Add(picIlustracao);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(4, 5, 4, 5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(329, 1233);
            pnlMenu.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(31, 40);
            picLogo.Margin = new Padding(4, 5, 4, 5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(69, 80);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Bahnschrift SemiBold", 16F);
            lblLogo.ForeColor = Color.FromArgb(167, 139, 250);
            lblLogo.Location = new Point(109, 40);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(156, 39);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Horizonte";
            // 
            // lblLogoSub
            // 
            lblLogoSub.AutoSize = true;
            lblLogoSub.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblLogoSub.ForeColor = Color.FromArgb(196, 190, 214);
            lblLogoSub.Location = new Point(113, 90);
            lblLogoSub.Margin = new Padding(4, 0, 4, 0);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Size = new Size(100, 21);
            lblLogoSub.TabIndex = 2;
            lblLogoSub.Text = "I M Ó V E I S";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(124, 116, 148);
            lblMenu.Location = new Point(34, 167);
            lblMenu.Margin = new Padding(4, 0, 4, 0);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(59, 21);
            lblMenu.TabIndex = 3;
            lblMenu.Text = "MENU";
            // 
            // btnMenuClientes
            // 
            btnMenuClientes.BackColor = Color.FromArgb(40, 30, 62);
            btnMenuClientes.Cursor = Cursors.Hand;
            btnMenuClientes.FlatAppearance.BorderSize = 0;
            btnMenuClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 40, 80);
            btnMenuClientes.FlatStyle = FlatStyle.Flat;
            btnMenuClientes.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuClientes.ForeColor = Color.White;
            btnMenuClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuClientes.Location = new Point(17, 207);
            btnMenuClientes.Margin = new Padding(4, 5, 4, 5);
            btnMenuClientes.Name = "btnMenuClientes";
            btnMenuClientes.Padding = new Padding(20, 0, 0, 0);
            btnMenuClientes.Size = new Size(294, 77);
            btnMenuClientes.TabIndex = 4;
            btnMenuClientes.Text = "   Clientes";
            btnMenuClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuClientes.UseVisualStyleBackColor = false;
            btnMenuClientes.Click += btnMenuClientes_Click;
            // 
            // btnMenuNovo
            // 
            btnMenuNovo.BackColor = Color.FromArgb(18, 17, 24);
            btnMenuNovo.Cursor = Cursors.Hand;
            btnMenuNovo.FlatAppearance.BorderSize = 0;
            btnMenuNovo.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 40, 80);
            btnMenuNovo.FlatStyle = FlatStyle.Flat;
            btnMenuNovo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuNovo.ForeColor = Color.FromArgb(196, 190, 214);
            btnMenuNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuNovo.Location = new Point(17, 293);
            btnMenuNovo.Margin = new Padding(4, 5, 4, 5);
            btnMenuNovo.Name = "btnMenuNovo";
            btnMenuNovo.Padding = new Padding(20, 0, 0, 0);
            btnMenuNovo.Size = new Size(294, 77);
            btnMenuNovo.TabIndex = 5;
            btnMenuNovo.Text = "   Novo cliente";
            btnMenuNovo.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuNovo.UseVisualStyleBackColor = false;
            btnMenuNovo.Click += btnNovo_Click;
            // 
            // btnMenuSobre
            // 
            btnMenuSobre.BackColor = Color.FromArgb(18, 17, 24);
            btnMenuSobre.Cursor = Cursors.Hand;
            btnMenuSobre.FlatAppearance.BorderSize = 0;
            btnMenuSobre.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 40, 80);
            btnMenuSobre.FlatStyle = FlatStyle.Flat;
            btnMenuSobre.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnMenuSobre.ForeColor = Color.FromArgb(196, 190, 214);
            btnMenuSobre.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuSobre.Location = new Point(17, 380);
            btnMenuSobre.Margin = new Padding(4, 5, 4, 5);
            btnMenuSobre.Name = "btnMenuSobre";
            btnMenuSobre.Padding = new Padding(20, 0, 0, 0);
            btnMenuSobre.Size = new Size(294, 77);
            btnMenuSobre.TabIndex = 6;
            btnMenuSobre.Text = "   Sobre o sistema";
            btnMenuSobre.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuSobre.UseVisualStyleBackColor = false;
            btnMenuSobre.Click += btnMenuSobre_Click;
            // 
            // picIlustracao
            // 
            picIlustracao.Dock = DockStyle.Bottom;
            picIlustracao.Location = new Point(0, 726);
            picIlustracao.Margin = new Padding(4, 5, 4, 5);
            picIlustracao.Name = "picIlustracao";
            picIlustracao.Size = new Size(329, 507);
            picIlustracao.SizeMode = PictureBoxSizeMode.Zoom;
            picIlustracao.TabIndex = 8;
            picIlustracao.TabStop = false;
            // 
            // pnlConteudo
            // 
            pnlConteudo.BackColor = Color.FromArgb(246, 245, 250);
            pnlConteudo.Controls.Add(pnlLista);
            pnlConteudo.Controls.Add(pnlCards);
            pnlConteudo.Controls.Add(pnlTopo);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(329, 0);
            pnlConteudo.Margin = new Padding(4, 5, 4, 5);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Padding = new Padding(40, 37, 40, 40);
            pnlConteudo.Size = new Size(1442, 1233);
            pnlConteudo.TabIndex = 0;
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvClientes);
            pnlLista.Controls.Add(pnlListaTopo);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(40, 380);
            pnlLista.Margin = new Padding(4, 5, 4, 5);
            pnlLista.Name = "pnlLista";
            pnlLista.Padding = new Padding(26, 30, 26, 30);
            pnlLista.Size = new Size(1362, 813);
            pnlLista.TabIndex = 2;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(246, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(109, 40, 217);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(246, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(109, 40, 217);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 42;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colCpf, colTelefone, colInteresse, colImovel, colCidade, colValor, colCadastro });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(24, 24, 32);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(237, 233, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(24, 24, 32);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(234, 232, 241);
            dgvClientes.Location = new Point(26, 130);
            dgvClientes.Margin = new Padding(4, 5, 4, 5);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.RowTemplate.Height = 46;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1310, 653);
            dgvClientes.TabIndex = 1;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            dgvClientes.CellFormatting += dgvClientes_CellFormatting;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 8;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colNome
            // 
            colNome.FillWeight = 190F;
            colNome.HeaderText = "NOME";
            colNome.MinimumWidth = 8;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colCpf
            // 
            colCpf.FillWeight = 120F;
            colCpf.HeaderText = "CPF";
            colCpf.MinimumWidth = 8;
            colCpf.Name = "colCpf";
            colCpf.ReadOnly = true;
            // 
            // colTelefone
            // 
            colTelefone.FillWeight = 125F;
            colTelefone.HeaderText = "TELEFONE";
            colTelefone.MinimumWidth = 8;
            colTelefone.Name = "colTelefone";
            colTelefone.ReadOnly = true;
            // 
            // colInteresse
            // 
            colInteresse.FillWeight = 90F;
            colInteresse.HeaderText = "INTERESSE";
            colInteresse.MinimumWidth = 8;
            colInteresse.Name = "colInteresse";
            colInteresse.ReadOnly = true;
            // 
            // colImovel
            // 
            colImovel.FillWeight = 115F;
            colImovel.HeaderText = "IMÓVEL";
            colImovel.MinimumWidth = 8;
            colImovel.Name = "colImovel";
            colImovel.ReadOnly = true;
            // 
            // colCidade
            // 
            colCidade.FillWeight = 120F;
            colCidade.HeaderText = "CIDADE";
            colCidade.MinimumWidth = 8;
            colCidade.Name = "colCidade";
            colCidade.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.FillWeight = 120F;
            colValor.HeaderText = "VALOR";
            colValor.MinimumWidth = 8;
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // colCadastro
            // 
            colCadastro.FillWeight = 95F;
            colCadastro.HeaderText = "CADASTRO";
            colCadastro.MinimumWidth = 8;
            colCadastro.Name = "colCadastro";
            colCadastro.ReadOnly = true;
            // 
            // pnlListaTopo
            // 
            pnlListaTopo.Controls.Add(lblLista);
            pnlListaTopo.Controls.Add(lblTotalLista);
            pnlListaTopo.Controls.Add(btnEditar);
            pnlListaTopo.Controls.Add(btnExcluir);
            pnlListaTopo.Dock = DockStyle.Top;
            pnlListaTopo.Location = new Point(26, 30);
            pnlListaTopo.Margin = new Padding(4, 5, 4, 5);
            pnlListaTopo.Name = "pnlListaTopo";
            pnlListaTopo.Size = new Size(1310, 100);
            pnlListaTopo.TabIndex = 0;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Bahnschrift SemiBold", 13F);
            lblLista.ForeColor = Color.FromArgb(18, 17, 24);
            lblLista.Location = new Point(0, 7);
            lblLista.Margin = new Padding(4, 0, 4, 0);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(205, 31);
            lblLista.TabIndex = 0;
            lblLista.Text = "Lista de clientes";
            // 
            // lblTotalLista
            // 
            lblTotalLista.AutoSize = true;
            lblTotalLista.Font = new Font("Segoe UI", 9F);
            lblTotalLista.ForeColor = Color.FromArgb(113, 113, 130);
            lblTotalLista.Location = new Point(3, 53);
            lblTotalLista.Margin = new Padding(4, 0, 4, 0);
            lblTotalLista.Name = "lblTotalLista";
            lblTotalLista.Size = new Size(95, 25);
            lblTotalLista.TabIndex = 1;
            lblTotalLista.Text = "0 cliente(s)";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(226, 223, 236);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(246, 245, 250);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(18, 17, 24);
            btnEditar.Location = new Point(968, 10);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(157, 67);
            btnEditar.TabIndex = 2;
            btnEditar.Text = " Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcluir.BackColor = Color.White;
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderColor = Color.FromArgb(240, 205, 200);
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 237, 235);
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.FromArgb(192, 57, 43);
            btnExcluir.Location = new Point(1153, 10);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(157, 67);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = " Excluir";
            btnExcluir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // pnlCards
            // 
            pnlCards.Controls.Add(pnlCardTotal);
            pnlCards.Controls.Add(pnlCardCompra);
            pnlCards.Controls.Add(pnlCardAluguel);
            pnlCards.Controls.Add(pnlCardVenda);
            pnlCards.Dock = DockStyle.Top;
            pnlCards.Location = new Point(40, 177);
            pnlCards.Margin = new Padding(4, 5, 4, 5);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(1362, 203);
            pnlCards.TabIndex = 1;
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.BackColor = Color.White;
            pnlCardTotal.Controls.Add(picIconeTotal);
            pnlCardTotal.Controls.Add(lblNumTotal);
            pnlCardTotal.Controls.Add(lblDescTotal);
            pnlCardTotal.Controls.Add(pnlCorTotal);
            pnlCardTotal.Location = new Point(0, 0);
            pnlCardTotal.Margin = new Padding(4, 5, 4, 5);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(313, 167);
            pnlCardTotal.TabIndex = 0;
            // 
            // picIconeTotal
            // 
            picIconeTotal.Location = new Point(236, 33);
            picIconeTotal.Margin = new Padding(4, 5, 4, 5);
            picIconeTotal.Name = "picIconeTotal";
            picIconeTotal.Size = new Size(49, 57);
            picIconeTotal.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeTotal.TabIndex = 3;
            picIconeTotal.TabStop = false;
            // 
            // lblNumTotal
            // 
            lblNumTotal.AutoSize = true;
            lblNumTotal.Font = new Font("Bahnschrift SemiBold", 22F);
            lblNumTotal.ForeColor = Color.FromArgb(18, 17, 24);
            lblNumTotal.Location = new Point(29, 23);
            lblNumTotal.Margin = new Padding(4, 0, 4, 0);
            lblNumTotal.Name = "lblNumTotal";
            lblNumTotal.Size = new Size(47, 53);
            lblNumTotal.TabIndex = 1;
            lblNumTotal.Text = "0";
            // 
            // lblDescTotal
            // 
            lblDescTotal.AutoSize = true;
            lblDescTotal.Font = new Font("Segoe UI", 9.5F);
            lblDescTotal.ForeColor = Color.FromArgb(113, 113, 130);
            lblDescTotal.Location = new Point(31, 103);
            lblDescTotal.Margin = new Padding(4, 0, 4, 0);
            lblDescTotal.Name = "lblDescTotal";
            lblDescTotal.Size = new Size(185, 25);
            lblDescTotal.TabIndex = 2;
            lblDescTotal.Text = "Clientes cadastrados";
            // 
            // pnlCorTotal
            // 
            pnlCorTotal.BackColor = Color.FromArgb(124, 58, 237);
            pnlCorTotal.Dock = DockStyle.Left;
            pnlCorTotal.Location = new Point(0, 0);
            pnlCorTotal.Margin = new Padding(4, 5, 4, 5);
            pnlCorTotal.Name = "pnlCorTotal";
            pnlCorTotal.Size = new Size(7, 167);
            pnlCorTotal.TabIndex = 0;
            // 
            // pnlCardCompra
            // 
            pnlCardCompra.BackColor = Color.White;
            pnlCardCompra.Controls.Add(picIconeCompra);
            pnlCardCompra.Controls.Add(lblNumCompra);
            pnlCardCompra.Controls.Add(lblDescCompra);
            pnlCardCompra.Controls.Add(pnlCorCompra);
            pnlCardCompra.Location = new Point(350, 0);
            pnlCardCompra.Margin = new Padding(4, 5, 4, 5);
            pnlCardCompra.Name = "pnlCardCompra";
            pnlCardCompra.Size = new Size(313, 167);
            pnlCardCompra.TabIndex = 1;
            // 
            // picIconeCompra
            // 
            picIconeCompra.Location = new Point(236, 33);
            picIconeCompra.Margin = new Padding(4, 5, 4, 5);
            picIconeCompra.Name = "picIconeCompra";
            picIconeCompra.Size = new Size(49, 57);
            picIconeCompra.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeCompra.TabIndex = 3;
            picIconeCompra.TabStop = false;
            // 
            // lblNumCompra
            // 
            lblNumCompra.AutoSize = true;
            lblNumCompra.Font = new Font("Bahnschrift SemiBold", 22F);
            lblNumCompra.ForeColor = Color.FromArgb(18, 17, 24);
            lblNumCompra.Location = new Point(29, 23);
            lblNumCompra.Margin = new Padding(4, 0, 4, 0);
            lblNumCompra.Name = "lblNumCompra";
            lblNumCompra.Size = new Size(47, 53);
            lblNumCompra.TabIndex = 1;
            lblNumCompra.Text = "0";
            // 
            // lblDescCompra
            // 
            lblDescCompra.AutoSize = true;
            lblDescCompra.Font = new Font("Segoe UI", 9.5F);
            lblDescCompra.ForeColor = Color.FromArgb(113, 113, 130);
            lblDescCompra.Location = new Point(31, 103);
            lblDescCompra.Margin = new Padding(4, 0, 4, 0);
            lblDescCompra.Name = "lblDescCompra";
            lblDescCompra.Size = new Size(156, 25);
            lblDescCompra.TabIndex = 2;
            lblDescCompra.Text = "Querem comprar";
            // 
            // pnlCorCompra
            // 
            pnlCorCompra.BackColor = Color.FromArgb(22, 150, 90);
            pnlCorCompra.Dock = DockStyle.Left;
            pnlCorCompra.Location = new Point(0, 0);
            pnlCorCompra.Margin = new Padding(4, 5, 4, 5);
            pnlCorCompra.Name = "pnlCorCompra";
            pnlCorCompra.Size = new Size(7, 167);
            pnlCorCompra.TabIndex = 0;
            // 
            // pnlCardAluguel
            // 
            pnlCardAluguel.BackColor = Color.White;
            pnlCardAluguel.Controls.Add(picIconeAluguel);
            pnlCardAluguel.Controls.Add(lblNumAluguel);
            pnlCardAluguel.Controls.Add(lblDescAluguel);
            pnlCardAluguel.Controls.Add(pnlCorAluguel);
            pnlCardAluguel.Location = new Point(700, 0);
            pnlCardAluguel.Margin = new Padding(4, 5, 4, 5);
            pnlCardAluguel.Name = "pnlCardAluguel";
            pnlCardAluguel.Size = new Size(313, 167);
            pnlCardAluguel.TabIndex = 2;
            // 
            // picIconeAluguel
            // 
            picIconeAluguel.Location = new Point(236, 33);
            picIconeAluguel.Margin = new Padding(4, 5, 4, 5);
            picIconeAluguel.Name = "picIconeAluguel";
            picIconeAluguel.Size = new Size(49, 57);
            picIconeAluguel.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeAluguel.TabIndex = 3;
            picIconeAluguel.TabStop = false;
            // 
            // lblNumAluguel
            // 
            lblNumAluguel.AutoSize = true;
            lblNumAluguel.Font = new Font("Bahnschrift SemiBold", 22F);
            lblNumAluguel.ForeColor = Color.FromArgb(18, 17, 24);
            lblNumAluguel.Location = new Point(29, 23);
            lblNumAluguel.Margin = new Padding(4, 0, 4, 0);
            lblNumAluguel.Name = "lblNumAluguel";
            lblNumAluguel.Size = new Size(47, 53);
            lblNumAluguel.TabIndex = 1;
            lblNumAluguel.Text = "0";
            // 
            // lblDescAluguel
            // 
            lblDescAluguel.AutoSize = true;
            lblDescAluguel.Font = new Font("Segoe UI", 9.5F);
            lblDescAluguel.ForeColor = Color.FromArgb(113, 113, 130);
            lblDescAluguel.Location = new Point(31, 103);
            lblDescAluguel.Margin = new Padding(4, 0, 4, 0);
            lblDescAluguel.Name = "lblDescAluguel";
            lblDescAluguel.Size = new Size(139, 25);
            lblDescAluguel.TabIndex = 2;
            lblDescAluguel.Text = "Querem alugar";
            // 
            // pnlCorAluguel
            // 
            pnlCorAluguel.BackColor = Color.FromArgb(37, 99, 235);
            pnlCorAluguel.Dock = DockStyle.Left;
            pnlCorAluguel.Location = new Point(0, 0);
            pnlCorAluguel.Margin = new Padding(4, 5, 4, 5);
            pnlCorAluguel.Name = "pnlCorAluguel";
            pnlCorAluguel.Size = new Size(7, 167);
            pnlCorAluguel.TabIndex = 0;
            // 
            // pnlCardVenda
            // 
            pnlCardVenda.BackColor = Color.White;
            pnlCardVenda.Controls.Add(picIconeVenda);
            pnlCardVenda.Controls.Add(lblNumVenda);
            pnlCardVenda.Controls.Add(lblDescVenda);
            pnlCardVenda.Controls.Add(pnlCorVenda);
            pnlCardVenda.Location = new Point(1050, 0);
            pnlCardVenda.Margin = new Padding(4, 5, 4, 5);
            pnlCardVenda.Name = "pnlCardVenda";
            pnlCardVenda.Size = new Size(313, 167);
            pnlCardVenda.TabIndex = 3;
            // 
            // picIconeVenda
            // 
            picIconeVenda.Location = new Point(236, 33);
            picIconeVenda.Margin = new Padding(4, 5, 4, 5);
            picIconeVenda.Name = "picIconeVenda";
            picIconeVenda.Size = new Size(49, 57);
            picIconeVenda.SizeMode = PictureBoxSizeMode.Zoom;
            picIconeVenda.TabIndex = 3;
            picIconeVenda.TabStop = false;
            // 
            // lblNumVenda
            // 
            lblNumVenda.AutoSize = true;
            lblNumVenda.Font = new Font("Bahnschrift SemiBold", 22F);
            lblNumVenda.ForeColor = Color.FromArgb(18, 17, 24);
            lblNumVenda.Location = new Point(29, 23);
            lblNumVenda.Margin = new Padding(4, 0, 4, 0);
            lblNumVenda.Name = "lblNumVenda";
            lblNumVenda.Size = new Size(47, 53);
            lblNumVenda.TabIndex = 1;
            lblNumVenda.Text = "0";
            // 
            // lblDescVenda
            // 
            lblDescVenda.AutoSize = true;
            lblDescVenda.Font = new Font("Segoe UI", 9.5F);
            lblDescVenda.ForeColor = Color.FromArgb(113, 113, 130);
            lblDescVenda.Location = new Point(31, 103);
            lblDescVenda.Margin = new Padding(4, 0, 4, 0);
            lblDescVenda.Name = "lblDescVenda";
            lblDescVenda.Size = new Size(143, 25);
            lblDescVenda.TabIndex = 2;
            lblDescVenda.Text = "Querem vender";
            // 
            // pnlCorVenda
            // 
            pnlCorVenda.BackColor = Color.FromArgb(192, 38, 211);
            pnlCorVenda.Dock = DockStyle.Left;
            pnlCorVenda.Location = new Point(0, 0);
            pnlCorVenda.Margin = new Padding(4, 5, 4, 5);
            pnlCorVenda.Name = "pnlCorVenda";
            pnlCorVenda.Size = new Size(7, 167);
            pnlCorVenda.TabIndex = 0;
            // 
            // pnlTopo
            // 
            pnlTopo.Controls.Add(lblTitulo);
            pnlTopo.Controls.Add(lblSubtitulo);
            pnlTopo.Controls.Add(txtBusca);
            pnlTopo.Controls.Add(btnNovo);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(40, 37);
            pnlTopo.Margin = new Padding(4, 5, 4, 5);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1362, 140);
            pnlTopo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bahnschrift SemiBold", 22F);
            lblTitulo.ForeColor = Color.FromArgb(18, 17, 24);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 53);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clientes";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(113, 113, 130);
            lblSubtitulo.Location = new Point(3, 77);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(395, 28);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie a carteira de clientes da imobiliária";
            // 
            // txtBusca
            // 
            txtBusca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBusca.BorderStyle = BorderStyle.FixedSingle;
            txtBusca.Font = new Font("Segoe UI", 11.5F);
            txtBusca.Location = new Point(628, 40);
            txtBusca.Margin = new Padding(4, 5, 4, 5);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar por nome, CPF ou cidade...";
            txtBusca.Size = new Size(465, 38);
            txtBusca.TabIndex = 0;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnNovo
            // 
            btnNovo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNovo.BackColor = Color.FromArgb(124, 58, 237);
            btnNovo.Cursor = Cursors.Hand;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 40, 217);
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnNovo.ForeColor = Color.White;
            btnNovo.Location = new Point(1119, 27);
            btnNovo.Margin = new Padding(4, 5, 4, 5);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(243, 73);
            btnNovo.TabIndex = 1;
            btnNovo.Text = " Novo cliente";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += btnNovo_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 250);
            ClientSize = new Size(1771, 1233);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1633, 1163);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horizonte Imóveis · Cadastro de Clientes";
            Load += FormPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIlustracao).EndInit();
            pnlConteudo.ResumeLayout(false);
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlListaTopo.ResumeLayout(false);
            pnlListaTopo.PerformLayout();
            pnlCards.ResumeLayout(false);
            pnlCardTotal.ResumeLayout(false);
            pnlCardTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeTotal).EndInit();
            pnlCardCompra.ResumeLayout(false);
            pnlCardCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeCompra).EndInit();
            pnlCardAluguel.ResumeLayout(false);
            pnlCardAluguel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeAluguel).EndInit();
            pnlCardVenda.ResumeLayout(false);
            pnlCardVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconeVenda).EndInit();
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox picIlustracao;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
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
        internal TextBox txtBusca;
    }
}
