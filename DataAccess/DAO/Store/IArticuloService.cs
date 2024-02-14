using Dtos;
using Entities.Models;

namespace DataAccess.DAO.Store;

public interface IArticuloService
{
    Task<Articulo> GetArticuloByIdAsync(int id);
    Task<IEnumerable<Articulo>> GetAllArticulosAsync();
    Task AddArticuloAsync(ArticuloDto dto);
    Task UpdateArticuloAsync(ArticuloDto dto);
    Task DeleteArticuloAsync(int id);
}