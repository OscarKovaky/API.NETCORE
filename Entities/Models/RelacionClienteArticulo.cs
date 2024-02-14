namespace Entities.Models;

public class RelacionClienteArticulo
{
    public int RelacionClienteArticuloId { get; set; }
    public string ClienteId { get; set; }
    public Cliente Cliente { get; set; }
    public int ArticuloId { get; set; }
    public Articulo Articulo { get; set; }
    public DateTime Fecha { get; set; }
}