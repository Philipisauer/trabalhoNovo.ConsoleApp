namespace trabalhoNovo.ConsoleApp
{
    public class Program
    {
        static Equipamentos[] equipamentos = new Equipamento[100];

        static void Main(string[] args)
        {
            Tela telaEquipamento = new Tela();

            while (true)
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

                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Digite o nome do equipamento");
                        string nome = Console.ReadLine()!;

                        Console.Write("Digite o nome do fabricante");
                        string fabricante = Console.ReadLine()!;


                        Console.Write("Digite o preço da aquisiçao");
                        string precoAquisicao = Console.ReadLine()!;

                        Console.Write("Digite a data de fabricaçao do equipamento");
                        string dataFabricacao = Convert.ToDateTime(Console.ReadLine();

                        Equipamento novoEquipamento = new equipamento(nome, fabricante, precoAquisicao, dataFabricacao);

                        equipamentos[contadorEquipamentos++] = novoEquipamento;

                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("___________________________");
                        Console.WriteLine("Gestao de equipamentos");
                        Console.WriteLine("___________________________");

                        Console.WriteLine("cadastro de equipemento...");
                        Console.WriteLine("___________________________");



                        for (int i = 0; i < equipamentos.Legth; i++)
                        {
                            equipamentos e = equipamentos[i];

                            if (e == null) continue;

                            Console.WriteLine("{0, -10} | {1 -15} | {2, -11} | {3, 15} | {4, -15} | {5, -10}",
                            "Id", "Nome", "num. serie", "fabricante", "preco", "data de fabricaçao"
                            );
                        }

                        Console.WriteLine();

                    default:
                        Console.WriteLine("saindo do programa...");
                        break;
                }

                Console.ReadLine();
            }

            //Console.WriteLine("{0, -10} | {1 -15} | {2, -11} | {3, 15} | {4, -10} | {5, -10}",
                     //   "Id", "Nome", "num. serie", "fabricante", "preco", "data de fabricaçao"
                      //  );
        }
    }
}
