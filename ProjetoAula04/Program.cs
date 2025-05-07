using ProjetoAula04.Controllers;


namespace ProjetoAula04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine
            (@"
SISTEMA DE CONTROLE DE CLIENTES:

    (1) CADASTRAR
    (2) CONSULTAR
    (3) ATUALIZAR
    (4) EXCLUIR

INFORME A OPÇÃO DESEJADA:"
            );

            var opcao = Console.ReadLine();

            var clienteController = new ClienteController();

            switch (opcao)
            {
                case "1": clienteController.CadastrarCliente(); break;
                case "2": clienteController.ConsultarClientes(); break;
                case "3": clienteController.AtualizarCliente(); break;
                case "4": clienteController.ExcluirCliente(); break;
                default:
                    Console.WriteLine("\nOPÇÃO INVÁLIDA!");
                    break;
            }

            Console.WriteLine("\nDESEJA CONTINUAR? (y/n)");
            opcao = Console.ReadLine();
            if (opcao.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args); // recursividade
            }
            else
            {
                Console.WriteLine("Pressione Enter para sair.");
            }
                Console.ReadKey();
        }
    }
}
