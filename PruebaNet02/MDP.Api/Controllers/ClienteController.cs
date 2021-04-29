using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MDP.Api.Responses;
using MDP.Core.DTOs;
using MDP.Core.Entities;
using MDP.Core.Interfaces;
using MDP.Infrastructure.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MDP.Core.Exceptions;
using Microsoft.AspNetCore.Cors;

namespace MDP.Api.Controllers
{
    [AllowAnonymous]
    [Route(RouteApi.UriCliente.Prefijo)]
    [ApiController]

    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _cliService;
        private readonly IMapper _mapper;

        public ClienteController(IClienteService cliService, IMapper mapper)
        {
            _cliService = cliService;
            _mapper = mapper;
        }

        [HttpGet(RouteApi.UriCliente.Listar)]
        public async Task<IActionResult> GetClientes()
        {
            var clientes = await _cliService.GetClientes();
            var clientesDtos = _mapper.Map<IEnumerable<ClienteDto>>(clientes);

            //var response = new ApiResponse<IEnumerable<clienteDto>>(clientesDtos);
            //return Ok(response);
            return Ok(clientesDtos);
        }

        //[HttpGet("{id}")]
        [HttpGet(RouteApi.UriCliente.Buscar)]
        public async Task<IActionResult> GetCliente(int id)
        {
            var Cliente = await _cliService.GetCliente(id);
            var clienteDto = _mapper.Map<ClienteDto>(Cliente);
            
            //var response = new ApiResponse<clienteDto>(clienteDto);
            //return Ok(response);
            return Ok(clienteDto);
        }

        [HttpGet(RouteApi.UriCliente.BuscarEmail)]
        public async Task<IActionResult> GetClienteEmail(int id, string email)
        {
            var clientes = await _cliService.GetEmail(id, email);
            var clientesDto = _mapper.Map<ClienteDto>(clientes);

            //var response = new ApiResponse<clienteDto>(clientesDto);
            //return Ok(response);
            return Ok(clientesDto);
        }

        //[HttpPost]
        [HttpPost(RouteApi.UriCliente.Grabar)]
        public async Task<IActionResult> Cliente(ClienteDto clienteDto)
        {
            var Cliente = _mapper.Map<Cliente>(clienteDto);
            Cliente.Id = 0;

            await _cliService.InsertCliente(Cliente);
            clienteDto = _mapper.Map<ClienteDto>(Cliente);

            //var response = new ApiResponse<clienteDto>(clienteDto);
            //return Ok(response);
            return Ok(clienteDto);
        }

        //[HttpPut]
        [HttpPut(RouteApi.UriCliente.Actualizar)]
        public async Task<IActionResult> Put(ClienteDto clienteDto)
        {
            var Cliente = _mapper.Map<Cliente>(clienteDto);
            var result = await _cliService.UpdateCliente(Cliente);

            //var response = new ApiResponse<bool>(result);
            //return Ok(response);
            return Ok(result);
        }

        //[HttpDelete("{id}")]
        [HttpDelete(RouteApi.UriCliente.Eliminar)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _cliService.DeleteCliente(id);

            //var response = new ApiResponse<bool>(result);
            //return Ok(response);
            return Ok(result);
        }
    }
}
