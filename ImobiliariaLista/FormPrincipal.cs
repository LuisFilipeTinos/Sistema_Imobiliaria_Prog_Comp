using System.Globalization;

namespace Imobiliaria
{
    public partial class FormPrincipal : Form
    {
        // Pasta onde ficam as imagens e ícones do sistema
        string pastaImagens = Path.Combine(Application.StartupPath, "Assets");

        // Fonte em negrito usada na coluna "Interesse"
        Font fonteNegrito = new Font("Segoe UI", 10F, FontStyle.Bold);

        // Formato brasileiro para mostrar dinheiro (R$ 1.000,00)
        CultureInfo brasil = new CultureInfo("pt-BR");

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarImagens();

            try
            {
                Banco.Carregar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível abrir o banco de dados.\n\n" + erro.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            AtualizarLista();
        }

        // Coloca a logo, os ícones e a ilustração nos controles
        void CarregarImagens()
        {
            Icon = new Icon(Path.Combine(pastaImagens, "app.ico"));
            picLogo.Image = Image.FromFile(Path.Combine(pastaImagens, "logo.png"));
            picIlustracao.Image = Image.FromFile(Path.Combine(pastaImagens, "ilustracao_lateral.png"));

            btnMenuClientes.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "clientes_roxoclaro.png"));
            btnMenuNovo.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "novo_branco.png"));
            btnMenuSobre.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "sobre_branco.png"));

            btnNovo.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "mais_branco.png"));
            btnEditar.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "editar_preto.png"));
            btnExcluir.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "excluir_vermelho.png"));

            picIconeTotal.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "clientes_roxo.png"));
            picIconeCompra.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "chave_roxo.png"));
            picIconeAluguel.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "aluguel_roxo.png"));
            picIconeVenda.Image = Image.FromFile(Path.Combine(pastaImagens, "Icones", "venda_roxo.png"));
        }

        // Preenche a tabela (DataGridView) com os clientes
        void AtualizarLista()
        {
            dgvClientes.Rows.Clear();

            List<Cliente> clientes = Banco.Listar(txtBusca.Text);

            foreach (Cliente c in clientes)
            {
                dgvClientes.Rows.Add(
                    c.Id,
                    c.Nome,
                    c.Cpf,
                    c.Telefone,
                    c.Interesse,
                    c.TipoImovel,
                    c.Cidade,
                    c.Valor.ToString("C", brasil),
                    c.DataCadastro.ToString("dd/MM/yyyy"));
            }

            lblTotalLista.Text = clientes.Count + " cliente(s) na lista";
            AtualizarCards();
        }

        // Conta quantos clientes há de cada tipo de interesse
        void AtualizarCards()
        {
            List<Cliente> todos = Banco.Listar("");
            int compra = 0;
            int aluguel = 0;
            int venda = 0;

            foreach (Cliente c in todos)
            {
                if (c.Interesse == "Compra") compra++;
                if (c.Interesse == "Aluguel") aluguel++;
                if (c.Interesse == "Venda") venda++;
            }

            lblNumTotal.Text = todos.Count.ToString();
            lblNumCompra.Text = compra.ToString();
            lblNumAluguel.Text = aluguel.ToString();
            lblNumVenda.Text = venda.ToString();
        }

        // Devolve o Id do cliente selecionado na tabela (0 = nenhum)
        int IdSelecionado()
        {
            if (dgvClientes.CurrentRow == null)
                return 0;

            return Convert.ToInt32(dgvClientes.CurrentRow.Cells["colId"].Value);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastro tela = new FormCadastro(null);   // null = cliente novo

            if (tela.ShowDialog() == DialogResult.OK)
                AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = IdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente na lista.", "Editar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cliente cliente = Banco.BuscarPorId(id);
            FormCadastro tela = new FormCadastro(cliente);

            if (tela.ShowDialog() == DialogResult.OK)
                AtualizarLista();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = IdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente na lista.", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nome = dgvClientes.CurrentRow.Cells["colNome"].Value.ToString();
            DialogResult resposta = MessageBox.Show("Deseja excluir o cliente " + nome + "?",
                "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                Banco.Excluir(id);
                AtualizarLista();
            }
        }

        // Duplo clique em uma linha também abre a edição
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnEditar_Click(sender, e);
        }

        // Pinta a coluna "Interesse" com uma cor para cada tipo
        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].Name != "colInteresse" || e.Value == null)
                return;

            string interesse = e.Value.ToString();
            e.CellStyle.Font = fonteNegrito;

            if (interesse == "Compra")
                e.CellStyle.ForeColor = Color.FromArgb(22, 150, 90);      // verde
            else if (interesse == "Aluguel")
                e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235);      // azul
            else if (interesse == "Venda")
                e.CellStyle.ForeColor = Color.FromArgb(192, 38, 211);     // magenta
        }

        // A busca acontece enquanto o usuário digita
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            txtBusca.Text = "";
            AtualizarLista();
        }

        private void btnMenuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Horizonte Imóveis - Cadastro de Clientes\n\n" +
                "Dica: dê um duplo clique em um cliente para editar.",
                "Sobre o sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
