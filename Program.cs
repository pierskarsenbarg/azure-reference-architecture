using System.Threading.Tasks;
using Pulumi;

namespace azure_reference_architecture
{
    class Program
    {
        static Task<int> Main() => Deployment.RunAsync<Init>();
    }
}