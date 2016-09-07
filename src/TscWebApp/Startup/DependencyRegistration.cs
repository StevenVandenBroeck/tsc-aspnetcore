using Microsoft.Extensions.DependencyInjection;

namespace TscWebApp
{
	public static class DependencyRegistration
	{
		public static IServiceCollection AddDependencies(this IServiceCollection services)
		{
	       // Register your application's services here, e.g. services.AddTransient<IMyService, MyService>();
           
           return services;
		}
	}
}