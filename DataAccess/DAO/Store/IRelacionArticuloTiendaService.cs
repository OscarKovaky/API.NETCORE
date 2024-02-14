using Dtos;
using Entities.Models;

namespace DataAccess.DAO.Store;

public interface IRelacionArticuloTiendaService
{
    Task<RelacionArticuloTienda> GetRelacionArticuloTiendaByIdAsync(int articuloId, int tiendaId);
    Task<IEnumerable<RelacionArticuloTienda>> GetAllRelacionesArticuloTiendaAsync();
    Task AddRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto);
    Task UpdateRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto);
    Task DeleteRelacionArticuloTiendaAsync(int articuloId, int tiendaId);
}
