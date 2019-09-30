namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class MaterialLocationBaseModel
    {
        public string DeliveryId { get; set; }
        public string DeliveryNumber { get; set; }
        public string TruckId { get; set; }
        public string TruckName { get; set; }
    }
}
