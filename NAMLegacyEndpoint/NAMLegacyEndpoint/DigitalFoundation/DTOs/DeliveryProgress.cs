namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class DeliveryProgress
    {
        public int ShippedDeliveries { get; set; }
        public decimal ShippedQuantity { get; set; }
        public int ArrivedDeliveries { get; set; }
        public decimal ArrivedQuantity { get; set; }
        public int DeliveredDeliveries { get; set; }
        public decimal DeliveredQuantity { get; set; }
    }
}