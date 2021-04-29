using System;
using System.Collections.Generic;

#nullable disable

namespace MDP.Core.Entities
{
    public partial class Cliente : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string Direccion { get; set; }
    }
}
