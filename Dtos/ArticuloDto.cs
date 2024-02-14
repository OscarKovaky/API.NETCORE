namespace Dtos;

public class ArticuloDto
{
    public int ArticuloId { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public string Imagen { get; set; }
    public int Stock { get; set; }
}