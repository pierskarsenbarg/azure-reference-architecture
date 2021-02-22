using Pulumi;
using Pulumi.AzureNextGen.Resources.Latest;

namespace azure_reference_architecture
{
    public class Init : Stack
    {
        public Init()
        {
            var baseinfra = new BaseInfrastructure();
        }
    }
}