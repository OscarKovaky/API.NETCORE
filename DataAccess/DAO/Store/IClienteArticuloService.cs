using Dtos;
using Entities.Models;

namespace DataAccess.DAO.Store;

public interface IClienteArticuloService
{
    Task<RelacionClienteArticulo> GetRelacionClienteArticuloByIdAsync(int id);
    Task<IEnumerable<RelacionClienteArticulo>> GetAllRelacionesClienteArticuloAsync();
    Task AddRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto);
    Task UpdateRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto);
    Task DeleteRelacionClienteArticuloAsync(int id);
}