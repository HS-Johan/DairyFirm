using System.ComponentModel.DataAnnotations;

namespace DairyFirm.DataModels
{
    public class MilkProduction
    {
        [Key]
        public int MilkId { get; set; }

        public int CowId { get; set; }

        public DateTime MilkDate { get; set; }
        public double MorningMilk { get; set; }
        public double EveningMilk { get; set; }
    }
}
