﻿using Microsoft.Extensions.Logging;


namespace Carros;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                fonts.AddFont("Oswald-Regular.ttf", "Oswald");
                fonts.AddFont("Oswald-SemiBold.ttf", "Oswalbold");
                fonts.AddFont("Oswald-Light.ttf", "OswaldLight");

            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
