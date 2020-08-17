using System;
using Fixer.CQRS.Queries.Dispatchers;
using Microsoft.Extensions.DependencyInjection;

namespace Fixer.CQRS.Queries
{
    public static class Extensions
    {
        public static IFixerBuilder AddQueryHandlers(this IFixerBuilder builder)
        {
            builder.Services.Scan(s =>
                s.FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                    .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
                    .AsImplementedInterfaces()
                    .WithTransientLifetime());

            return builder;
        }

        public static IFixerBuilder AddInMemoryQueryDispatcher(this IFixerBuilder builder)
        {
            builder.Services.AddSingleton<IQueryDispatcher, QueryDispatcher>();
            return builder;
        }
    }
}
