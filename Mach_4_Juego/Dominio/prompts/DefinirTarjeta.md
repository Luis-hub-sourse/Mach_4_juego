Sos un programador c# y vas a definir una calse llamada Tarjeta que representa una carta de juego para un juego de cartas denominado "MACH 4".

La clase Tarjeta debe tener las siguientes propiedades:

- Categoria: una cadena que representa la categoría de la tarjeta (por ejemplo, "Aviones", "Autos", "Motos", etc.).
- Nombre: una cadena que representa el nombre de la tarjeta (por ejemplo, "F-16", "Ferrari", "Harley Davidson", etc.).
- Imagen: una cadena que representa la ruta o URL de la imagen asociada a la tarjeta.
- Caracteristica1: es un conjunto de caracteristicas que describen la tarjeta, cada caracteristica tiene un nombre y un valor numérico asociado.

Un ejemplo en JSON de una tarjeta podría ser:
```json
{
  "categoria": "autos",
  "nombre": "Torino 380",
  "imagen": "https://es.wikipedia.org/wiki/Torino_380_W#/media/Archivo:IKA_Torino_380_W_1967_01.jpg",
  "caracteristicas": {
    "cilindrada": 3770,
    "hp": 143,
    "velocidad_maxima_kmh": 175,
    "rpm_max": 4400,
    "cilindros": 6,
    "0_100_kmh": 12
  }
}
```

Define la clase Tarjeta en C# con las propiedades mencionadas y asegúrate de incluir un constructor para inicializar estas propiedades. 
Además, incluye un método para mostrar la información de la tarjeta de manera legible.