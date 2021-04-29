using MDP.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MDP.Core.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetClientes();

        Task<Cliente> GetCliente(int id);
        Task<Cliente> GetEmail(int id, string email);
        Task InsertCliente(Cliente cliente);

        Task<bool> UpdateCliente(Cliente cliente);

        Task<bool> DeleteCliente(int id);
    }
}
