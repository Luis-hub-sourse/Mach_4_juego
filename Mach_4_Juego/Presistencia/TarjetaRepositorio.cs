using Dominio;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Presistencia;

public class TarjetaRepositorio : ITarjetaRepositorio
{
    private readonly IMongoCollection<Tarjeta> _tarjetasCollection;

    public TarjetaRepositorio(MongoDbSettings settings)
    {
        BsonClassMap.RegisterClassMap<Tarjeta>(cm =>
        {
            cm.AutoMap();
            cm.SetIgnoreExtraElements(true);
        });

        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        _tarjetasCollection = database.GetCollection<Tarjeta>(settings.CollectionName);
    }

    public async Task<List<Tarjeta>> ObtenerTodasAsync()
    {
        return await _tarjetasCollection.Find(_ => true).ToListAsync();
    }

    public async Task<List<Tarjeta>> ObtenerPorCategoriaAsync(string categoria)
    {
        return await _tarjetasCollection.Find(t => t.Categoria == categoria).ToListAsync();
    }
}
