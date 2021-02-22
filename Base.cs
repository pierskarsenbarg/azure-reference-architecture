using Pulumi;
using Pulumi.AzureNextGen.Resources.Latest;

namespace azure_reference_architecture
{
    public class Base : Stack
    {
        public Base()
        {
            var azureConfig = new Pulumi.Config("azure");
            var resourceGroup = new ResourceGroup("pk-resourcegroup", new ResourceGroupArgs
            {
                Location = azureConfig.Get("location") ?? "",
                ResourceGroupName = "pk-resourceGroup"
            });
            ResourceGroupName =resourceGroup.Name;
        }

        [Output]
        public Output<string> ResourceGroupName {get;set;}
    }
}