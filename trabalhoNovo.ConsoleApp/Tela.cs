namespace trabalhoNovo.ConsoleApp
{
    public class Tela
    {
        public Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos = 0;

        public string ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("___________________________");
            Console.WriteLine("Gestao de equipamentos");
            Console.WriteLine("___________________________");

            Console.WriteLine("escolha a operacao desejada:");
            Console.WriteLine("1 - cadastro de equipemento");
            Console.WriteLine("2 - ediçao de equipemento");
            Console.WriteLine("3 - exclusao de equipemento");
            Console.WriteLine("4 - visualizar equipamentos");
            Console.WriteLine("___________________________");

            Console.WriteLine("Digite uma opcao valida");
            string opcaoEscolhida = Console.ReadLine()!;

            return opcaoEscolhida;
        }
        public void CadastrarEquipamento()
        {
            Console.Clear();
            Console.Write("Digite o nome do equipamento");
            string nome = Console.ReadLine()!;

            Console.Write("Digite o nome do fabricante");
            string fabricante = Console.ReadLine()!;

            Console.Write("Digite o preço da compra");
            decimal precoCompra = Convert.ToDecimal(Console.ReadLine())!;

            Console.Write("Digite a data de fabricaçao do equipamento: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = new Equipamento(nome, fabricante, precoCompra, dataFabricacao);
            novoEquipamento.Id = GeradorId.GerarIDEquipamento();

            equipamentos[contadorEquipamentos++] = novoEquipamento;
        }

        public void EditarEquipamento()
        {
            Console.Clear();
            Console.WriteLine("___________________________");
            Console.WriteLine("Gestao de equipamentos");
            Console.WriteLine("___________________________");

            Console.WriteLine("editar equipamentos");
            Console.WriteLine("___________________________");

            VerEquipamentos(false);

            Console.Write("Digite o ID do equipamento que procura: ");
            int idSele = Convert.ToInt32(Console.ReadLine())!;

            Console.WriteLine();

            Console.Clear();
            Console.Write("Digite o nome do equipamento");
            string nome = Console.ReadLine()!;

            Console.Write("Digite o nome do fabricante");
            string fabricante = Console.ReadLine()!;

            Console.Write("Digite o preço da compra");
            decimal precoCompra = Convert.ToDecimal(Console.ReadLine())!;

            Console.Write("Digite a data de fabricaçao do equipamento: ");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = new Equipamento(nome, fabricante, precoCompra, dataFabricacao);

            bool conseguiuEditar = false;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;

                else if (equipamentos[i].Id == idSele)
                {
                    equipamentos[i].Nome = novoEquipamento.Nome;
                    equipamentos[i].Fabricante = novoEquipamento.Fabricante;
                    equipamentos[i].PrecoCompra = novoEquipamento.PrecoCompra;
                    equipamentos[i].DataFabricacao = novoEquipamento.DataFabricacao;

                    conseguiuEditar = true;
                }
            }

            if (!conseguiuEditar)
            {
                Console.WriteLine("houve um erro na ediçao...");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Equipamento editado!");
        }

        public void ExcluirEquipamento()
        {
            Console.Clear();
            Console.WriteLine("___________________________");
            Console.WriteLine("Gestao de equipamentos");
            Console.WriteLine("___________________________");

            Console.WriteLine("excluindo os equipemento...");
            Console.WriteLine("___________________________");

            VerEquipamentos(false);

            Console.Write("Digite o ID do equipamento que procura: ");
            int idSele = Convert.ToInt32(Console.ReadLine())!;

            bool conseguiuExcluir = false;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;

                else if (equipamentos[i].Id == idSele)
                {
                    equipamentos[i] = null;
                    conseguiuExcluir = true;
                }
            }

            if (!conseguiuExcluir)
            {
                
                    Console.WriteLine("houve um erro na exclusao...");
                    return;
            }
                Console.WriteLine();
                Console.WriteLine("Equipamento excluido!");
            }

        public void VerEquipamentos(bool exibitTitulo)
        {
            if (exibitTitulo)
            {
                Console.Clear();
                Console.WriteLine("___________________________");
                Console.WriteLine("Gestao de equipamentos");
                Console.WriteLine("___________________________");

                Console.WriteLine("visualizando os equipementos...");
                Console.WriteLine("___________________________");
            }

            Console.WriteLine();

            Console.WriteLine(
            "{0, -10} | {1 -15} | {2, -11} | {3, 15} | {4, -15} | {5, -10}",
            "Id", "Nome", "num. serie", "fabricante", "preco", "data de fabricaçao"
            );

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento eq = equipamentos[i];

                if (eq == null) continue;

                Console.WriteLine("{0, -10} | {1 -15} | {2, -11} | {3, 15} | {4, -15} | {5, -10}",
                eq.Id, eq.Nome, eq.ObterNumeroSerie(), eq.Fabricante, eq.PrecoCompra.ToString("C2"), eq.DataFabricacao.ToShortDateString()
                );
            }

            Console.WriteLine();
        }


    }
}
