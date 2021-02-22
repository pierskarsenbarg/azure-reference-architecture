using Pulumi;
using Pulumi.AzureNextGen.Resources.Latest;
using Pulumi.Random;

namespace azure_reference_architecture
{
    public class BaseInfrastructure : Stack
    {
        public BaseInfrastructure()
        {
            var azureConfig = new Pulumi.Config("azure");
            var resourceGroup = new ResourceGroup("pk-resourcegroup", new ResourceGroupArgs
            {
                Location = azureConfig.Get("location") ?? "uksouth",
                ResourceGroupName = Output.Format($"pk-resourcename")
            });
            ResourceGroupName =resourceGroup.Name;
        }

        [Output]
        public Output<string> ResourceGroupName {get;set;}
    }
}