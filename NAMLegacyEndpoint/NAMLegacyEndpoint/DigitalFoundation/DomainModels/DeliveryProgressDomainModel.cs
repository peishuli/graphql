namespace HeidelbergCement.Foundation.Common.Interfaces.DomainModels
{
    public class DeliveryProgressDomainModel
    {
        public int ShippedDeliveries { get; set; }
        public float ShippedQuantity { get; set; }
        public int ArrivedDeliveries { get; set; }
        public float ArrivedQuantity { get; set; }
        public int DeliveredDeliveries { get; set; }
        public float DeliveredQuantity { get; set; }
    }
}