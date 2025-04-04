namespace trabalhoNovo.ConsoleApp
{
    public class Chamados
    {
        public static string ApresentarMenu2()
        {
            Console.Clear();
            Console.WriteLine("___________________________");
            Console.WriteLine("Gestão de chamados");
            Console.WriteLine("___________________________");

            Console.WriteLine("escolha a operacao desejada:");
            Console.WriteLine("1 - cadastro de chamados");
            Console.WriteLine("2 - ediçao de chamados");
            Console.WriteLine("3 - exclusao de chamados");
            Console.WriteLine("4 - visualizar chamados");
            Console.WriteLine("___________________________");

            Console.WriteLine("Digite uma opcao valida");
            string opcaoEscolhida = Console.ReadLine()!;

            return opcaoEscolhida;
        }
    }
}
