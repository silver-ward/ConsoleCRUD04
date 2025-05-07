using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAula04.Entities;

namespace ProjetoAula04.Interfaces
{
    /// <summary>
    /// Interface para abstração dos métodos do repositório de clientes
    /// </summary>
    public interface IClienteRepository
    {
        void Insert(Cliente cliente);

        void Update(Cliente cliente);

        void Delete(Guid? id);

        List<Cliente>? GetAll();

        Cliente? Get(Guid? id);
    }
}
