using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncidentApi.Models;

public class Incident
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long id { get; set; }
    public string? reporter { get; set; }
    public string? description { get; set; }

    public string? status { get; set; }
    public DateTime createdAt { get; set; } = DateTime.UtcNow;
}
