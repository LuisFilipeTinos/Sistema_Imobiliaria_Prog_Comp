namespace Imobiliaria
{
    // "Banco de dados" feito com uma List.
    public static class Banco
    {
        // A "tabela" de clientes
        static List<Cliente> clientes = new List<Cliente>();

        // Próximo código (Id) a ser usado. Funciona como o auto incremento do banco.
        static int proximoId = 1;

        public static void Carregar()
        {
            CriarExemplos();
        }  

        // Devolve os clientes. Se "busca" tiver texto, filtra por nome, CPF ou cidade.
        public static List<Cliente> Listar(string busca)
        {
            List<Cliente> resultado = new List<Cliente>();
            busca = busca.Trim().ToLower();

            foreach (Cliente c in clientes)
            {
                if (busca == "" ||
                    c.Nome.ToLower().Contains(busca) ||
                    c.Cpf.Contains(busca) ||
                    c.Cidade.ToLower().Contains(busca))
                {
                    resultado.Add(c);
                }
            }
            return resultado;
        }

        public static Cliente BuscarPorId(int id)
        {
            return clientes.Where(x => x.Id == id).FirstOrDefault();
        }

        public static void Inserir(Cliente cliente)
        {
            cliente.Id = proximoId;
            proximoId++;

            clientes.Add(cliente);
        }

        public static void Atualizar(Cliente cliente)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Id == cliente.Id)
                {
                    clientes[i] = cliente;   // troca o cliente antigo pelo novo
                    break;
                }
            }
        }

        public static void Excluir(int id)
        {
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Id == id)
                {
                    clientes.RemoveAt(i);
                    break;
                }
            }
        }

        // Verifica se já existe OUTRO cliente com o mesmo CPF
        public static bool CpfJaExiste(string cpf, int idIgnorar)
        {
            foreach (Cliente c in clientes)
            {
                if (c.Cpf == cpf && c.Id != idIgnorar)
                    return true;
            }
            return false;
        }

        static void CriarExemplos()
        {
            Inserir(new Cliente { Nome = "Mariana Albuquerque", Cpf = "787.789.328-07", Telefone = "(11) 98765-4321",
                Email = "mariana@email.com", Interesse = "Compra", TipoImovel = "Apartamento", Valor = 650000,
                Cidade = "São Paulo", Bairro = "Vila Mariana", DataCadastro = DateTime.Today.AddDays(-20) });

            Inserir(new Cliente { Nome = "Ricardo Fontes", Cpf = "792.174.218-12", Telefone = "(11) 99123-4567",
                Email = "ricardo@email.com", Interesse = "Aluguel", TipoImovel = "Sala comercial", Valor = 4500,
                Cidade = "São Paulo", Bairro = "Pinheiros", DataCadastro = DateTime.Today.AddDays(-12) });

            Inserir(new Cliente { Nome = "Helena Duarte", Cpf = "096.792.908-32", Telefone = "(19) 98222-1100",
                Email = "helena@email.com", Interesse = "Venda", TipoImovel = "Casa", Valor = 980000,
                Cidade = "Campinas", Bairro = "Cambuí", DataCadastro = DateTime.Today.AddDays(-7) });

            Inserir(new Cliente { Nome = "Camila Rocha", Cpf = "793.834.701-94", Telefone = "(21) 99654-8899",
                Email = "camila@email.com", Interesse = "Aluguel", TipoImovel = "Apartamento", Valor = 3200,
                Cidade = "Rio de Janeiro", Bairro = "Botafogo", DataCadastro = DateTime.Today.AddDays(-2) });
        }
    }
}
