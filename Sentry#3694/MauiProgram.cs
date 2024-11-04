using Microsoft.Extensions.Logging;

namespace Sentry_3694
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSentry(options =>
                {
                    // The DSN is the only required option.
                    options.Dsn = "https://eb18e953812b41c3aeb042e666fd3b5c@o447951.ingest.sentry.io/5428537";

                    // By default, we will send the last 100 breadcrumbs with each event.
                    // If you want to see everything we can capture from MAUI, you may wish to use a larger value.
                    options.MaxBreadcrumbs = 1000;

                    // Be aware that screenshots may contain PII
                    options.AttachScreenshot = true;
#if ANDROID
                    options.Android.LogCatIntegration = Sentry.Android.LogCatIntegrationType.Unhandled;
#endif

                    options.Debug = true;
                    options.SampleRate = 1.0F;
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
