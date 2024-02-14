using Dtos;
using Entities.Models;

namespace DataAccess.DAO.Store;

public interface ICarritoService
{
    Task<CarritoDto> GetCarritoByClienteIdAsync(string clienteId);
    Task AddItemToCarritoAsync(int carritoId, int articuloId, int cantidad);
    Task RemoveItemFromCarritoAsync(int carritoId, int itemId);
    Task UpdateItemInCarritoAsync(int itemId, int cantidad);
    Task ClearCarritoAsync(int carritoId);
    Task CheckoutAsync(int carritoId);
    
  
}