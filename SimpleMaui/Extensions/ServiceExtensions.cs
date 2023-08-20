using SimpleMaui.Services;
using SimpleMaui.ViewModels;
using SimpleMaui.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMaui.Extensions;
public static class ServiceExtensions
{
	/// <summary>
	/// Add Views and ViewModels to the service collection
	/// </summary>
	/// <param name="services"></param>
	/// <returns>Views and Viewmodels as services</returns>
	public static IServiceCollection AddViewsAndViewModels(this IServiceCollection services)
	{
		/// ViewModels
		services.AddTransient<MainViewModel>();
		services.AddTransient<LogInViewModel>();

		/// Views
		services.AddTransient<MainView>();
		services.AddTransient<LogInView>();

		return services;
	}
	/// <summary>
	/// Add Services to the service collection
	/// </summary>
	/// <param name="services"></param>
	/// <returns></returns>
	public static IServiceCollection AddServices(this IServiceCollection services)
	{
		services.AddSingleton<INavigationService,NavigationService>();
		return services;
	}
}
