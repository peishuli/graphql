namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class SupplementItemBaseModel
    {
        public string RelatedItemNumber { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        //public decimal Quantity { get; set; }
        public float Quantity { get; set; }
        public string QuantityUom { get; set; }

        public override string ToString()
        {
            return $"{this.ItemNumber} - {this.ItemName}";
        }
    }
}
