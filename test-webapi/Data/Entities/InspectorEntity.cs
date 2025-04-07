using System.ComponentModel.DataAnnotations;

namespace test_webapi.Data.Entities
{
    public class InspectorEntity
    {
        [Key]
        public int InspectorID { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string InspectorsName { get; set; } = string.Empty;

        // Navigation property
        public virtual ICollection<Inspection> Inspections { get; set; } = new List<Inspection>();
    }
}
