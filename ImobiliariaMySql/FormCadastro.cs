using System.Drawing.Drawing2D;

namespace Imobiliaria
{
    public partial class FormCadastro : Form
    {
        // Cliente que está sendo editado. Se for null, é um cadastro novo.
        Cliente clienteEditando;

        // Nome do arquivo da foto (fica guardado na pasta "fotos" do programa)
        string fotoArquivo = "";

        string pastaImagens = Path.Combine(Application.StartupPath, "Assets");
        string pastaFotos = Path.Combine(Application.StartupPath, "fotos");

        public FormCadastro(Cliente cliente)
        {
            InitializeComponent();
            clienteEditando = cliente;
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            // Imagens e ícones
            Icon = new Icon(Path.Combine(pastaImagens, "app.ico"));
            picIlustracao.Image = Image.FromFile(Path.Combine(pastaImagens, "ilustracao_lateral.png"));
            btnEscolherFoto.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "camera_branco.png"));
            btnSalvar.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "salvar_branco.png"));
            btnCancelar.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "fechar_preto.png"));

            // Deixa a foto redonda: recorta o PictureBox em formato de círculo
            GraphicsPath circulo = new GraphicsPath();
            circulo.AddEllipse(0, 0, picFoto.Width, picFoto.Height);
            picFoto.Region = new Region(circulo);

            if (clienteEditando == null)
            {
                lblTitulo.Text = "Novo cliente";
                btnSalvar.Text = " Cadastrar";
            }
            else
            {
                // Edição: preenche os campos com os dados do cliente
                lblTitulo.Text = "Editar cliente";
                txtNome.Text = clienteEditando.Nome;
                mtbCpf.Text = clienteEditando.Cpf;
                mtbTelefone.Text = clienteEditando.Telefone;
                txtEmail.Text = clienteEditando.Email;
                numValor.Value = clienteEditando.Valor;
                cmbInteresse.SelectedItem = clienteEditando.Interesse;
                cmbTipo.SelectedItem = clienteEditando.TipoImovel;
                txtCidade.Text = clienteEditando.Cidade;
                txtBairro.Text = clienteEditando.Bairro;
                txtObs.Text = clienteEditando.Observacoes;
                fotoArquivo = clienteEditando.Foto;
            }

            MostrarFoto();
        }

        // Mostra a foto do cliente, ou o avatar padrão se não houver foto
        void MostrarFoto()
        {
            string caminho = Path.Combine(pastaFotos, fotoArquivo);

            if (fotoArquivo != "" && File.Exists(caminho))
                picFoto.Image = Image.FromFile(caminho);
            else
                picFoto.Image = Image.FromFile(Path.Combine(pastaImagens, "avatar.png"));
        }

        private void btnEscolherFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Title = "Escolher foto do cliente";
            janela.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (janela.ShowDialog() == DialogResult.OK)
            {
                // Copia a foto para a pasta "fotos" com um nome único
                Directory.CreateDirectory(pastaFotos);
                string novoNome = DateTime.Now.Ticks + Path.GetExtension(janela.FileName);
                File.Copy(janela.FileName, Path.Combine(pastaFotos, novoNome));

                fotoArquivo = novoNome;
                MostrarFoto();
            }
        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {
            fotoArquivo = "";
            MostrarFoto();
        }

        // Mostra a mensagem de erro e coloca o cursor no campo com problema
        void MostrarErro(string mensagem, Control campo)
        {
            lblErro.Text = mensagem;
            campo.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblErro.Text = "";

            // ---------- Validações ----------
            if (txtNome.Text.Trim() == "")
            {
                MostrarErro("Informe o nome do cliente.", txtNome);
                return;
            }
            if (!mtbCpf.MaskCompleted)
            {
                MostrarErro("Preencha o CPF completo.", mtbCpf);
                return;
            }
            if (!mtbTelefone.MaskCompleted)
            {
                MostrarErro("Preencha o telefone completo, com DDD.", mtbTelefone);
                return;
            }
            if (txtEmail.Text != "" && !txtEmail.Text.Contains("@"))
            {
                MostrarErro("O e-mail informado não é válido.", txtEmail);
                return;
            }
            if (cmbInteresse.SelectedIndex == -1)
            {
                MostrarErro("Selecione o interesse do cliente.", cmbInteresse);
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MostrarErro("Selecione o tipo de imóvel.", cmbTipo);
                return;
            }
            if (txtCidade.Text.Trim() == "")
            {
                MostrarErro("Informe a cidade.", txtCidade);
                return;
            }

            int idAtual = 0;
            if (clienteEditando != null)
                idAtual = clienteEditando.Id;

            if (Banco.CpfJaExiste(mtbCpf.Text, idAtual))
            {
                MostrarErro("Já existe um cliente cadastrado com este CPF.", mtbCpf);
                return;
            }

            // ---------- Monta o objeto com os dados da tela ----------
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text.Trim();
            cliente.Cpf = mtbCpf.Text;
            cliente.Telefone = mtbTelefone.Text;
            cliente.Email = txtEmail.Text.Trim();
            cliente.Valor = numValor.Value;
            cliente.Interesse = cmbInteresse.Text;
            cliente.TipoImovel = cmbTipo.Text;
            cliente.Cidade = txtCidade.Text.Trim();
            cliente.Bairro = txtBairro.Text.Trim();
            cliente.Observacoes = txtObs.Text.Trim();
            cliente.Foto = fotoArquivo;

            // ---------- Salva ----------
            try
            {
                if (clienteEditando == null)
                {
                    cliente.DataCadastro = DateTime.Now;
                    Banco.Inserir(cliente);
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cliente.Id = clienteEditando.Id;
                    cliente.DataCadastro = clienteEditando.DataCadastro;
                    Banco.Atualizar(cliente);
                    MessageBox.Show("Alterações salvas!", "Cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;   // fecha a janela e avisa a tela principal
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível salvar.\n\n" + erro.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
