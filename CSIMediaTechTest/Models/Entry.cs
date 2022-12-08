using System.ComponentModel.DataAnnotations;

namespace CSIMediaTechTest.Models
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public List<int> Numbers { get; set; }
        [Required]
        public bool IsAscending { get; set; }
        [Required]
        public decimal Time { get; set; }
    }
}
