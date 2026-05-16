using Dominio;

namespace Presistencia
{
    public interface ITarjetaRepositorio
    {
        Task<List<Tarjeta>> ObtenerPorCategoriaAsync(string categoria);
        Task<List<Tarjeta>> ObtenerTodasAsync();
    }
}