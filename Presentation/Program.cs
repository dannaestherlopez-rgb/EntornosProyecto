using DataAccess.Extensions;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                // EF Core + Repositorios
                services.AddDataAccess(context.Configuration);

                // Servicios del dominio (casos de uso)
                services.AddScoped<CustomerService>();

                // Forms
                services.AddTransient<Form2>();
            })
            .Build();

            var mainForm = host.Services.GetRequiredService<Form2>();

            Application.Run(mainForm);
        }
    }
}