namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class CustomerBaseModel
    {
        public string CustomerId { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return $"{this.CustomerId} - {this.CustomerNumber}";
        }
    }
}
