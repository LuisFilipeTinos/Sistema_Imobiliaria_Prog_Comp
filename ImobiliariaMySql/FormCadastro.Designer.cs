namespace Imobiliaria
{
    partial class FormCadastro
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
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.lblFotoTitulo = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnEscolherFoto = new System.Windows.Forms.Button();
            this.btnRemoverFoto = new System.Windows.Forms.Button();
            this.picIlustracao = new System.Windows.Forms.PictureBox();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.lblInteresse = new System.Windows.Forms.Label();
            this.cmbInteresse = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustracao)).BeginInit();
            this.pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            //
            // pnlFoto
            //
            this.pnlFoto.BackColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.pnlFoto.Controls.Add(this.lblFotoTitulo);
            this.pnlFoto.Controls.Add(this.picFoto);
            this.pnlFoto.Controls.Add(this.btnEscolherFoto);
            this.pnlFoto.Controls.Add(this.btnRemoverFoto);
            this.pnlFoto.Controls.Add(this.picIlustracao);
            this.pnlFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFoto.Location = new System.Drawing.Point(0, 0);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(240, 640);
            this.pnlFoto.TabIndex = 1;
            //
            // lblFotoTitulo
            //
            this.lblFotoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFotoTitulo.ForeColor = System.Drawing.Color.FromArgb(196, 190, 214);
            this.lblFotoTitulo.Location = new System.Drawing.Point(0, 24);
            this.lblFotoTitulo.Name = "lblFotoTitulo";
            this.lblFotoTitulo.Size = new System.Drawing.Size(240, 20);
            this.lblFotoTitulo.TabIndex = 0;
            this.lblFotoTitulo.Text = "FOTO DO CLIENTE";
            this.lblFotoTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // picFoto
            //
            this.picFoto.BackColor = System.Drawing.Color.FromArgb(226, 223, 236);
            this.picFoto.Location = new System.Drawing.Point(40, 56);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(160, 160);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto.TabIndex = 1;
            this.picFoto.TabStop = false;
            //
            // btnEscolherFoto
            //
            this.btnEscolherFoto.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnEscolherFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolherFoto.FlatAppearance.BorderSize = 0;
            this.btnEscolherFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 40, 217);
            this.btnEscolherFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscolherFoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEscolherFoto.ForeColor = System.Drawing.Color.White;
            this.btnEscolherFoto.Location = new System.Drawing.Point(30, 236);
            this.btnEscolherFoto.Name = "btnEscolherFoto";
            this.btnEscolherFoto.Size = new System.Drawing.Size(180, 42);
            this.btnEscolherFoto.TabIndex = 12;
            this.btnEscolherFoto.Text = " Escolher foto";
            this.btnEscolherFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEscolherFoto.UseVisualStyleBackColor = false;
            this.btnEscolherFoto.Click += new System.EventHandler(this.btnEscolherFoto_Click);
            //
            // btnRemoverFoto
            //
            this.btnRemoverFoto.BackColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.btnRemoverFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverFoto.FlatAppearance.BorderSize = 0;
            this.btnRemoverFoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 30, 62);
            this.btnRemoverFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFoto.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnRemoverFoto.ForeColor = System.Drawing.Color.FromArgb(196, 190, 214);
            this.btnRemoverFoto.Location = new System.Drawing.Point(30, 286);
            this.btnRemoverFoto.Name = "btnRemoverFoto";
            this.btnRemoverFoto.Size = new System.Drawing.Size(180, 32);
            this.btnRemoverFoto.TabIndex = 13;
            this.btnRemoverFoto.Text = "Remover foto";
            this.btnRemoverFoto.UseVisualStyleBackColor = false;
            this.btnRemoverFoto.Click += new System.EventHandler(this.btnRemoverFoto_Click);
            //
            // picIlustracao
            //
            this.picIlustracao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picIlustracao.Location = new System.Drawing.Point(0, 323);
            this.picIlustracao.Name = "picIlustracao";
            this.picIlustracao.Size = new System.Drawing.Size(240, 317);
            this.picIlustracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIlustracao.TabIndex = 4;
            this.picIlustracao.TabStop = false;
            //
            // pnlCampos
            //
            this.pnlCampos.BackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            this.pnlCampos.Controls.Add(this.lblTitulo);
            this.pnlCampos.Controls.Add(this.lblSubtitulo);
            this.pnlCampos.Controls.Add(this.lblNome);
            this.pnlCampos.Controls.Add(this.txtNome);
            this.pnlCampos.Controls.Add(this.lblCpf);
            this.pnlCampos.Controls.Add(this.mtbCpf);
            this.pnlCampos.Controls.Add(this.lblTelefone);
            this.pnlCampos.Controls.Add(this.mtbTelefone);
            this.pnlCampos.Controls.Add(this.lblEmail);
            this.pnlCampos.Controls.Add(this.txtEmail);
            this.pnlCampos.Controls.Add(this.lblValor);
            this.pnlCampos.Controls.Add(this.numValor);
            this.pnlCampos.Controls.Add(this.lblInteresse);
            this.pnlCampos.Controls.Add(this.cmbInteresse);
            this.pnlCampos.Controls.Add(this.lblTipo);
            this.pnlCampos.Controls.Add(this.cmbTipo);
            this.pnlCampos.Controls.Add(this.lblCidade);
            this.pnlCampos.Controls.Add(this.txtCidade);
            this.pnlCampos.Controls.Add(this.lblBairro);
            this.pnlCampos.Controls.Add(this.txtBairro);
            this.pnlCampos.Controls.Add(this.lblObs);
            this.pnlCampos.Controls.Add(this.txtObs);
            this.pnlCampos.Controls.Add(this.lblErro);
            this.pnlCampos.Controls.Add(this.btnCancelar);
            this.pnlCampos.Controls.Add(this.btnSalvar);
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCampos.Location = new System.Drawing.Point(240, 0);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(620, 640);
            this.pnlCampos.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 29);
            this.lblTitulo.TabIndex = 100;
            this.lblTitulo.Text = "Novo cliente";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblSubtitulo.Location = new System.Drawing.Point(30, 56);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(200, 17);
            this.lblSubtitulo.TabIndex = 101;
            this.lblSubtitulo.Text = "Campos com * são obrigatórios.";
            //
            // lblNome
            //
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblNome.Location = new System.Drawing.Point(30, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(105, 15);
            this.lblNome.TabIndex = 102;
            this.lblNome.Text = "Nome completo *";
            //
            // txtNome
            //
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNome.Location = new System.Drawing.Point(30, 113);
            this.txtNome.MaxLength = 120;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(560, 27);
            this.txtNome.TabIndex = 0;
            //
            // lblCpf
            //
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblCpf.Location = new System.Drawing.Point(30, 156);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(37, 15);
            this.lblCpf.TabIndex = 103;
            this.lblCpf.Text = "CPF *";
            //
            // mtbCpf
            //
            this.mtbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCpf.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mtbCpf.Location = new System.Drawing.Point(30, 177);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(270, 27);
            this.mtbCpf.TabIndex = 1;
            //
            // lblTelefone
            //
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblTelefone.Location = new System.Drawing.Point(320, 156);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(140, 15);
            this.lblTelefone.TabIndex = 104;
            this.lblTelefone.Text = "Telefone / WhatsApp *";
            //
            // mtbTelefone
            //
            this.mtbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbTelefone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mtbTelefone.Location = new System.Drawing.Point(320, 177);
            this.mtbTelefone.Mask = "(00) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(270, 27);
            this.mtbTelefone.TabIndex = 2;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblEmail.Location = new System.Drawing.Point(30, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 105;
            this.lblEmail.Text = "E-mail";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(30, 241);
            this.txtEmail.MaxLength = 120;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 27);
            this.txtEmail.TabIndex = 3;
            //
            // lblValor
            //
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblValor.Location = new System.Drawing.Point(320, 220);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(130, 15);
            this.lblValor.TabIndex = 106;
            this.lblValor.Text = "Valor pretendido (R$)";
            //
            // numValor
            //
            this.numValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.numValor.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numValor.Location = new System.Drawing.Point(320, 241);
            this.numValor.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(270, 27);
            this.numValor.TabIndex = 4;
            this.numValor.ThousandsSeparator = true;
            //
            // lblInteresse
            //
            this.lblInteresse.AutoSize = true;
            this.lblInteresse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInteresse.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblInteresse.Location = new System.Drawing.Point(30, 284);
            this.lblInteresse.Name = "lblInteresse";
            this.lblInteresse.Size = new System.Drawing.Size(70, 15);
            this.lblInteresse.TabIndex = 107;
            this.lblInteresse.Text = "Interesse *";
            //
            // cmbInteresse
            //
            this.cmbInteresse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbInteresse.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbInteresse.Items.AddRange(new object[] {
            "Compra",
            "Aluguel",
            "Venda"});
            this.cmbInteresse.Location = new System.Drawing.Point(30, 305);
            this.cmbInteresse.Name = "cmbInteresse";
            this.cmbInteresse.Size = new System.Drawing.Size(270, 28);
            this.cmbInteresse.TabIndex = 5;
            //
            // lblTipo
            //
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblTipo.Location = new System.Drawing.Point(320, 284);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 15);
            this.lblTipo.TabIndex = 108;
            this.lblTipo.Text = "Tipo de imóvel *";
            //
            // cmbTipo
            //
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTipo.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Cobertura",
            "Terreno",
            "Sala comercial",
            "Chácara / Sítio"});
            this.cmbTipo.Location = new System.Drawing.Point(320, 305);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(270, 28);
            this.cmbTipo.TabIndex = 6;
            //
            // lblCidade
            //
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCidade.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblCidade.Location = new System.Drawing.Point(30, 348);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 15);
            this.lblCidade.TabIndex = 109;
            this.lblCidade.Text = "Cidade *";
            //
            // txtCidade
            //
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCidade.Location = new System.Drawing.Point(30, 369);
            this.txtCidade.MaxLength = 80;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(270, 27);
            this.txtCidade.TabIndex = 7;
            //
            // lblBairro
            //
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBairro.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblBairro.Location = new System.Drawing.Point(320, 348);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(42, 15);
            this.lblBairro.TabIndex = 110;
            this.lblBairro.Text = "Bairro";
            //
            // txtBairro
            //
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBairro.Location = new System.Drawing.Point(320, 369);
            this.txtBairro.MaxLength = 80;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(270, 27);
            this.txtBairro.TabIndex = 8;
            //
            // lblObs
            //
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(113, 113, 130);
            this.lblObs.Location = new System.Drawing.Point(30, 412);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(80, 15);
            this.lblObs.TabIndex = 111;
            this.lblObs.Text = "Observações";
            //
            // txtObs
            //
            this.txtObs.AcceptsReturn = true;
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtObs.Location = new System.Drawing.Point(30, 433);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(560, 72);
            this.txtObs.TabIndex = 9;
            //
            // lblErro
            //
            this.lblErro.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.lblErro.Location = new System.Drawing.Point(30, 516);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(560, 24);
            this.lblErro.TabIndex = 112;
            //
            // btnCancelar
            //
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(226, 223, 236);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(237, 235, 244);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(18, 17, 24);
            this.btnCancelar.Location = new System.Drawing.Point(296, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 46);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            //
            // btnSalvar
            //
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(109, 40, 217);
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(450, 562);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(140, 46);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = " Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            //
            // FormCadastro
            //
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 245, 250);
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(860, 640);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlFoto);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustracao)).EndInit();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label lblFotoTitulo;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnEscolherFoto;
        private System.Windows.Forms.Button btnRemoverFoto;
        private System.Windows.Forms.PictureBox picIlustracao;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblInteresse;
        private System.Windows.Forms.ComboBox cmbInteresse;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}
