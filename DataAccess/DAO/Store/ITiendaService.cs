using Dtos;
using Entities.Models;

namespace DataAccess.DAO.Store;

public interface ITiendaService
{
    Task<Tienda> GetTiendaByIdAsync(int id);
    Task<IEnumerable<Tienda>> GetAllTiendasAsync();
    Task AddTiendaAsync(TiendaDto dto);
    Task UpdateTiendaAsync(TiendaDto dto);
    Task DeleteTiendaAsync(int id);
}