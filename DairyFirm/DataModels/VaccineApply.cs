using System.ComponentModel.DataAnnotations;

namespace DairyFirm.DataModels
{
    public class VaccineApply
    {
        [Key]
        public int VaccineApplyId { get; set; }

        public int VaccineId { get; set; }
        public int CowId { get; set; }

        public double VaccineApplyAmmount { get; set; }
        public int VaccineApplyMonth { get; set; }
        public int VaccineApplyDay { get; set; }
    }
}
