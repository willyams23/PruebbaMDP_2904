using System;
using System.Collections.Generic;
using System.Text;

namespace MDP.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Correo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }


    }
}
