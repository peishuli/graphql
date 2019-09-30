namespace HeidelbergCement.Foundation.Common.Interfaces.BaseModels
{
    public abstract class ProjectBaseModel
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }

        public override string ToString()
        {
            return $"{this.ProjectId} - {this.ProjectNumber} - {this.ProjectName}";
        }
    }
}
