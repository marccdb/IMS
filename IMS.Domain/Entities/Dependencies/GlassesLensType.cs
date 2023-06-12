using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Entities.Dependencies;

public class GlassesLensType
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string LensType { get; set; } = string.Empty;
}
