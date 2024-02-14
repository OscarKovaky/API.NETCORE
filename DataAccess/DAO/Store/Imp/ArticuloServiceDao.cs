using Dtos;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DAO.Store.Imp;

public class ArticuloServiceDao : IArticuloService
{
    private readonly IDataBaseContext _context;

    
    public  ArticuloServiceDao(IDataBaseContext context)
    {
        _context = context;
    }
    public async Task<Articulo> GetArticuloByIdAsync(int id)
    {
        return await _context.Articulos.FindAsync(id);
    }

    public async Task<IEnumerable<Articulo>> GetAllArticulosAsync()
    {
        return await _context.Articulos.ToListAsync();
    }

    public async Task AddArticuloAsync(ArticuloDto dto)
    {
        var articulo = new Articulo
        {
            Codigo = dto.Codigo,
            Descripcion = dto.Descripcion,
            Precio = dto.Precio,
            Imagen = dto.Imagen,
            Stock = dto.Stock
            // Agrega más campos según sea necesario
        };

        _context.Articulos.Add(articulo);
        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task UpdateArticuloAsync(ArticuloDto dto)
    {
        var articulo = await _context.Articulos.FindAsync(dto.ArticuloId);
        if (articulo == null)
            throw new Exception("Artículo no encontrado");

        articulo.Codigo = dto.Codigo;
        articulo.Descripcion = dto.Descripcion;
        articulo.Precio = dto.Precio;
        articulo.Imagen = dto.Imagen;
        articulo.Stock = dto.Stock;
        // Actualiza más campos según sea necesario

        await((DataBaseContext)_context).SaveChangesAsync();
    }

    public async Task DeleteArticuloAsync(int id)
    {
        var articulo = await _context.Articulos.FindAsync(id);
        if (articulo == null)
            throw new Exception("Artículo no encontrado");

        _context.Articulos.Remove(articulo);
        await((DataBaseContext)_context).SaveChangesAsync();
    }
}