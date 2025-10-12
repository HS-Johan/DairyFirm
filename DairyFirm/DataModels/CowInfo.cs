using System.ComponentModel.DataAnnotations;

namespace DairyFirm.DataModels
{
    public class CowInfo
    {
        [Key]
        public int CowId { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public string? Breed { get; set; }
        
        public DateTime EntryDate { get; set; }
    }
}
