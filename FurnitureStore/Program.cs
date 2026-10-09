using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FurnitureStore.Domain.Repositories;
using FurnitureStore.Application.Abstractions;
using FurnitureStore.Application.Presenters;
using FurnitureStore.Application.Views;
using FurnitureStore.Forms;
using FurnitureStore.Infrastructure.Database.Repositories;
using FurnitureStore.Services;

namespace FurnitureStore;

internal static class Program
{
    public static IServiceProvider Services { get; private set; } = null!;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        HostApplicationBuilder builder = Host.CreateApplicationBuilder();
        ConfigureService(builder.Services);
        IHost host = builder.Build();
        Services = host.Services;
        host.RunAsync();

        using (IServiceScope scope = Services.CreateScope())
        {
            scope.ServiceProvider.GetRequiredService<Infrastructure.Database.ApplicationContext>().Database.EnsureCreated();
        }

        ApplicationConfiguration.Initialize();

        MainPresenter main = Services.GetRequiredService<MainPresenter>();
        main.Run();
        System.Windows.Forms.Application.Run((Form)main.View);
    }

    private static void ConfigureService(IServiceCollection services)
    {
        services.AddDbContext<Infrastructure.Database.ApplicationContext>();

        services.AddScoped<IFurnitureRepository, FurnitureRepository>();
        services.AddScoped<IPriceHistoryRepository, PriceHistoryRepository>();
        services.AddScoped<ISaleRepository, SaleRepository>();

        services.AddSingleton<IMessageService, MessageService>();

        services.AddSingleton<IMainView, MainForm>();

        services.AddTransient<IPriceGraphView, PriceGraphForm>();

        services.AddSingleton<MainPresenter>();

        services.AddTransient<PriceGraphPresenter>();
    }
}