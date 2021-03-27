using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.DependencyInjection;

namespace MyHelloAbp
{
  public   class HellowordService:ITransientDependency//瞬时注入  
    {
        public void Run()
        {
            Console.WriteLine($"Hello World {Guid.NewGuid().ToString()}");
        }
    }
}
