using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Articulo
{
    public int ArticuloId { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Precio { get; set; }
    public string Imagen { get; set; }
    public int Stock { get; set; }
    public ICollection<RelacionArticuloTienda> RelacionesArticuloTienda { get; set; }
    public ICollection<RelacionClienteArticulo> RelacionesClienteArticulo { get; set; }
}