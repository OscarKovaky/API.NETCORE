using Dtos;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO.Store.Imp;

public class TiendaServiceDao : ITiendaService
{
    private readonly IDataBaseContext _context;

    public  TiendaServiceDao(IDataBaseContext context)
    {
        _context = context;
    }
    
    public async Task<Tienda> GetTiendaByIdAsync(int id)
    {
        return await _context.Tiendas.FindAsync(id);
    }

    public async Task<IEnumerable<Tienda>> GetAllTiendasAsync()
    {
        return await _context.Tiendas.ToListAsync();
    }

    public async Task AddTiendaAsync(TiendaDto dto)
    {
        var tienda = new Tienda
        {
            Sucursal = dto.Sucursal,
            Direccion = dto.Direccion,
            // Añade más campos según sea necesario
        };

        _context.Tiendas.Add(tienda);
        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task UpdateTiendaAsync(TiendaDto dto)
    {
        var tienda = await _context.Tiendas.FindAsync(dto.TiendaId);
        if (tienda == null)
            throw new Exception("Tienda no encontrada");

        tienda.Sucursal = dto.Sucursal;
        tienda.Direccion = dto.Direccion;
        // Actualiza más campos según sea necesario

        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task DeleteTiendaAsync(int id)
    {
        var tienda = await _context.Tiendas.FindAsync(id);
        if (tienda == null)
            throw new Exception("Tienda no encontrada");

        _context.Tiendas.Remove(tienda);
        await((DataBaseContext)_context).SaveChangesAsync();
    }
}