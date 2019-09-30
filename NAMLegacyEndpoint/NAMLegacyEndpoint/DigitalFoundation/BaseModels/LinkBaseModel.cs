namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class LinkBaseModel
    {
        public string Href { get; set; }
        public string Media { get; set; }
        public string Type { get; set; }
        public string Rel { get; set; }
    }
}
