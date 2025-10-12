using System.ComponentModel.DataAnnotations;

namespace DairyFirm.DataModels
{
    public class MeatProducion
    {
        [Key]
        public int MeatId { get; set; }

        public int CowId { get; set; }

        public DateTime WeightDate { get; set; }
        public double Weight { get; set; }
    }
}
