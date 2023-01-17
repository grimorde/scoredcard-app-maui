namespace ScorecardApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ScorecardsViewModel>();

        builder.Services.AddSingleton<ScorecardsPage>();

        builder.Services.AddSingleton<SettingsViewModel>();

        builder.Services.AddSingleton<SettingsPage>();

		return builder.Build();
	}
}
