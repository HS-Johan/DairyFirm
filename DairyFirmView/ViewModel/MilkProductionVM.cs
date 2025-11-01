namespace DairyFirmView.ViewModel
{
    public class MilkProductionVM
    {
        public int MilkId { get; set; }

        public int CowId { get; set; }

        public DateTime MilkDate { get; set; }
        public double MorningMilk { get; set; }
        public double EveningMilk { get; set; }
    }
}
