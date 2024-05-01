using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PDN.Application.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDN.Application
{
    public static class DISevices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = typeof(DISevices).Assembly; 

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(assembly);
            });

            services.AddValidatorsFromAssembly(assembly);

            return services;

        }
    }
}
