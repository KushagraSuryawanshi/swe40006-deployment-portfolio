namespace WebApplication1.Models
{
    public class DeploymentInfoViewModel
    {
        public string ApplicationName { get; set; } = string.Empty;
        public string Runtime {get;set;} = string.Empty;
        public string DeploymentTarget {get;set;} = string.Empty;
        public string Status  {get;set;} = string.Empty;

    }
}
