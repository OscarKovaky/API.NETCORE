namespace Dtos;

public class CarritoDto
{
    public int CarritoId { get; set; }
    public string ClienteId { get; set; }
    public List<ItemCarritoDto> Items { get; set; }
    // Otros campos según sea necesario
}