using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAula04.Entities;
using ProjetoAula04.Repositories;

namespace ProjetoAula04.Controllers
{
    /// <summary>
    /// Controlador para realizar as operações de cliente.
    /// </summary>
    public class ClienteController
    {
        public void CadastrarCliente()
        {
            Console.WriteLine("\nCADASTRO DE CLIENTE:\n");

            var cliente = new Cliente()
            {
                Id = Guid.NewGuid(),
                DataHoraCriacao = DateTime.Now,
                DataHoraAlteracao = DateTime.Now,
                Ativo = true
            };

            Console.Write("INFORME O NOME DO CLIENTE...:");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE..:");
            cliente.Email = Console.ReadLine();

            if (!IsValid(cliente))
                return;

            var clienteRepository = new ClienteRepository();
            clienteRepository.Insert(cliente);

            Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO!");

        }
        public void AtualizarCliente()
        {
            Console.WriteLine("\nATUALIZAÇÃO DE CLIENTE");

            var cliente = ObterCliente();

            if (cliente == null)
                return;

            Console.WriteLine("ALTERE O NOME DO CLIENTE.....: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("ALTERE O EMAIL DO CLIENTE....:");
            cliente.Email = Console.ReadLine();

            if (!IsValid(cliente))
                return;

            var clienteRepository = new ClienteRepository();

            cliente.DataHoraAlteracao = DateTime.Now;
            Console.WriteLine("\nCLIENTE ATUALIZADO COM SUCESSO!");

        }

        public void ExcluirCliente()
        {
            Console.WriteLine("\nEXCLUSÃO DE CLIENTE:\n");

            var cliente = ObterCliente();

            if (cliente == null)
                return;

            Console.WriteLine("DESEJA REALMENTE EXCLUIR ESTE CLIENTE? (y/n): ");
            var resposta = Console.ReadLine();

            if (resposta.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                var clienteRepository = new ClienteRepository();
                clienteRepository.Delete(cliente.Id);
                Console.WriteLine("CLIENTE EXCLUÍDO COM SUCESSO!");
            }

        }

        public void ConsultarClientes()
        {
            Console.WriteLine("\nCONSULTA DE CLIENTES:\n");

            var clienteRepository = new ClienteRepository();
            var clientes = clienteRepository.GetAll();

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id},\n NOME: {cliente.Nome},\n EMAIL: {cliente.Email},\n CRIADO EM: {cliente.DataHoraCriacao},\n ALTERADO EM: {cliente.DataHoraAlteracao}\n\n");
            }

        }

        private Cliente? ObterCliente()
        {
            var clienteRepository = new ClienteRepository();

            Console.Write("INFORME O ID DO CLIENTE.....: ");
            var id = Guid.Parse(Console.ReadLine());

            var cliente = clienteRepository.Get(id);

            if (cliente != null)
            {
                Console.WriteLine("\nDADOS DO CLIENTE:");
                Console.WriteLine($"ID: {cliente.Id}, NOME: {cliente.Nome}, EMAIL: {cliente.Email}\n");
                return cliente;
            }
            else
            {
                Console.WriteLine("\nCLIENTE NÃO ENCONTRADO. VERIFIQUE O ID INFORMADO.");
                return null;
            }
        }

        private bool IsValid(Cliente cliente)
        {
            var context = new ValidationContext(cliente);
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(cliente, context, result, true);

            if (!isValid)
            {
                Console.WriteLine("\nOCORRERAM ERROS DE VALIDAÇÃO:");
                foreach (var error in result)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return false;
            }
            return true;
        }

    }
}
