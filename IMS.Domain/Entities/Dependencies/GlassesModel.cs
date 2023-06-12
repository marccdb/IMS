using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Entities.Dependencies;

public class GlassesModel
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Model { get; set; } = string.Empty;
}
