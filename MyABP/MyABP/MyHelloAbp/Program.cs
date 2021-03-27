using System;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;
namespace MyHelloAbp
{
    class Program
    {
        static void Main(string[] args)
        {
            var appliction = AbpApplicationFactory.Create<HelloAbpModule>();

            appliction.Initialize();

            var service = appliction.ServiceProvider.GetRequiredService<HellowordService>();

            service.Run();

            service = appliction.ServiceProvider.GetRequiredService<HellowordService>();

            service.Run();

        }
    }
}
