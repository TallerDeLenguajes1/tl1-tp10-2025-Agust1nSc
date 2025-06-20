using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

using EspacioComercio;

HttpClient client = new HttpClient();
string url = "https://fakestoreapi.com/products";

string cuerpo = await client.GetStringAsync(url);

List<Productos> producto = JsonSerializer.Deserialize<List<Productos>>(cuerpo);

foreach (var productoAux in producto)
{
    Console.WriteLine("Nombre: " + productoAux.title);
    Console.WriteLine("Categoria: " + productoAux.category);
    Console.WriteLine("Precio: $" + productoAux.price);
}

string archivoJson = JsonSerializer.Serialize(producto);
File.WriteAllText("productos.json", archivoJson);