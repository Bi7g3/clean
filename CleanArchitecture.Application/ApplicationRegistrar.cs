using CleanArchitecture.Application.Behaviors;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application
{
    public static class ApplicationRegistrar
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(confg =>
            {
                confg.RegisterServicesFromAssembly(typeof(ApplicationRegistrar).Assembly);
                confg.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            services.AddValidatorsFromAssembly(typeof(ApplicationRegistrar).Assembly);
            return services;
        }
    }
}
