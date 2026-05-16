
namespace Dominio
{
    public interface ITarjetaServicio
    {
        Task<List<Tarjeta>> ObtenerTarjetasPorCategoriaAsync(string categoria);
        Task<List<Tarjeta>> ObtenerTodasLasTarjetasAsync();
    }
}