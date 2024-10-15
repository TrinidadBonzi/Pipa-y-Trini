using CDatos.Repositories;
using CDatos.Repositories.Contracts;
using CLogica.Implementations;
using CLogica.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using CDatos.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using CPresentacion;

namespace EjemploRepositorios
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            _serviceProvider = host.Services;

            Application.Run(_serviceProvider.GetRequiredService<Menudeinicio>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddTransient<IAutorLogic, AutorLogic>();
                    services.AddTransient<IEmpleadoLogic, EmpleadoLogic>();
                    services.AddTransient<IPersonaLogic, PersonaLogic>();
                    services.AddTransient<ILibroLogic, LibroLogic>();
                    services.AddTransient<IClienteLogic, ClienteLogic>();
                    services.AddTransient<IEditorialLogic, EditorialLogic>();
                    services.AddTransient<ICopiaLogic, CopiaLogic>();


                    services.AddTransient<IAutorRepository, AutorRepository>();
                    services.AddTransient<IEmpleadoRepository, EmpleadoRepository>();
                    services.AddTransient<IPersonaRepository, PersonaRepository>();
                    services.AddTransient<ILibroRepository, LibroRepostry>();
                    services.AddTransient<IClienteRepository, ClienteRepository>();
                    services.AddTransient<IEditorialRepository, EditorialRepository>();
                    services.AddTransient<ICopiaRepository, CopiaRepository>();


                    services.AddTransient<ABMAutor>();
                    services.AddTransient<ABMAutor>();
                    services.AddTransient<Menudeinicio>();

                    services.AddDbContext<LibreriaContext>(options => options.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibreriaProg2024;Integrated Security=True;TrustServerCertificate=true"), ServiceLifetime.Transient);
                });
        }
    }
}