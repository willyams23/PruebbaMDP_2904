using MDP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDP.Core.DTOs
{
    public class ClienteDto : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }
      
    }
}
