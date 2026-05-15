namespace Dominio;

public class Tarjeta
{
    public string Categoria { get; set; }
    public string Nombre { get; set; }
    public string Imagen { get; set; }
    public Dictionary<string, double> Caracteristicas { get; set; }

    public Tarjeta(string categoria, string nombre, string imagen, Dictionary<string, double> caracteristicas)
    {
        Categoria = categoria;
        Nombre = nombre;
        Imagen = imagen;
        Caracteristicas = caracteristicas;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Categoría: {Categoria}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Imagen: {Imagen}");
        Console.WriteLine("Características:");
        if (Caracteristicas != null)
        {

            foreach (var kvp in Caracteristicas)
            {
                Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
            }
        }
    }
}
