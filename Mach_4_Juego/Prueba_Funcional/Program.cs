using Dominio;
using Microsoft.Extensions.Configuration;
using Presistencia;

class Program
{
    static async Task Main(string[] args)
    {
        // Leer appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        // Mapear sección MongoDbSettings
        var settings = configuration
            .GetSection("MongoDb")
            .Get<MongoDbSettings>();

        // Crear repositorio
        var repo = new TarjetaRepositorio(settings!);

        // Obtener todas las tarjetas
        var tarjetas = await repo.ObtenerTodasAsync();

        Console.WriteLine("Tarjetas encontradas:\n");

        foreach (var tarjeta in tarjetas)
        {
            tarjeta.MostrarInformacion();
            Console.WriteLine("------------------");
        }

        // Buscar por categoría
        var autos = await repo.ObtenerPorCategoriaAsync("autos");

        Console.WriteLine("\nTarjetas Autos:\n");

        foreach (var tarjeta in autos)
        {
            tarjeta.MostrarInformacion();
            Console.WriteLine("------------------");
        }
    }
}