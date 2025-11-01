namespace DairyFirmView.ViewModel
{
    public class FeedingInfoVM
    {
        public int FeedingId { get; set; }

        public int CowId { get; set; }

        public string? FoodType { get; set; }
        public DateTime FeedingTime { get; set; }
        public double FeedingQuantity { get; set; }
    }
}
