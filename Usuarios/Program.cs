using System.Text.Json;
using EspacioUsuarios;

HttpClient client = new HttpClient();

string url = "https://jsonplaceholder.typicode.com/users";

string cuerpo = await client.GetStringAsync(url);

List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(cuerpo);

Console.WriteLine("Primeros 5 usuarios");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Usuario: " + usuarios[i].name);
    Console.WriteLine("Correo: " + usuarios[i].email);
    Console.WriteLine("Domicilio: "+ usuarios[i].address.city  + " "+ usuarios[i].address.street +" "+ usuarios[i].address.suite);
}