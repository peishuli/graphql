namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class ScheduleBaseModel
    {
        public string ScheduleNumber { get; set; }
        public decimal ScheduleQuantity { get; set; }
        public bool QuantityChangeExpected { get; set; }
        public decimal? HoldQuantity { get; set; }
        public decimal? QuantityPerHour { get; set; }

        public override string ToString()
        {
            return $"{this.ScheduleNumber}";
        }
    }
}
