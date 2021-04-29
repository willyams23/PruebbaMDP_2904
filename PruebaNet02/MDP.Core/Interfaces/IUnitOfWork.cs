using MDP.Core.Entities;
using System;
using System.Threading.Tasks;

namespace MDP.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Cliente> ClienteRepository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}
