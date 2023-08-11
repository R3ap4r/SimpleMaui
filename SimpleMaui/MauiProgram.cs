using Microsoft.Extensions.Logging;
using SimpleMaui.Services;
using SimpleMaui.ViewModels;
using SimpleMaui.Views;

namespace SimpleMaui;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf","OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf","OpenSansSemibold");
			});

		builder.Services.AddSingleton<INavigationService,NavigationService>();

		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<MainView>();

		return builder.Build();
	}
}
