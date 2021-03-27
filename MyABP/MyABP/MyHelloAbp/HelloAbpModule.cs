using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace MyHelloAbp
{


   public  class HelloAbpModule:AbpModule
    {
        //预配置 
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<MyModulePreOptions>(options => options.IsEnable = false);
        }


        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var preOptions = context.Services.ExecutePreConfiguredActions<MyModulePreOptions>();

            if (preOptions.IsEnable)
            {
                context.Services.AddTransient<HellowordService>();
            }

            //   var configuration = context.Services.GetConfiguration();

            // var redisEnabled = configuration["Redis:IsEnabled"];

            context.Services.Configure<MyModuleOptions>(options => options.Name = "Helloworld");

        }


        public override void PostConfigureServices(ServiceConfigurationContext context)
        {
            base.PostConfigureServices(context);
        }
    }
}
