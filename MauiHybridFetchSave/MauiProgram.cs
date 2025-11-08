using MauiHybridFetchSave.Services;
using Microsoft.Extensions.Logging;

namespace MauiHybridFetchSave;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<IApiService, ApiService>();
        builder.Services.AddSingleton<IRepository, SqliteRepository>();

        return builder.Build();
    }
}
