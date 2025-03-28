namespace IncidentApi.Models;

public class Incident
{
    public long id { get; set; }
    public string? reporter { get; set; }
    public string? description { get; set; }

    public string? status { get; set; }
    public DateTime createdAt { get; set; }
}
