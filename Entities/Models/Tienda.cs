namespace Entities.Models;

public class Tienda
{
    public int TiendaId { get; set; }
    public string Sucursal { get; set; }
    public string Direccion { get; set; }
    public ICollection<RelacionArticuloTienda> RelacionesArticuloTienda { get; set; }
}