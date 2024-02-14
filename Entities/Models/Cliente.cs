using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public  class Cliente : IdentityUser
    {
        [Key]
        public int IdCliente { get; set; }
        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }
        
        public string? Direccion { get; set; }
        
        public ICollection<RelacionClienteArticulo> RelacionesClienteArticulo { get; set; }
    }
}
