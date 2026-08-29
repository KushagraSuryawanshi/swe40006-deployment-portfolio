namespace WebApplication1.Models
{
    public class DeploymentInfoViewModel
    {
        public string ApplicationName { get; set; } = string.Empty;
        public string Runtime {get;set;} = string.Empty;
        public string Environment {get;set;} = string.Empty;
        public string Status  {get;set;} = string.Empty;

    }
}
