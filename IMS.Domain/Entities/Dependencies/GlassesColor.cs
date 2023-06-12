using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Entities.Dependencies;

public class GlassesColor
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Color { get; set; } = string.Empty;
}
