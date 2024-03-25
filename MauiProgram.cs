using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace Crypto_NFT_UI
{
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
                    fonts.AddFont("Poppins-Bold.ttf", "PB");
                    fonts.AddFont("Poppins-Italic.ttf", "PI");
                    fonts.AddFont("Poppins-Light.ttf", "PL");
                    fonts.AddFont("Poppins-Medium.ttf", "PM");
                    fonts.AddFont("Poppins-Regular.ttf", "PR");
                    fonts.AddFont("Poppins-SemiBold.ttf", "PS");
                    fonts.AddFont("Poppins-Thin.ttf", "PT");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }

}
