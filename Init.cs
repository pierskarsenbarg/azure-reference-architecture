using Pulumi;
using Pulumi.AzureNextGen.Resources.Latest;

namespace azure_reference_architecture
{
    public class Init : Stack
    {
        public Init()
        {
            // var baseinfra = new BaseInfrastructure();
            var azureConfig = new Pulumi.Config("azure");
            var resourceGroup = new ResourceGroup("pk-resourcegroup", new ResourceGroupArgs
            {
                Location = azureConfig.Get("location") ?? "uksouth",
                ResourceGroupName = Output.Format($"pk-resourcename")
            });
        }
    }
}