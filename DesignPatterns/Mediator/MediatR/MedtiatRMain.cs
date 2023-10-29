using Autofac;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator.MediatR
{
    public class MedtiatRMain
    {
        public static async Task Main()
        {
            /*
            var builder = new ContainerBuilder();
            builder.RegisterType<Mediator>()
              .As<IMediator>()
              .InstancePerLifetimeScope(); // singleton

            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(MedtiatRMain).Assembly)
              .AsImplementedInterfaces();

            var container = builder.Build();
            var mediator = container.Resolve<IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine($"We got a pong at {response.Timestamp}");
            */

            var assembly = typeof(MedtiatRMain).Assembly;
            var sc = new ServiceCollection();
            sc.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
            var sp = sc.BuildServiceProvider();
            var mediator = sp.GetRequiredService<IMediator>();
            var response = await mediator.Send(new PingCommand());
            Console.WriteLine($"We got a pong at {response.Timestamp}");

        }

    }
}
