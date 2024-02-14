using Dtos;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO.Store.Imp;

public class RelacionArticuloTiendaServiceDao : IRelacionArticuloTiendaService
{
    private readonly IDataBaseContext _context;

    public  RelacionArticuloTiendaServiceDao(IDataBaseContext context)
    {
        _context = context;
    }
    public async Task<RelacionArticuloTienda> GetRelacionArticuloTiendaByIdAsync(int articuloId, int tiendaId)
    {
        return await _context.RelacionesArticuloTienda.FirstOrDefaultAsync(r => r.ArticuloId == articuloId && r.TiendaId == tiendaId);
    }

    public async Task<IEnumerable<RelacionArticuloTienda>> GetAllRelacionesArticuloTiendaAsync()
    {
        return await _context.RelacionesArticuloTienda.ToListAsync();
    }

    public async Task AddRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto)
    {
        var relacion = new RelacionArticuloTienda
        {
            ArticuloId = dto.ArticuloId,
            TiendaId = dto.TiendaId,
            Fecha = dto.Fecha
        };

        _context.RelacionesArticuloTienda.Add(relacion);
        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task UpdateRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto)
    {
        var relacion = await _context.RelacionesArticuloTienda.FirstOrDefaultAsync(r => r.ArticuloId == dto.ArticuloId && r.TiendaId == dto.TiendaId);
        if (relacion == null)
            throw new Exception("Relación Articulo - Tienda no encontrada");

        relacion.Fecha = dto.Fecha;

        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task DeleteRelacionArticuloTiendaAsync(int articuloId, int tiendaId)
    {
        var relacion = await _context.RelacionesArticuloTienda.FirstOrDefaultAsync(r => r.ArticuloId == articuloId && r.TiendaId == tiendaId);
        if (relacion == null)
            throw new Exception("Relación Articulo - Tienda no encontrada");

        _context.RelacionesArticuloTienda.Remove(relacion);
        await((DataBaseContext)_context).SaveChangesAsync();
    }
}