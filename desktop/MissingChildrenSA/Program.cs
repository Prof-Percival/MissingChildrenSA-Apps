using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MissingChildrenSA.Forms;
using MissingChildrenSA.Forms.Auth;
using MissingChildrenSA.Forms.Users;
using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Services.Auth;
using MissingChildrenSA.Services.Http;
using MissingChildrenSA.Services.Users;

namespace MissingChildrenSA;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    internal static void Main()
    {
        var host = CreateHostBuilder().Build();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var mainForm = host.Services.GetRequiredService<MainForm>();

        Application.Run(mainForm);
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<ITokenProvider, TokenProvider>();
                services.AddTransient<AuthTokenHandler>();
                services.AddSingleton<EnumLoader>();
                services.AddSingleton<CurrentUserService>();

                // Register HttpClient + NSwag-generated client
                services.AddHttpClient<ApiClient>()
                    .AddHttpMessageHandler<AuthTokenHandler>();

                services.AddTransient<ApiClient>(sp =>
                {
                    var factory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = factory.CreateClient(nameof(ApiClient));
                    return new ApiClient(Constants.ApiBaseUrl, httpClient);
                });

                // Forms
                services.AddTransient<MainForm>();
                services.AddTransient<LoginForm>();
                services.AddTransient<DashboardForm>();
                services.AddTransient<ViewUsersForm>();
            });
    }
}