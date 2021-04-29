using AutoMapper;
using MDP.Core.DTOs;
using MDP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace MDP.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();
        }
    }
}
