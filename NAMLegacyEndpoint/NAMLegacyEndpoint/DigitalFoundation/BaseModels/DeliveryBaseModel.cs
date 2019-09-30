namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class DeliveryBaseModel
    {
        public string DeliveryId { get; set; }
        public string DeliveryNumber { get; set; }
        public string OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerId { get; set; }
        public string TruckId { get; set; }
        public string TruckName { get; set; }
        public string PlantId { get; set; }
        public string PlantName { get; set; }
        public decimal LoadQuantity { get; set; }
        public string LoadQuantityUom { get; set; }

        public override string ToString()
        {
            return $"{this.DeliveryId} - {this.DeliveryNumber}";
        }
    }
}
