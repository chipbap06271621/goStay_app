using Microsoft.Extensions.Logging;

namespace goStay;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Lexend-Regular.ttf", "LexendRegular");
                fonts.AddFont("Lexend-Medium.ttf", "LexendMedium");
                fonts.AddFont("Lexend-Bold.ttf", "LexendBold");
                fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                fonts.AddFont("FontAwesome6BrandsRegular400.otf", "FontBrandsRegular");
                fonts.AddFont("FontAwesome6FreeRegular400.otf", "FontRegular");
                fonts.AddFont("FontAwesome6FreeSolid900.otf", "FontSolid");
            });


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
