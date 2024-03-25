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
                    fonts.AddFont("DMSans-Bold.ttf", "DB");
                    fonts.AddFont("fa-brand.ttf", "FAB");
                    fonts.AddFont("fa-duotone-900.ttf", "FAD");
                    fonts.AddFont("fa-light-300.ttf", "FAL");
                    fonts.AddFont("fa-regular.ttf", "FAR");
                    fonts.AddFont("fa-solid.ttf", "FAS");
                    fonts.AddFont("fa-thin-100.ttf", "FAT");
                    
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }

}
