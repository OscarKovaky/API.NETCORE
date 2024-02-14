using Dtos;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO.Store.Imp;

public class ClienteArticuloServiceDao : IClienteArticuloService
{
    private readonly IDataBaseContext _context;

    public  ClienteArticuloServiceDao(IDataBaseContext context)
    {
        _context = context;
    }
    
    public async Task<RelacionClienteArticulo> GetRelacionClienteArticuloByIdAsync(int id)
    {
        return await _context.RelacionesClienteArticulo.FindAsync(id);
    }

    public async Task<IEnumerable<RelacionClienteArticulo>> GetAllRelacionesClienteArticuloAsync()
    {
        return await _context.RelacionesClienteArticulo.ToListAsync();
    }

    public async Task AddRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto)
    {
        var relacion = new RelacionClienteArticulo
        {
            ClienteId = dto.ClienteId,
            ArticuloId = dto.ArticuloId,
            Fecha = dto.Fecha
            // Agrega más campos según sea necesario
        };

        _context.RelacionesClienteArticulo.Add(relacion);
        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task UpdateRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto)
    {
        var relacion = await _context.RelacionesClienteArticulo.FindAsync(dto.RelacionClienteArticuloId);
        if (relacion == null)
            throw new Exception("Relación Cliente - Artículo no encontrada");

        relacion.ClienteId = dto.ClienteId;
        relacion.ArticuloId = dto.ArticuloId;
        relacion.Fecha = dto.Fecha;
        // Actualiza más campos según sea necesario

        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task DeleteRelacionClienteArticuloAsync(int id)
    {
        var relacion = await _context.RelacionesClienteArticulo.FindAsync(id);
        if (relacion == null)
            throw new Exception("Relación Cliente - Artículo no encontrada");

        _context.RelacionesClienteArticulo.Remove(relacion);
        await((DataBaseContext)_context).SaveChangesAsync();
    }
}