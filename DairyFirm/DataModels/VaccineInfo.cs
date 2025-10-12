using System.ComponentModel.DataAnnotations;

namespace DairyFirm.DataModels
{
    public class VaccineInfo
    {
        [Key]
        public int VaccineId { get; set; }

        public string? VaccineName { get; set; }
        public double VaccinePrice { get; set; }
        public int TotalVaccine { get; set; }
        public int VaccineMonth { get; set; }
        public int VaccineDay { get; set; }
    }
}
