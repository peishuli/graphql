using HeidelbergCement.Foundation.Common.Interfaces.Enums;

namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class OrderBaseModel
    {
        public string OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string TruckId { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectId { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public bool? IsHalted { get; set; }
        public string ShippingType { get; set; }
        public string CustomerReference { get; set; }

        public override string ToString()
        {
            return $"{this.OrderId} - {this.OrderNumber}";
        }
    }
}
