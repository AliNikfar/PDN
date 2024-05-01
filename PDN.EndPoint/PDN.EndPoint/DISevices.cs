using PDN.EndPoint.MiddleWares;

namespace PDN.EndPoint
{
    public static class DIServices
    {
        public static IServiceCollection AddWebApiServices(this IServiceCollection services)
        {
            services.AddTransient<ExceptionHandlingMW>();

            return services;
        }
    }
}
