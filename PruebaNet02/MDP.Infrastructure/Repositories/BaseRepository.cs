using Microsoft.EntityFrameworkCore;
using MDP.Core.Entities;
using MDP.Core.Interfaces;
using MDP.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MDPruebaContext _context;
        protected readonly DbSet<T> _entities;


        public BaseRepository(MDPruebaContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Task.FromResult(_entities.AsEnumerable());
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<T> GetByEmail(int id, string email)
        {
            return  await _entities.FirstOrDefaultAsync(x => x.Id != id && x.Correo.Equals(email));
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _entities.Remove(entity);

        }

    }
}
