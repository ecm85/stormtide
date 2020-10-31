using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Stormtide
{
    public class LocalEntryPoint
    {
        public static void Main() =>
             WebHost.CreateDefaultBuilder()
                 .UseStartup<Startup>()
                 .Build()
                 .Run();
    }
}
