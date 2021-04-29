using MDP.Core.Entities;
using MDP.Core.Exceptions;
using MDP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDP.Core.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClienteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _unitOfWork.ClienteRepository.GetAll();
        }

        public async Task<Cliente> GetCliente(int id)
        {
            return await _unitOfWork.ClienteRepository.GetById(id);
        }

        public async Task<Cliente> GetEmail(int id, string email)
        {
            return await _unitOfWork.ClienteRepository.GetByEmail(id, email);
        }


        public async Task InsertCliente(Cliente Cliente)
        {
            Cliente.Id = 0;
            Cliente.FechaRegistro = DateTime.Now;

            await _unitOfWork.ClienteRepository.Add(Cliente);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> UpdateCliente(Cliente Cliente)
        {
            Cliente.FechaRegistro = DateTime.Now;

            _unitOfWork.ClienteRepository.Update(Cliente);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCliente(int id)
        {
            var cli = await _unitOfWork.ClienteRepository.GetById(id);
            if (cli == null)
            {
                throw new BusinessException("El Id de Cliente no existe.");
            }

            await _unitOfWork.ClienteRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}