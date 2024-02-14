namespace Dtos;

public class ItemCarritoDto
{
    public int ItemId { get; set; }
    public int ArticuloId { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
}