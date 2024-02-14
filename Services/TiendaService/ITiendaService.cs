using Dtos;
using Entities.Models;

namespace Services.TiendaService;

public interface ITiendaService
{
    Task<ArticuloDto> GetArticuloByIdAsync(int id);
    Task<IEnumerable<ArticuloDto>> GetAllArticulosAsync();
    Task AddArticuloAsync(ArticuloDto dto);
    Task UpdateArticuloAsync(ArticuloDto dto);
    Task DeleteArticuloAsync(int id);

    Task<RelacionClienteArticuloDto> GetRelacionClienteArticuloByIdAsync(int id);
    Task<IEnumerable<RelacionClienteArticuloDto>> GetAllRelacionesClienteArticuloAsync();
    Task AddRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto);
    Task UpdateRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto);
    Task DeleteRelacionClienteArticuloAsync(int id);

    Task<RelacionArticuloTiendaDto> GetRelacionArticuloTiendaByIdAsync(int articuloId, int tiendaId);
    Task<IEnumerable<RelacionArticuloTiendaDto>> GetAllRelacionesArticuloTiendaAsync();
    Task AddRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto);
    Task UpdateRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto);
    Task DeleteRelacionArticuloTiendaAsync(int articuloId, int tiendaId);

    Task<TiendaDto> GetTiendaByIdAsync(int id);
    Task<IEnumerable<TiendaDto>> GetAllTiendasAsync();
    Task AddTiendaAsync(TiendaDto dto);
    Task UpdateTiendaAsync(TiendaDto dto);
    Task DeleteTiendaAsync(int id);

}