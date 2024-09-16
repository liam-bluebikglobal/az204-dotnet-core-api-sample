namespace az204_dotnet_core_api_sample.Models;

public record Pizza
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}