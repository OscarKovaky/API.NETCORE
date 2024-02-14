
using Entities.Models;
using Entities.Models.View;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public interface IDataBaseContext 
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<RelacionArticuloTienda> RelacionesArticuloTienda { get; set; }
        public DbSet<RelacionClienteArticulo> RelacionesClienteArticulo { get; set; }

    }
}
