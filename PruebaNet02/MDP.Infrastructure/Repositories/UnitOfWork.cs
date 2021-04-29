using MDP.Core.Entities;
using MDP.Core.Interfaces;
using MDP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MDPruebaContext _context;
        private readonly IRepository<Cliente> _cliRepository;

        public UnitOfWork(MDPruebaContext context)
        {
            _context = context;
        }

        public IRepository<Cliente> ClienteRepository => _cliRepository ?? new BaseRepository<Cliente>(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
