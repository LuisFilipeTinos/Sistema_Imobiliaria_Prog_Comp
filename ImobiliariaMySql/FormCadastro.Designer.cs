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
            pnlFoto = new Panel();
            lblFotoTitulo = new Label();
            picFoto = new PictureBox();
            btnEscolherFoto = new Button();
            btnRemoverFoto = new Button();
            picIlustracao = new PictureBox();
            pnlCampos = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCpf = new Label();
            mtbCpf = new MaskedTextBox();
            lblTelefone = new Label();
            mtbTelefone = new MaskedTextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblValor = new Label();
            numValor = new NumericUpDown();
            lblInteresse = new Label();
            cmbInteresse = new ComboBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblCidade = new Label();
            txtCidade = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblObs = new Label();
            txtObs = new TextBox();
            lblErro = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIlustracao).BeginInit();
            pnlCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // pnlFoto
            // 
            pnlFoto.BackColor = Color.FromArgb(18, 17, 24);
            pnlFoto.Controls.Add(lblFotoTitulo);
            pnlFoto.Controls.Add(picFoto);
            pnlFoto.Controls.Add(btnEscolherFoto);
            pnlFoto.Controls.Add(btnRemoverFoto);
            pnlFoto.Controls.Add(picIlustracao);
            pnlFoto.Dock = DockStyle.Left;
            pnlFoto.Location = new Point(0, 0);
            pnlFoto.Margin = new Padding(4, 5, 4, 5);
            pnlFoto.Name = "pnlFoto";
            pnlFoto.Size = new Size(343, 1067);
            pnlFoto.TabIndex = 1;
            // 
            // lblFotoTitulo
            // 
            lblFotoTitulo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblFotoTitulo.ForeColor = Color.FromArgb(196, 190, 214);
            lblFotoTitulo.Location = new Point(0, 40);
            lblFotoTitulo.Margin = new Padding(4, 0, 4, 0);
            lblFotoTitulo.Name = "lblFotoTitulo";
            lblFotoTitulo.Size = new Size(343, 33);
            lblFotoTitulo.TabIndex = 0;
            lblFotoTitulo.Text = "FOTO DO CLIENTE";
            lblFotoTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picFoto
            // 
            picFoto.BackColor = Color.FromArgb(226, 223, 236);
            picFoto.Location = new Point(57, 93);
            picFoto.Margin = new Padding(4, 5, 4, 5);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(229, 267);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 1;
            picFoto.TabStop = false;
            // 
            // btnEscolherFoto
            // 
            btnEscolherFoto.BackColor = Color.FromArgb(124, 58, 237);
            btnEscolherFoto.Cursor = Cursors.Hand;
            btnEscolherFoto.FlatAppearance.BorderSize = 0;
            btnEscolherFoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 40, 217);
            btnEscolherFoto.FlatStyle = FlatStyle.Flat;
            btnEscolherFoto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEscolherFoto.ForeColor = Color.White;
            btnEscolherFoto.Location = new Point(43, 393);
            btnEscolherFoto.Margin = new Padding(4, 5, 4, 5);
            btnEscolherFoto.Name = "btnEscolherFoto";
            btnEscolherFoto.Size = new Size(257, 70);
            btnEscolherFoto.TabIndex = 12;
            btnEscolherFoto.Text = " Escolher foto";
            btnEscolherFoto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEscolherFoto.UseVisualStyleBackColor = false;
            btnEscolherFoto.Click += btnEscolherFoto_Click;
            // 
            // btnRemoverFoto
            // 
            btnRemoverFoto.BackColor = Color.FromArgb(18, 17, 24);
            btnRemoverFoto.Cursor = Cursors.Hand;
            btnRemoverFoto.FlatAppearance.BorderSize = 0;
            btnRemoverFoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 30, 62);
            btnRemoverFoto.FlatStyle = FlatStyle.Flat;
            btnRemoverFoto.Font = new Font("Segoe UI", 9.5F);
            btnRemoverFoto.ForeColor = Color.FromArgb(196, 190, 214);
            btnRemoverFoto.Location = new Point(43, 477);
            btnRemoverFoto.Margin = new Padding(4, 5, 4, 5);
            btnRemoverFoto.Name = "btnRemoverFoto";
            btnRemoverFoto.Size = new Size(257, 53);
            btnRemoverFoto.TabIndex = 13;
            btnRemoverFoto.Text = "Remover foto";
            btnRemoverFoto.UseVisualStyleBackColor = false;
            btnRemoverFoto.Click += btnRemoverFoto_Click;
            // 
            // picIlustracao
            // 
            picIlustracao.Dock = DockStyle.Bottom;
            picIlustracao.Location = new Point(0, 539);
            picIlustracao.Margin = new Padding(4, 5, 4, 5);
            picIlustracao.Name = "picIlustracao";
            picIlustracao.Size = new Size(343, 528);
            picIlustracao.SizeMode = PictureBoxSizeMode.Zoom;
            picIlustracao.TabIndex = 4;
            picIlustracao.TabStop = false;
            // 
            // pnlCampos
            // 
            pnlCampos.BackColor = Color.FromArgb(246, 245, 250);
            pnlCampos.Controls.Add(lblTitulo);
            pnlCampos.Controls.Add(lblSubtitulo);
            pnlCampos.Controls.Add(lblNome);
            pnlCampos.Controls.Add(txtNome);
            pnlCampos.Controls.Add(lblCpf);
            pnlCampos.Controls.Add(mtbCpf);
            pnlCampos.Controls.Add(lblTelefone);
            pnlCampos.Controls.Add(mtbTelefone);
            pnlCampos.Controls.Add(lblEmail);
            pnlCampos.Controls.Add(txtEmail);
            pnlCampos.Controls.Add(lblValor);
            pnlCampos.Controls.Add(numValor);
            pnlCampos.Controls.Add(lblInteresse);
            pnlCampos.Controls.Add(cmbInteresse);
            pnlCampos.Controls.Add(lblTipo);
            pnlCampos.Controls.Add(cmbTipo);
            pnlCampos.Controls.Add(lblCidade);
            pnlCampos.Controls.Add(txtCidade);
            pnlCampos.Controls.Add(lblBairro);
            pnlCampos.Controls.Add(txtBairro);
            pnlCampos.Controls.Add(lblObs);
            pnlCampos.Controls.Add(txtObs);
            pnlCampos.Controls.Add(lblErro);
            pnlCampos.Controls.Add(btnCancelar);
            pnlCampos.Controls.Add(btnSalvar);
            pnlCampos.Dock = DockStyle.Fill;
            pnlCampos.Location = new Point(343, 0);
            pnlCampos.Margin = new Padding(4, 5, 4, 5);
            pnlCampos.Name = "pnlCampos";
            pnlCampos.Size = new Size(886, 1067);
            pnlCampos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bahnschrift SemiBold", 18F);
            lblTitulo.ForeColor = Color.FromArgb(18, 17, 24);
            lblTitulo.Location = new Point(40, 33);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 43);
            lblTitulo.TabIndex = 100;
            lblTitulo.Text = "Novo cliente";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(113, 113, 130);
            lblSubtitulo.Location = new Point(43, 93);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(280, 25);
            lblSubtitulo.TabIndex = 101;
            lblSubtitulo.Text = "Campos com * são obrigatórios.";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNome.ForeColor = Color.FromArgb(113, 113, 130);
            lblNome.Location = new Point(43, 153);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(161, 25);
            lblNome.TabIndex = 102;
            lblNome.Text = "Nome completo *";
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 11F);
            txtNome.Location = new Point(43, 188);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.MaxLength = 120;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(799, 37);
            txtNome.TabIndex = 0;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCpf.ForeColor = Color.FromArgb(113, 113, 130);
            lblCpf.Location = new Point(43, 260);
            lblCpf.Margin = new Padding(4, 0, 4, 0);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(56, 25);
            lblCpf.TabIndex = 103;
            lblCpf.Text = "CPF *";
            // 
            // mtbCpf
            // 
            mtbCpf.BorderStyle = BorderStyle.FixedSingle;
            mtbCpf.Font = new Font("Segoe UI", 11F);
            mtbCpf.Location = new Point(43, 295);
            mtbCpf.Margin = new Padding(4, 5, 4, 5);
            mtbCpf.Mask = "000\\.000\\.000-00";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(385, 37);
            mtbCpf.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.FromArgb(113, 113, 130);
            lblTelefone.Location = new Point(457, 260);
            lblTelefone.Margin = new Padding(4, 0, 4, 0);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(205, 25);
            lblTelefone.TabIndex = 104;
            lblTelefone.Text = "Telefone / WhatsApp *";
            // 
            // mtbTelefone
            // 
            mtbTelefone.BorderStyle = BorderStyle.FixedSingle;
            mtbTelefone.Font = new Font("Segoe UI", 11F);
            mtbTelefone.Location = new Point(457, 295);
            mtbTelefone.Margin = new Padding(4, 5, 4, 5);
            mtbTelefone.Mask = "(00) 00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(385, 37);
            mtbTelefone.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(113, 113, 130);
            lblEmail.Location = new Point(43, 367);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 105;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(43, 402);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MaxLength = 120;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 37);
            txtEmail.TabIndex = 3;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblValor.ForeColor = Color.FromArgb(113, 113, 130);
            lblValor.Location = new Point(457, 367);
            lblValor.Margin = new Padding(4, 0, 4, 0);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(196, 25);
            lblValor.TabIndex = 106;
            lblValor.Text = "Valor pretendido (R$)";
            // 
            // numValor
            // 
            numValor.BorderStyle = BorderStyle.FixedSingle;
            numValor.DecimalPlaces = 2;
            numValor.Font = new Font("Segoe UI", 11F);
            numValor.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numValor.Location = new Point(457, 402);
            numValor.Margin = new Padding(4, 5, 4, 5);
            numValor.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(386, 37);
            numValor.TabIndex = 4;
            numValor.ThousandsSeparator = true;
            // 
            // lblInteresse
            // 
            lblInteresse.AutoSize = true;
            lblInteresse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInteresse.ForeColor = Color.FromArgb(113, 113, 130);
            lblInteresse.Location = new Point(43, 473);
            lblInteresse.Margin = new Padding(4, 0, 4, 0);
            lblInteresse.Name = "lblInteresse";
            lblInteresse.Size = new Size(102, 25);
            lblInteresse.TabIndex = 107;
            lblInteresse.Text = "Interesse *";
            // 
            // cmbInteresse
            // 
            cmbInteresse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInteresse.FlatStyle = FlatStyle.Flat;
            cmbInteresse.Font = new Font("Segoe UI", 11F);
            cmbInteresse.Items.AddRange(new object[] { "Compra", "Aluguel", "Venda" });
            cmbInteresse.Location = new Point(43, 508);
            cmbInteresse.Margin = new Padding(4, 5, 4, 5);
            cmbInteresse.Name = "cmbInteresse";
            cmbInteresse.Size = new Size(384, 38);
            cmbInteresse.TabIndex = 5;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipo.ForeColor = Color.FromArgb(113, 113, 130);
            lblTipo.Location = new Point(457, 473);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(151, 25);
            lblTipo.TabIndex = 108;
            lblTipo.Text = "Tipo de imóvel *";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Segoe UI", 11F);
            cmbTipo.Items.AddRange(new object[] { "Casa", "Apartamento", "Cobertura", "Terreno", "Sala comercial", "Chácara / Sítio" });
            cmbTipo.Location = new Point(457, 508);
            cmbTipo.Margin = new Padding(4, 5, 4, 5);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(384, 38);
            cmbTipo.TabIndex = 6;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCidade.ForeColor = Color.FromArgb(113, 113, 130);
            lblCidade.Location = new Point(43, 580);
            lblCidade.Margin = new Padding(4, 0, 4, 0);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(83, 25);
            lblCidade.TabIndex = 109;
            lblCidade.Text = "Cidade *";
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Segoe UI", 11F);
            txtCidade.Location = new Point(43, 615);
            txtCidade.Margin = new Padding(4, 5, 4, 5);
            txtCidade.MaxLength = 80;
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(385, 37);
            txtCidade.TabIndex = 7;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBairro.ForeColor = Color.FromArgb(113, 113, 130);
            lblBairro.Location = new Point(457, 580);
            lblBairro.Margin = new Padding(4, 0, 4, 0);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(64, 25);
            lblBairro.TabIndex = 110;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Segoe UI", 11F);
            txtBairro.Location = new Point(457, 615);
            txtBairro.Margin = new Padding(4, 5, 4, 5);
            txtBairro.MaxLength = 80;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(385, 37);
            txtBairro.TabIndex = 8;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblObs.ForeColor = Color.FromArgb(113, 113, 130);
            lblObs.Location = new Point(43, 687);
            lblObs.Margin = new Padding(4, 0, 4, 0);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(121, 25);
            lblObs.TabIndex = 111;
            lblObs.Text = "Observações";
            // 
            // txtObs
            // 
            txtObs.AcceptsReturn = true;
            txtObs.BorderStyle = BorderStyle.FixedSingle;
            txtObs.Font = new Font("Segoe UI", 11F);
            txtObs.Location = new Point(43, 722);
            txtObs.Margin = new Padding(4, 5, 4, 5);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.ScrollBars = ScrollBars.Vertical;
            txtObs.Size = new Size(799, 119);
            txtObs.TabIndex = 9;
            // 
            // lblErro
            // 
            lblErro.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblErro.ForeColor = Color.FromArgb(192, 57, 43);
            lblErro.Location = new Point(43, 860);
            lblErro.Margin = new Padding(4, 0, 4, 0);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(800, 40);
            lblErro.TabIndex = 112;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(226, 223, 236);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 235, 244);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(18, 17, 24);
            btnCancelar.Location = new Point(423, 937);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 77);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = " Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(124, 58, 237);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(109, 40, 217);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(643, 937);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(200, 77);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = " Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 245, 250);
            CancelButton = btnCancelar;
            ClientSize = new Size(1229, 1067);
            Controls.Add(pnlCampos);
            Controls.Add(pnlFoto);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de cliente";
            Load += FormCadastro_Load;
            pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIlustracao).EndInit();
            pnlCampos.ResumeLayout(false);
            pnlCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);

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
