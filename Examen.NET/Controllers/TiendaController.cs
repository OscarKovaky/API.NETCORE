using Dtos;
using Services.TiendaService;

namespace Examen.NET.Controllers;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ShopController : ControllerBase
{
    private readonly ITiendaService _shopService;

    public ShopController(ITiendaService shopService)
    {
        _shopService = shopService;
    }

    [HttpGet("articulo/{id}")]
    public async Task<ActionResult<ArticuloDto>> GetArticuloByIdAsync(int id)
    {
        var articulo = await _shopService.GetArticuloByIdAsync(id);
        if (articulo == null)
        {
            return NotFound();
        }
        return articulo;
    }

    [HttpGet("articulo")]
    public async Task<ActionResult<IEnumerable<ArticuloDto>>> GetAllArticulosAsync()
    {
        var articulos = await _shopService.GetAllArticulosAsync();
        return Ok(articulos);
    }

    [HttpPost("articulo")]
    public async Task<ActionResult> AddArticuloAsync(ArticuloDto articuloDto)
    {
        await _shopService.AddArticuloAsync(articuloDto);
        return Ok();
    }

    [HttpPut("articulo/{id}")]
    public async Task<ActionResult> UpdateArticuloAsync(int id, ArticuloDto articuloDto)
    {
        if (id != articuloDto.ArticuloId)
        {
            return BadRequest();
        }
        await _shopService.UpdateArticuloAsync(articuloDto);
        return Ok();
    }

    [HttpDelete("articulo/{id}")]
    public async Task<ActionResult> DeleteArticuloAsync(int id)
    {
        await _shopService.DeleteArticuloAsync(id);
        return Ok();
    }

    [HttpGet("relacionclientearticulo/{id}")]
    public async Task<ActionResult<RelacionClienteArticuloDto>> GetRelacionClienteArticuloByIdAsync(int id)
    {
        var relacion = await _shopService.GetRelacionClienteArticuloByIdAsync(id);
        if (relacion == null)
        {
            return NotFound();
        }
        return relacion;
    }

    [HttpGet("relacionclientearticulo")]
    public async Task<ActionResult<IEnumerable<RelacionClienteArticuloDto>>> GetAllRelacionesClienteArticuloAsync()
    {
        var relaciones = await _shopService.GetAllRelacionesClienteArticuloAsync();
        return Ok(relaciones);
    }

    [HttpPost("relacionclientearticulo")]
    public async Task<ActionResult> AddRelacionClienteArticuloAsync(RelacionClienteArticuloDto relacionDto)
    {
        await _shopService.AddRelacionClienteArticuloAsync(relacionDto);
        return Ok();
    }

    [HttpPut("relacionclientearticulo/{id}")]
    public async Task<ActionResult> UpdateRelacionClienteArticuloAsync(int id, RelacionClienteArticuloDto relacionDto)
    {
        if (id != relacionDto.ArticuloId)
        {
            return BadRequest();
        }
        await _shopService.UpdateRelacionClienteArticuloAsync(relacionDto);
        return Ok();
    }

    [HttpDelete("relacionclientearticulo/{id}")]
    public async Task<ActionResult> DeleteRelacionClienteArticuloAsync(int id)
    {
        await _shopService.DeleteRelacionClienteArticuloAsync(id);
        return Ok();
    }

    [HttpGet("relacionarticulotienda/{articuloId}/{tiendaId}")]
    public async Task<ActionResult<RelacionArticuloTiendaDto>> GetRelacionArticuloTiendaByIdAsync(int articuloId, int tiendaId)
    {
        var relacion = await _shopService.GetRelacionArticuloTiendaByIdAsync(articuloId, tiendaId);
        if (relacion == null)
        {
            return NotFound();
        }
        return relacion;
    }

    [HttpGet("relacionarticulotienda")]
    public async Task<ActionResult<IEnumerable<RelacionArticuloTiendaDto>>> GetAllRelacionesArticuloTiendaAsync()
    {
        var relaciones = await _shopService.GetAllRelacionesArticuloTiendaAsync();
        return Ok(relaciones);
    }

    [HttpPost("relacionarticulotienda")]
    public async Task<ActionResult> AddRelacionArticuloTiendaAsync(RelacionArticuloTiendaDto relacionDto)
    {
        await _shopService.AddRelacionArticuloTiendaAsync(relacionDto);
        return Ok();
    }

    [HttpPut("relacionarticulotienda/{articuloId}/{tiendaId}")]
    public async Task<ActionResult> UpdateRelacionArticuloTiendaAsync(int articuloId, int tiendaId, RelacionArticuloTiendaDto relacionDto)
    {
        if (articuloId != relacionDto.ArticuloId || tiendaId != relacionDto.TiendaId)
        {
            return BadRequest();
        }
        await _shopService.UpdateRelacionArticuloTiendaAsync(relacionDto);
        return Ok();
    }

    [HttpDelete("relacionarticulotienda/{articuloId}/{tiendaId}")]
    public async Task<ActionResult> DeleteRelacionArticuloTiendaAsync(int articuloId, int tiendaId)
    {
        await _shopService.DeleteRelacionArticuloTiendaAsync(articuloId, tiendaId);
        return Ok();
    }

    [HttpGet("tienda/{id}")]
    public async Task<ActionResult<TiendaDto>> GetTiendaByIdAsync(int id)
    {
        var tienda = await _shopService.GetTiendaByIdAsync(id);
        if (tienda == null)
        {
            return NotFound();
        }
        return tienda;
    }

    [HttpGet("tienda")]
    public async Task<ActionResult<IEnumerable<TiendaDto>>> GetAllTiendasAsync()
    {
        var tiendas = await _shopService.GetAllTiendasAsync();
        return Ok(tiendas);
    }

    [HttpPost("tienda")]
    public async Task<ActionResult> AddTiendaAsync(TiendaDto tiendaDto)
    {
        await _shopService.AddTiendaAsync(tiendaDto);
        return Ok();
    }

    [HttpPut("tienda/{id}")]
    public async Task<ActionResult> UpdateTiendaAsync(int id, TiendaDto tiendaDto)
    {
        if (id != tiendaDto.TiendaId)
        {
            return BadRequest();
        }
        await _shopService.UpdateTiendaAsync(tiendaDto);
        return Ok();
    }

    [HttpDelete("tienda/{id}")]
    public async Task<ActionResult> DeleteTiendaAsync(int id)
    {
        await _shopService.DeleteTiendaAsync(id);
        return Ok();
    }
}
