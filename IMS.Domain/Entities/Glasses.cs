using IMS.Domain.Enums;
using System.ComponentModel.DataAnnotations;


namespace IMS.Domain.Entities
{
    public class Glasses
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; } = string.Empty;
        [Required]
        public string LensType { get; set; } = string.Empty;
        [Required]
        public GlassesColors Color { get; set; }
        [Required]
        public GlassesSize Size { get; set; }
        [Required]
        public float Height { get; set; }
        [Required]
        public float Width { get; set; }
        [Required]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Required]
        public DateTime Updated_At { get; set; }
        [Required]
        public bool Is_Active { get; set; } = true;

    }
}
