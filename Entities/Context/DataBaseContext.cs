
using Entities.Models;
using Entities.Models.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class DataBaseContext:  IdentityDbContext<Cliente>, IDataBaseContext
    {
     
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
             
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de relaciones
            modelBuilder.Entity<RelacionArticuloTienda>()
                .HasKey(r => r.RelacionArticuloTiendaId);

            modelBuilder.Entity<RelacionArticuloTienda>()
                .HasOne(r => r.Articulo)
                .WithMany(a => a.RelacionesArticuloTienda)
                .HasForeignKey(r => r.ArticuloId);

            modelBuilder.Entity<RelacionArticuloTienda>()
                .HasOne(r => r.Tienda)
                .WithMany(t => t.RelacionesArticuloTienda)
                .HasForeignKey(r => r.TiendaId);

            modelBuilder.Entity<RelacionClienteArticulo>()
                .HasKey(r => r.RelacionClienteArticuloId);

            modelBuilder.Entity<RelacionClienteArticulo>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.RelacionesClienteArticulo)
                .HasForeignKey(r => r.ClienteId);

            modelBuilder.Entity<RelacionClienteArticulo>()
                .HasOne(r => r.Articulo)
                .WithMany(a => a.RelacionesClienteArticulo)
                .HasForeignKey(r => r.ArticuloId);

            

            modelBuilder.Ignore<IdentityUserLogin<string>>();
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<RelacionArticuloTienda> RelacionesArticuloTienda { get; set; }
        public DbSet<RelacionClienteArticulo> RelacionesClienteArticulo { get; set; }
    }
}
