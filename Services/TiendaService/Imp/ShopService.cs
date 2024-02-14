using AutoMapper;
using DataAccess.DAO.Store;
using Dtos;
using Entities.Models;

namespace Services.TiendaService.Imp;

public class ShopService : ITiendaService
{
    private readonly IArticuloService _articuloService;
    private readonly ITiendaService _tiendaService;
    private readonly IRelacionArticuloTiendaService _relacionArticuloTiendaService;
    private readonly IClienteArticuloService _clienteArticuloService;
    private readonly IMapper _mapper;

    public ShopService(IArticuloService articuloService, 
        ITiendaService tiendaService, 
        IRelacionArticuloTiendaService relacionArticuloTiendaService, 
        IClienteArticuloService clienteArticuloService, 
        IMapper mapper) {
        _articuloService = articuloService;
        _tiendaService = tiendaService;
        _relacionArticuloTiendaService = relacionArticuloTiendaService;
        _clienteArticuloService = clienteArticuloService;
        _mapper = mapper;
    }

    
    public async Task<ArticuloDto> GetArticuloByIdAsync(int id)
    {
        var articulo = await _articuloService.GetArticuloByIdAsync(id);
        return _mapper.Map<ArticuloDto>(articulo);
    }

    public async Task<IEnumerable<ArticuloDto>> GetAllArticulosAsync()
    {
        var articulos = await _articuloService.GetAllArticulosAsync();
        return _mapper.Map<IEnumerable<ArticuloDto>>(articulos);

    }

    public async Task AddArticuloAsync(ArticuloDto dto)
    {
        await _articuloService.AddArticuloAsync(dto);
    }

    public async Task UpdateArticuloAsync(ArticuloDto dto)
    {
        await _articuloService.UpdateArticuloAsync(dto);
    }

    public async Task DeleteArticuloAsync(int id)
    {
        await _articuloService.DeleteArticuloAsync(id);
    }

    public async Task<RelacionClienteArticuloDto> GetRelacionClienteArticuloByIdAsync(int id)
    {
        var relacion = await _clienteArticuloService.GetRelacionClienteArticuloByIdAsync(id);
        return _mapper.Map<RelacionClienteArticuloDto>(relacion);
    }

    public async Task<IEnumerable<RelacionClienteArticuloDto>> GetAllRelacionesClienteArticuloAsync()
    {
        var relaciones = await _clienteArticuloService.GetAllRelacionesClienteArticuloAsync();
        return _mapper.Map<IEnumerable<RelacionClienteArticuloDto>>(relaciones);
    }

    public async Task AddRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto)
    {
        await _clienteArticuloService.AddRelacionClienteArticuloAsync(dto);
    }

    public async Task UpdateRelacionClienteArticuloAsync(RelacionClienteArticuloDto dto)
    {
        await _clienteArticuloService.UpdateRelacionClienteArticuloAsync(dto);
    }

    public async Task DeleteRelacionClienteArticuloAsync(int id)
    {
        await _clienteArticuloService.DeleteRelacionClienteArticuloAsync(id);
    }

    public async Task<RelacionArticuloTiendaDto> GetRelacionArticuloTiendaByIdAsync(int articuloId, int tiendaId)
    {
        var relacion = await _relacionArticuloTiendaService.GetRelacionArticuloTiendaByIdAsync(articuloId, tiendaId);
        return _mapper.Map<RelacionArticuloTiendaDto>(relacion);
    }

    public async Task<IEnumerable<RelacionArticuloTiendaDto>> GetAllRelacionesArticuloTiendaAsync()
    {
        var relaciones = await _relacionArticuloTiendaService.GetAllRelacionesArticuloTiendaAsync();
        return _mapper.Map<IEnumerable<RelacionArticuloTiendaDto>>(relaciones);
    }

    public async Task AddRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto)
    {
        await _relacionArticuloTiendaService.AddRelacionArticuloTiendaAsync(dto);
    }

    public async Task UpdateRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto dto)
    {
        await _relacionArticuloTiendaService.UpdateRelacionArticuloTiendaAsync(dto);
    }

    public async Task DeleteRelacionArticuloTiendaAsync(int articuloId, int tiendaId)
    {
        await _relacionArticuloTiendaService.DeleteRelacionArticuloTiendaAsync(articuloId, tiendaId);
    }

    public async Task<TiendaDto> GetTiendaByIdAsync(int id)
    {
        var tienda = await _tiendaService.GetTiendaByIdAsync(id);
        return _mapper.Map<TiendaDto>(tienda);
    }

    public async Task<IEnumerable<TiendaDto>> GetAllTiendasAsync()
    {
        var tiendas = await _tiendaService.GetAllTiendasAsync();
        return _mapper.Map<IEnumerable<TiendaDto>>(tiendas);
    }

    public async Task AddTiendaAsync(TiendaDto dto)
    {
        await _tiendaService.AddTiendaAsync(dto);
    }

    public async Task UpdateTiendaAsync(TiendaDto dto)
    {
        await _tiendaService.UpdateTiendaAsync(dto);
    }

    public async Task DeleteTiendaAsync(int id)
    {
        await _tiendaService.DeleteTiendaAsync(id);
    }
}