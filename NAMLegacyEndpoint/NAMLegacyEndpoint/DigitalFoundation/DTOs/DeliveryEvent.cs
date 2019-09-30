namespace HeidelbergCement.Foundation.Common.Interfaces.DTOs
{
    public class DeliveryEvent
    {
        public string LoadStarted { get; set; }
        public string LoadFinished { get; set; }
        public string Arrived { get; set; }
        public string UnloadStarted { get; set; }
        public string UnloadFinished { get; set; }
    }
}
