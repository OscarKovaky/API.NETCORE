namespace Dtos;

public class RelacionClienteArticuloDto
{
    public int RelacionClienteArticuloId { get; set; }
    public string ClienteId { get; set; }
    public int ArticuloId { get; set; }
    public DateTime Fecha { get; set; }
}