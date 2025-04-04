namespace trabalhoNovo.ConsoleApp
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Tela telaEquipamento = new Tela();

            while (true)
            {
                telaEquipamento.ApresentarOpcoesDeMenu();

                string opcaoEscolhida = telaEquipamento.ApresentarMenu();

                switch (opcaoEscolhida)
                {
                    case "1":
                        telaEquipamento.CadastrarEquipamento();
                        break;

                    case "2":
                        telaEquipamento.EditarEquipamento();
                        break;

                    case "3":
                        telaEquipamento.ExcluirEquipamento();
                        break;

                    case "4":   
                        telaEquipamento.VerEquipamentos(true);
                        break;

                    default:
                        Console.WriteLine("Fechando o programa...");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
