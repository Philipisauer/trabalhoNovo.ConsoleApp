namespace trabalhoNovo.ConsoleApp
{
    public class Equipamento
    {
        public int Id;
        public string Nome;
        public string Fabricante;
        public decimal PrecoCompra;
        public DateTime DataFabricacao;

        public Equipamento(string nome, string fabricante, decimal precoCompra, DateTime dataFabricacao) 
        {
            Nome = nome;
            Fabricante = fabricante;
            PrecoCompra = precoCompra;
            DataFabricacao = dataFabricacao;
        }

        public string ObterNumeroSerie()
        {
            string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper();

            return $"{tresPrimeirosCaracteres}-{Id}";
        }

    }
}
