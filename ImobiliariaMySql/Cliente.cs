namespace Imobiliaria
{
    // Representa um cliente da imobiliária (cada cliente é uma "linha" do banco)
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public string Cpf { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Email { get; set; } = "";
        public string Interesse { get; set; } = "";      // Compra, Aluguel ou Venda
        public string TipoImovel { get; set; } = "";     // Casa, Apartamento...
        public decimal Valor { get; set; }
        public string Cidade { get; set; } = "";
        public string Bairro { get; set; } = "";
        public string Observacoes { get; set; } = "";
        public string Foto { get; set; } = "";           // nome do arquivo dentro da pasta "fotos"
        public DateTime DataCadastro { get; set; }
    }
}
