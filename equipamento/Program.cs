namespace equipamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public int Id;
        public string Nome;
        public string Fabricante;
        public decimal Precoaquisicao;
        public DateTime DataFabricacao;

        public Equipamentos(string nome, string fabricante, decimal precoAquisicao, DateTime dataFabricacao);
       
        public string ObterNumeroSerie()
        {
            string tresPrimeirosCaracteres = Nome.Substring(0, 3).ToUpper();

            return $"{tresPrimeirosCaracteres}-{Id}";
        }


    }
}


