using CircularEconomy.Enums;

namespace CircularEconomy.Data;

public class Place : EntityBase
{
    public PlaceActivity? PlaceActivity { get; set; }
    public ActivityOption? ActivityOption { get; set; }
    public string? Contact { get; set; }

    public string? Vyvoz { get; set; }
    public string? Vlastnik { get; set; }
    public string? ICO { get; set; }
    public string? Popis { get; set; }
    public string? Name { get; set; }

    public TypeTag? TypeTag { get; set; }
    public string? Ulice { get; set; }
    public string? CisloPopisne { get; set; }
    public string? PSC { get; set; }
}