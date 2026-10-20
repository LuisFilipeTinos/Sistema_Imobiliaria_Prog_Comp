using MySqlConnector;

namespace Imobiliaria
{
    // Todas as operações com o banco MySQL ficam aqui.
    // Os formulários só chamam: Banco.Listar, Banco.Inserir, Banco.Atualizar...
    public static class Banco
    {
        static string conexao = "Server=localhost;Port=3306;Database=imobiliaria;Uid=root;Pwd=;" +
                                "SslMode=None;AllowPublicKeyRetrieval=True;";

        // Testa a conexão quando o programa abre
        public static void Carregar()
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();
            }
        }

        // Devolve os clientes. Se "busca" tiver texto, filtra por nome, CPF ou cidade.
        public static List<Cliente> Listar(string busca)
        {
            List<Cliente> resultado = new List<Cliente>();

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string sql = "SELECT * FROM clientes " +
                             "WHERE nome LIKE @busca OR cpf LIKE @busca OR cidade LIKE @busca " +
                             "ORDER BY nome";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@busca", "%" + busca.Trim() + "%");

                MySqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    resultado.Add(LerCliente(leitor));
                }
            }
            return resultado;
        }

        public static Cliente BuscarPorId(int id)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM clientes WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader leitor = cmd.ExecuteReader();
                if (leitor.Read())
                    return LerCliente(leitor);
            }
            return null;
        }

        public static void Inserir(Cliente cliente)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string sql = "INSERT INTO clientes " +
                             "(nome, cpf, telefone, email, interesse, tipo_imovel, valor, cidade, bairro, observacoes, foto, data_cadastro) " +
                             "VALUES (@nome, @cpf, @telefone, @email, @interesse, @tipo, @valor, @cidade, @bairro, @obs, @foto, @data)";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                PreencherParametros(cmd, cliente);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Atualizar(Cliente cliente)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string sql = "UPDATE clientes SET " +
                             "nome = @nome, cpf = @cpf, telefone = @telefone, email = @email, " +
                             "interesse = @interesse, tipo_imovel = @tipo, valor = @valor, cidade = @cidade, " +
                             "bairro = @bairro, observacoes = @obs, foto = @foto, data_cadastro = @data " +
                             "WHERE id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                PreencherParametros(cmd, cliente);
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Excluir(int id)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM clientes WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Verifica se já existe OUTRO cliente com o mesmo CPF
        public static bool CpfJaExiste(string cpf, int idIgnorar)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM clientes WHERE cpf = @cpf AND id <> @id", con);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@id", idIgnorar);

                int quantidade = Convert.ToInt32(cmd.ExecuteScalar());
                return quantidade > 0;
            }
        }

        // Os parâmetros (@nome, @cpf...) evitam SQL Injection
        static void PreencherParametros(MySqlCommand cmd, Cliente cliente)
        {
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
            cmd.Parameters.AddWithValue("@email", cliente.Email);
            cmd.Parameters.AddWithValue("@interesse", cliente.Interesse);
            cmd.Parameters.AddWithValue("@tipo", cliente.TipoImovel);
            cmd.Parameters.AddWithValue("@valor", cliente.Valor);
            cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("@obs", cliente.Observacoes);
            cmd.Parameters.AddWithValue("@foto", cliente.Foto);
            cmd.Parameters.AddWithValue("@data", cliente.DataCadastro);
        }

        // Transforma a linha lida do banco em um objeto Cliente
        static Cliente LerCliente(MySqlDataReader leitor)
        {
            Cliente c = new Cliente();
            c.Id = Convert.ToInt32(leitor["id"]);
            c.Nome = leitor["nome"].ToString();
            c.Cpf = leitor["cpf"].ToString();
            c.Telefone = leitor["telefone"].ToString();
            c.Email = leitor["email"].ToString();
            c.Interesse = leitor["interesse"].ToString();
            c.TipoImovel = leitor["tipo_imovel"].ToString();
            c.Valor = Convert.ToDecimal(leitor["valor"]);
            c.Cidade = leitor["cidade"].ToString();
            c.Bairro = leitor["bairro"].ToString();
            c.Observacoes = leitor["observacoes"].ToString();
            c.Foto = leitor["foto"].ToString();
            c.DataCadastro = Convert.ToDateTime(leitor["data_cadastro"]);
            return c;
        }
    }
}
