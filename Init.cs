using Pulumi;

namespace azure_reference_architecture
{
    public class Init : Stack
    {
        public Init()
        {
            var baseInfra = new Base();
        }
    }
}