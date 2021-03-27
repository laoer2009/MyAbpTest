using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace MyHelloAbp
{

    //第二种  [Dependency(ServiceLifetime.Transient)]

    // [ExposeServices(typeof(Ihelloworldservice)]
    public class HellowordService : ITransientDependency//,第一种 IScopedDependency,ISingletonDependency//瞬时注入  
    {
        IOptions<MyModuleOptions> _options;
        public HellowordService(IOptions<MyModuleOptions> options)
        {
            _options = options;
        }
        public void Run()
        {
            Console.WriteLine($"Hello World {Guid.NewGuid().ToString()}");

            Console.WriteLine($"值: {_options.Value.Name}");
        }
    }
}
