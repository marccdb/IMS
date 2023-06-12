using System.ComponentModel.DataAnnotations;

namespace IMS.Domain.Entities.Dependencies;

public class GlassesSize
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Size { get; set; } = string.Empty;
}
