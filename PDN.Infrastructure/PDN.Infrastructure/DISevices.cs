
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PDN.Application.StateSaver;
using PDN.Infrastructure.DBContexts;
using PDN.Domain.Queries.Tasks;
using PDN.Domain.Commands.Tasks;
using PDN.Domain.Queries.Projects;
using PDN.Domain.Commands.Projects;
using PDN.Shared.Abstraction.Queries;
using PDN.Shared.Abstraction.Commans;
using PDN.Infrastructure.Repo.Commands.Base;
using PDN.Infrastructure.Repo.Queries.Base;
using PDN.Infrastructure.Repo.Commands.Projects;
using PDN.Infrastructure.Repo.Queries.Projects;
using PDN.Infrastructure.Repo.Commands.Tasks;
using PDN.Infrastructure.Repo.Queries.Tasks;

namespace PDN.Application
{
    public static class DISevices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.TryAddScoped<IStateSaver, PDN.Infrastructure.StateSaver.StateSaver>();
            services.TryAddScoped(typeof(ICommandRepo<,>), typeof(CommandRepo<,>));
            services.TryAddScoped(typeof(IQueryRepo<>), typeof(QueryRepo<>));
            services.TryAddScoped<IProjectCommandRepo, ProjectCommandRepo>();
            services.TryAddScoped<IProjectQueryRepo, ProjectQueryRepo>();
            services.TryAddScoped<ITaskCommandRepo, TaskCommandRepo>();
            services.TryAddScoped<ITaskQueryRepo, TaskQueryRepo>();

            services.AddDbContext<PDNDBContext>(cfg =>
            {

                cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}
